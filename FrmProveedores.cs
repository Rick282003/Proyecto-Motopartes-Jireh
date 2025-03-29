using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Motopartes_Jireh
{
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }
        clsConexion conexion = new clsConexion();
        clsAccion acciones = new clsAccion();
        SqlCommand cmd;

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario inve = new FrmInventario();
            this.Hide();
            inve.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuarios user = new FrmUsuarios();
            this.Hide();
            user.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            FrmCompras comp = new FrmCompras();
            this.Hide();
            comp.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmVentas vent = new FrmVentas();
            this.Hide();
            vent.Show();
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

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorial histo = new FrmHistorial();
            this.Hide();
            histo.Show();
        }

        private void btnCierre_Click(object sender, EventArgs e)
        {
            FrmCierreCaja caja = new FrmCierreCaja();
            this.Hide();
            caja.Show();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            conexion.Abrir(); //Abrimos conexion a SQL
            acciones.CargarDatos(dgvData, "Proveedores"); //Metodo para cargar los datos, entre comillas porque es string
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {/*
            try
            {
                if (txtID.Text == string.Empty && txtNombreProveedor.Text == string.Empty && txtTipoProveedor.Text == string.Empty) // "Texto vacio"
                {
                    MessageBox.Show("No se pueden llenar los datos, ingreselos", "ERROR");
                }//Fin if
                else
                {

                    cmd = new SqlCommand("Insert into Proveedores (IDProveedor, NombreProveedor, FechaRegistro, TipoProveedor, Estado, IDContacto) values (" + txtID.Text + ", '" + txtNombreProveedor.Text + "', '" + dtpRegistroProveedor.Value + "', '" + txtTipoProveedor.Text + "', '" + chbActivo.CheckState + "', '" + txtID.Text + ")", conexion.SC);
                    cmd.ExecuteNonQuery(); //PARA EJECUTAR ESE QUERRY
                    MessageBox.Show("Registros insertados", "INFORMACION", MessageBoxButtons.OK);
                    acciones.CargarDatos(dgvData, "Proveedores");//ACTUALIZAMOS EL DATAGRIDVIEW
                                                      // txtmarcaVehiculo.Clear();
                                                      //txtmarcaVehiculo.Focus();
                }//Fin else
            }//Fin try
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }//Fin catch
            */
            try
            {
                // Validar que los campos requeridos no estén vacíos
                if (string.IsNullOrWhiteSpace(txtID.Text) ||
                    string.IsNullOrWhiteSpace(txtNombreProveedor.Text) ||
                    string.IsNullOrWhiteSpace(txtTipoProveedor.Text))
                {
                    MessageBox.Show("No se pueden llenar los datos, ingréselos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Definir la consulta con parámetros
                string query = "INSERT INTO Proveedores (IDProveedor, NombreProveedor, FechaRegistro, TipoProveedor, Telefono, CorreoElectronico, Estado, Direccion) " +
                               "VALUES (@IDProveedor, @NombreProveedor, @FechaRegistro, @TipoProveedor, @Telefono, @CorreoElectronico, @Estado, @Direccion)";

                using (SqlCommand cmd = new SqlCommand(query, conexion.SC))
                {
                    // Asignar valores a los parámetros
                    cmd.Parameters.AddWithValue("@IDProveedor", Convert.ToInt32(txtID.Text)); // ID es INT
                    cmd.Parameters.AddWithValue("@NombreProveedor", txtNombreProveedor.Text);
                    cmd.Parameters.AddWithValue("@FechaRegistro", dtpRegistroProveedor.Value); // Fecha como DateTime
                    cmd.Parameters.AddWithValue("@TipoProveedor", txtTipoProveedor.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", txtCorreoElectronico.Text);
                    cmd.Parameters.AddWithValue("@Estado", chbActivo.Checked ? 1 : 0); // Estado como 1 o 0
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);

                    // Ejecutar la consulta
                    cmd.ExecuteNonQuery();
                }

                // Mostrar mensaje de éxito
                MessageBox.Show("Registros insertados correctamente.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar DataGridView
                acciones.CargarDatos(dgvData, "Proveedores");

                // Limpiar los campos después de guardar
                txtID.Clear();
                txtNombreProveedor.Clear();
                txtTipoProveedor.Clear();
                chbActivo.Checked = false;
                dtpRegistroProveedor.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar que no sea un clic en el encabezado
            {
                DataGridViewRow row = dgvData.Rows[e.RowIndex];

                // Llenar los TextBox con los valores de la fila seleccionada
                txtID.Text = row.Cells["IDProveedor"].Value.ToString();
                txtNombreProveedor.Text = row.Cells["NombreProveedor"].Value.ToString();
                dtpRegistroProveedor.Value = Convert.ToDateTime(row.Cells["FechaRegistro"].Value);
                txtTipoProveedor.Text = row.Cells["TipoProveedor"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtCorreoElectronico.Text = row.Cells["CorreoElectronico"].Value.ToString();
                chbActivo.Checked = Convert.ToBoolean(row.Cells["Estado"].Value);
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos requeridos no estén vacíos
                if (string.IsNullOrWhiteSpace(txtID.Text) ||
                    string.IsNullOrWhiteSpace(txtNombreProveedor.Text) ||
                    string.IsNullOrWhiteSpace(txtTipoProveedor.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                    string.IsNullOrWhiteSpace(txtCorreoElectronico.Text) ||
                    string.IsNullOrWhiteSpace(txtDireccion.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Consulta SQL para actualizar todos los campos
                string query = "UPDATE Proveedores SET NombreProveedor = @NombreProveedor, FechaRegistro = @FechaRegistro, " +
                               "TipoProveedor = @TipoProveedor, Telefono = @Telefono, CorreoElectronico = @CorreoElectronico, " +
                               "Direccion = @Direccion, Estado = @Estado WHERE IDProveedor = @IDProveedor";

                using (SqlCommand cmd = new SqlCommand(query, conexion.SC))
                {
                    // Asignar valores a los parámetros
                    cmd.Parameters.AddWithValue("@IDProveedor", Convert.ToInt32(txtID.Text));
                    cmd.Parameters.AddWithValue("@NombreProveedor", txtNombreProveedor.Text);
                    cmd.Parameters.AddWithValue("@FechaRegistro", dtpRegistroProveedor.Value);
                    cmd.Parameters.AddWithValue("@TipoProveedor", txtTipoProveedor.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", txtCorreoElectronico.Text);
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@Estado", chbActivo.Checked ? 1 : 0);

                    // Ejecutar la consulta
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Proveedor actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargar el DataGridView
                        acciones.CargarDatos(dgvData, "Proveedores");

                        // Limpiar los campos
                        txtID.Clear();
                        txtNombreProveedor.Clear();
                        txtTipoProveedor.Clear();
                        txtTelefono.Clear();
                        txtCorreoElectronico.Clear();
                        txtDireccion.Clear();
                        chbActivo.Checked = false;
                        dtpRegistroProveedor.Value = DateTime.Now;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el proveedor para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que haya un ID seleccionado
                if (string.IsNullOrWhiteSpace(txtID.Text))
                {
                    MessageBox.Show("Seleccione un proveedor antes de eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirmación antes de eliminar
                DialogResult confirm = MessageBox.Show("¿Está seguro de que desea marcar como inactivo este proveedor?",
                                                       "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Consulta SQL para actualizar el estado a 0 (Inactivo)
                    string query = "UPDATE Proveedores SET Estado = 0 WHERE IDProveedor = @IDProveedor";

                    using (SqlCommand cmd = new SqlCommand(query, conexion.SC))
                    {
                        cmd.Parameters.AddWithValue("@IDProveedor", Convert.ToInt32(txtID.Text));

                        // Ejecutar la consulta
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Proveedor marcado como inactivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Recargar los datos en el DataGridView
                            acciones.CargarDatos(dgvData, "Proveedores");

                            // Limpiar los campos
                            txtID.Clear();
                            txtNombreProveedor.Clear();
                            txtTipoProveedor.Clear();
                            chbActivo.Checked = false;
                            dtpRegistroProveedor.Value = DateTime.Now;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los TextBox
            txtID.Clear();
            txtNombreProveedor.Clear();
            txtTipoProveedor.Clear();
            txtTelefono.Clear();
            txtCorreoElectronico.Clear();
            txtDireccion.Clear();

            // Reiniciar el CheckBox
            chbActivo.Checked = false;

            // Reiniciar el DateTimePicker a la fecha actual
            dtpRegistroProveedor.Value = DateTime.Now;

            // Poner el foco en el primer campo
            txtID.Focus();
        }

        private void chbActivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
