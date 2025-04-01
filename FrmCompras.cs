using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_Motopartes_Jireh.Credenciales;

namespace Proyecto_Motopartes_Jireh
{
    public partial class FrmCompras : Form
    {
        public FrmCompras()
        {
            InitializeComponent();
        }
        clsConexion conexion = new clsConexion();
        SqlCommand cmd;

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            conexion.Abrir();
            pbComprobante.AllowDrop = true; // Habilita Drag & Drop manualmente
            pbProducto.AllowDrop = true;
            CargarComboBox();
        }

        private void CargarComboBox()
        {
            try
            {
                // Definir la consulta
                string query = "SELECT IDProveedor, NombreProveedor FROM Proveedores";

                // Crear lista para almacenar los datos
                List<KeyValuePair<int, string>> proveedores = new List<KeyValuePair<int, string>>();

                using (SqlCommand cmd = new SqlCommand(query, conexion.SC))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            proveedores.Add(new KeyValuePair<int, string>(
                                Convert.ToInt32(reader["IDProveedor"]),
                                reader["NombreProveedor"].ToString()
                            ));
                        }
                    }
                }

                // Asignar la lista al ComboBox
                cmbProveedores.DataSource = new BindingSource(proveedores, null);
                cmbProveedores.DisplayMember = "Value"; // Muestra el nombre
                cmbProveedores.ValueMember = "Key"; // Guarda el ID
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                pbComprobante.Image = Image.FromFile(files[0]);
            }
        }

        private void pictureBox3_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                pbProducto.Image = Image.FromFile(files[0]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmVentas vent = new FrmVentas();
            this.Hide();
            vent.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuarios user = new FrmUsuarios();
            this.Hide();
            user.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes repo = new FrmReportes();
            this.Hide();
            repo.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FrmStock stock = new FrmStock();
            this.Hide();
            stock.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario inve = new FrmInventario();
            this.Hide();
            inve.Show();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorial histo = new FrmHistorial();
            this.Hide();
            histo.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores prove = new FrmProveedores();
            this.Hide();
            prove.Show();
        }

        private void btnCierre_Click(object sender, EventArgs e)
        {
            FrmCierreCaja caja = new FrmCierreCaja();
            this.Hide();
            caja.Show();
        }

        private void txtPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            if (int.TryParse(txtCantidad.Text, out int cantidad) && decimal.TryParse(txtPrecioUnitario.Text, out decimal precio))
            {
                lblTotal.Text = (cantidad * precio).ToString("C2"); // Formato de moneda
            }
            else
            {
                lblTotal.Text = "0.00";
            }
        }


        private byte[] ConvertirImagenABytes(PictureBox pictureBox)
        {
            if (pictureBox.Image == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "INSERT INTO Compras (CodigoCompra, NombreProducto, Fecha, Cantidad, Imagen, ImagenProducto, Precio, IDEmpleado, IDProveedor) " +
                               "VALUES (@CodigoCompra, @NombreProducto, @Fecha, @Cantidad, @Imagen, @ImagenProducto, @Precio, @IDEmpleado, @IDProveedor)";

                using (SqlCommand cmd = new SqlCommand(query, conexion.SC))
                {
                    cmd.Parameters.AddWithValue("@CodigoCompra", int.Parse(txtCodigoCompra.Text));
                    cmd.Parameters.AddWithValue("@NombreProducto", txtNombreProducto.Text);
                    cmd.Parameters.AddWithValue("@Fecha", dtpFecha.Value);
                    cmd.Parameters.AddWithValue("@Cantidad", int.Parse(txtCantidad.Text));
                    cmd.Parameters.AddWithValue("@Imagen", (object)ConvertirImagenABytes(pbComprobante) ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ImagenProducto", (object)ConvertirImagenABytes(pbProducto) ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Precio", decimal.Parse(txtPrecioUnitario.Text));
                    cmd.Parameters.AddWithValue("@IDEmpleado", UsuarioActual.IDEmpleado); // Tomado del login
                    cmd.Parameters.AddWithValue("@IDProveedor", ((KeyValuePair<int, string>)cmbProveedores.SelectedItem).Key);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Compra registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCodigoCompra.Clear();
                    txtNombreProducto.Clear();
                    txtCantidad.Clear();
                    txtPrecioUnitario.Clear();
                    lblTotal.Text = "0.00";
                    cmbProveedores.SelectedIndex = -1;
                    dtpFecha.Value = DateTime.Now;

                    // Limpiar PictureBox
                    pbComprobante.Image = null;
                    pbProducto.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigoCompra.Clear();
            txtNombreProducto.Clear();
            txtCantidad.Clear();
            txtPrecioUnitario.Clear();
            lblTotal.Text = "0.00";
            cmbProveedores.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;

            // Limpiar PictureBox
            pbComprobante.Image = null;
            pbProducto.Image = null;
        }
    }
}
