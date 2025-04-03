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


        // Método para verificar si el IDProducto ya existe
        private bool ExisteIDProducto(int idProducto)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Productos WHERE IDProducto = @IDProducto", conexion.SC))
            {
                cmd.Parameters.AddWithValue("@IDProducto", idProducto);
                conexion.Abrir();
                int count = (int)cmd.ExecuteScalar();
                conexion.Cerrar();
                return count > 0; // Retorna true si el ID ya existe
            }
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
                

                // Obtener datos del formulario
                int codigoCompra = int.Parse(txtCodigoCompra.Text); // Código de la compra del TextBox
                string nombreProducto = txtNombreProducto.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                decimal precio = Convert.ToDecimal(txtPrecioUnitario.Text);
                string marca = txtMarcaProducto.Text;
                string modelo = txtModeloProducto.Text;
                //int idProveedor = ((KeyValuePair<int, string>)cmbProveedores.SelectedItem).Key);
                DateTime fecha = DateTime.Now;

                byte[] imagenProducto = ConvertirImagenABytes(pbProducto);
                byte[] imagenComprobante = ConvertirImagenABytes(pbComprobante);

                // Abrir conexión
                conexion.Abrir();

                // 1. Verificar si el CodigoCompra ya existe
                string checkQuery = "SELECT COUNT(*) FROM Compras WHERE CodigoCompra = @CodigoCompra";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conexion.SC);
                checkCmd.Parameters.AddWithValue("@CodigoCompra", codigoCompra);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("El Código de Compra ya existe. Por favor, ingresa un Código de Compra único.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexion.Abrir();
                    return;
                }

                // 2. Insertar en la tabla Compras
                string queryCompra = "INSERT INTO Compras (CodigoCompra, NombreProducto, Fecha, Cantidad, Imagen, ImagenProducto, Precio, IDEmpleado, IDProveedor) " +
                                     "VALUES (@CodigoCompra, @NombreProducto, @Fecha, @Cantidad, @Imagen, @ImagenProducto, @Precio, @IDEmpleado, @IDProveedor)";
                SqlCommand cmdCompra = new SqlCommand(queryCompra, conexion.SC);
                cmdCompra.Parameters.AddWithValue("@CodigoCompra", codigoCompra);
                cmdCompra.Parameters.AddWithValue("@NombreProducto", nombreProducto);
                cmdCompra.Parameters.AddWithValue("@Fecha", fecha);
                cmdCompra.Parameters.AddWithValue("@Cantidad", cantidad);
                cmdCompra.Parameters.AddWithValue("@Imagen", (object)imagenComprobante ?? DBNull.Value);
                cmdCompra.Parameters.AddWithValue("@ImagenProducto", (object)imagenProducto ?? DBNull.Value);
                cmdCompra.Parameters.AddWithValue("@Precio", precio);
                cmdCompra.Parameters.AddWithValue("@IDEmpleado", UsuarioActual.IDEmpleado); // Suponiendo que hay un método para obtenerlo
                cmdCompra.Parameters.AddWithValue("@IDProveedor", ((KeyValuePair<int, string>)cmbProveedores.SelectedItem).Key);
                cmdCompra.ExecuteNonQuery();

                // 3. Insertar en la tabla Productos
                string queryProducto = "INSERT INTO Productos (IDProducto, NombreProducto, Modelo, FechaRegistro, Precio, Cantidad, Estado, CodigoCompra, IDProveedor, Marca, Imagen) " +
                                       "VALUES (@IDProducto, @NombreProducto, @Modelo, @FechaRegistro, @Precio, @Cantidad, @Estado, @CodigoCompra, @IDProveedor, @Marca, @ImagenProducto)";
                SqlCommand cmdProducto = new SqlCommand(queryProducto, conexion.SC);
                cmdProducto.Parameters.AddWithValue("@IDProducto", int.Parse(txtCodigoProducto.Text)); // IDProducto desde el TextBox
                cmdProducto.Parameters.AddWithValue("@NombreProducto", nombreProducto);
                cmdProducto.Parameters.AddWithValue("@Modelo", modelo); // Puedes modificar si hay modelo
                cmdProducto.Parameters.AddWithValue("@FechaRegistro", fecha);
                cmdProducto.Parameters.AddWithValue("@Precio", precio);
                cmdProducto.Parameters.AddWithValue("@Cantidad", cantidad);
                cmdProducto.Parameters.AddWithValue("@Estado", 1); // 1 = Activo (puedes cambiarlo según la lógica)
                cmdProducto.Parameters.AddWithValue("@CodigoCompra", codigoCompra); // Usar el CodigoCompra de la compra insertada
                cmdProducto.Parameters.AddWithValue("@IDProveedor", ((KeyValuePair<int, string>)cmbProveedores.SelectedItem).Key);
                cmdProducto.Parameters.AddWithValue("@Marca", marca);
                cmdProducto.Parameters.AddWithValue("@ImagenProducto", (object)imagenProducto ?? DBNull.Value);

                cmdProducto.ExecuteNonQuery();

                // Cerrar conexión
                conexion.Cerrar();

                // Mostrar mensaje de éxito
                MessageBox.Show("Compra y producto guardados exitosamente.");


                // Limpiar campos
                txtCodigoCompra.Clear();
                txtNombreProducto.Clear();
                txtMarcaProducto.Clear();
                txtModeloProducto.Clear();
                txtCantidad.Clear();
                txtPrecioUnitario.Clear();
                lblTotal.Text = "0.00";
                cmbProveedores.SelectedIndex = -1;
                dtpFecha.Value = DateTime.Now;
               

                // Limpiar PictureBox
                pbComprobante.Image = null;
                pbProducto.Image = null;


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

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
