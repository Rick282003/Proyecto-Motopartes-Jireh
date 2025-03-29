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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        clsConexion conexion = new clsConexion();
        clsAccion acciones = new clsAccion();
        SqlCommand cmd;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsuario(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarComboBox()
        {
            try
            {
                // Definir la consulta
                string query = "SELECT IDNivel, Nombre FROM Nivel";

                // Crear lista para almacenar los datos
                List<KeyValuePair<int, string>> niveles = new List<KeyValuePair<int, string>>();

                using (SqlCommand cmd = new SqlCommand(query, conexion.SC))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            niveles.Add(new KeyValuePair<int, string>(
                                Convert.ToInt32(reader["IDNivel"]),
                                reader["Nombre"].ToString()
                            ));
                        }
                    }
                }

                // Asignar la lista al ComboBox
                cmbNivelUsuario.DataSource = new BindingSource(niveles, null);
                cmbNivelUsuario.DisplayMember = "Value"; // Muestra el nombre
                cmbNivelUsuario.ValueMember = "Key"; // Guarda el ID
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los niveles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboBox2()
        {
            try
            {
                string query = "SELECT IDCargo, Nombre FROM Cargo";
                List<KeyValuePair<int, string>> cargos = new List<KeyValuePair<int, string>>();

                using (SqlCommand cmd = new SqlCommand(query, conexion.SC))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cargos.Add(new KeyValuePair<int, string>(
                                Convert.ToInt32(reader["IDCargo"]),
                                reader["Nombre"].ToString()
                            ));
                        }
                    }
                }

                // Asignar la lista al ComboBox
                cmbCargoEmpleado.DataSource = new BindingSource(cargos, null);
                cmbCargoEmpleado.DisplayMember = "Value";
                cmbCargoEmpleado.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los cargos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            conexion.Abrir();
            acciones.CargarDatos(dgvRegistroEmpleado, "Empleados");
            acciones.CargarDatos(dgvRegistroUsuario, "Usuarios");
            CargarComboBox();
            CargarComboBox2();
        }

        private void txtIDEmpleado_TextChanged(object sender, EventArgs e)
        {
            txtIDUsuario.Text = txtIDEmpleado.Text;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexion.SC;
                    cmd.Transaction = conexion.SC.BeginTransaction(); // Inicia una transacción

                    // Insertar el empleado
                    cmd.CommandText = "INSERT INTO Empleados (IDEmpleado, Nombre, Apellido, FechaNacimiento, CorreoElectronico, RTN, Telefono, IDCargo) " +
                                      "VALUES (@IDEmpleado, @Nombre, @Apellido, @FechaNacimiento, @CorreoElectronico, @RTN, @Telefono, @IDCargo)";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@IDEmpleado", Convert.ToInt32(txtIDEmpleado.Text));
                    cmd.Parameters.AddWithValue("@Nombre", txtNombreEmpleado.Text);
                    cmd.Parameters.AddWithValue("@Apellido", txtApellidoEmpleado.Text);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", txtCorreoElectronico.Text);
                    cmd.Parameters.AddWithValue("@RTN", txtRTN.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@IDCargo", ((KeyValuePair<int, string>)cmbCargoEmpleado.SelectedItem).Key);

                    cmd.ExecuteNonQuery();

                    // Insertar el usuario vinculado al empleado
                    cmd.CommandText = "INSERT INTO Usuarios (IDEmpleado, Nombre, Contraseña, IDNivel) " +
                                      "VALUES (@IDEmpleado, @Usuario, @Contraseña, @IDNivel)";

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@IDEmpleado", Convert.ToInt32(txtIDEmpleado.Text));
                    cmd.Parameters.AddWithValue("@Usuario", txtNombreUsuario.Text);
                    cmd.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);
                    cmd.Parameters.AddWithValue("@IDNivel", ((KeyValuePair<int, string>)cmbNivelUsuario.SelectedItem).Key);

                    cmd.ExecuteNonQuery();

                    // Confirmar transacción
                    cmd.Transaction.Commit();

                    MessageBox.Show("Empleado y usuario agregados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar los DataGridView
                    acciones.CargarDatos(dgvRegistroEmpleado, "Empleados");
                    acciones.CargarDatos(dgvRegistroUsuario, "Usuarios");

                    // Limpiar los campos
                    txtIDEmpleado.Clear();
                    txtNombreEmpleado.Clear();
                    txtApellidoEmpleado.Clear();
                    dtpFechaNacimiento.Value = DateTime.Now;
                    txtCorreoElectronico.Clear();
                    txtRTN.Clear();
                    txtTelefono.Clear();
                    txtNombreUsuario.Clear();
                    txtContraseña.Clear();
                    txtConfirmarContraseña.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar empleado y usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRegistroUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se haya hecho clic en una fila
            if (e.RowIndex >= 0)
            {
                // Obtener los valores de la fila seleccionada
                DataGridViewRow row = dgvRegistroUsuario.Rows[e.RowIndex];

                // Cargar los valores en los TextBox correspondientes
                txtIDUsuario.Text = row.Cells["IDEmpleado"].Value.ToString(); // El IDUsuario es el mismo que el IDEmpleado
                txtNombreUsuario.Text = row.Cells["Nombre"].Value.ToString();
                txtContraseña.Text = row.Cells["Contraseña"].Value.ToString();
                cmbNivelUsuario.SelectedValue = row.Cells["IDNivel"].Value;
            }
        }

        private void dgvRegistroEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se haya hecho clic en una fila
            if (e.RowIndex >= 0)
            {
                // Obtener los valores de la fila seleccionada
                DataGridViewRow row = dgvRegistroEmpleado.Rows[e.RowIndex];

                // Cargar los valores en los TextBox correspondientes
                txtIDEmpleado.Text = row.Cells["IDEmpleado"].Value.ToString();
                txtNombreEmpleado.Text = row.Cells["Nombre"].Value.ToString();
                txtApellidoEmpleado.Text = row.Cells["Apellido"].Value.ToString();
                dtpFechaNacimiento.Value = Convert.ToDateTime(row.Cells["FechaNacimiento"].Value);
                txtCorreoElectronico.Text = row.Cells["CorreoElectronico"].Value.ToString();
                txtRTN.Text = row.Cells["RTN"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();

                // Cargar el Cargo en el ComboBox
                cmbCargoEmpleado.SelectedValue = row.Cells["IDCargo"].Value;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIDEmpleado.Clear();
            txtIDUsuario.Clear();
            txtNombreEmpleado.Clear();
            txtApellidoEmpleado.Clear();
            txtCorreoElectronico.Clear();
            txtRTN.Clear();
            txtTelefono.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
            txtNombreUsuario.Clear();
            txtContraseña.Clear();
            cmbCargoEmpleado.SelectedIndex = -1;
            cmbNivelUsuario.SelectedIndex = -1;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // actualizar el empleado
                using (SqlCommand cmd = new SqlCommand("UPDATE Empleados SET Nombre = @Nombre, Apellido = @Apellido, FechaNacimiento = @FechaNacimiento, CorreoElectronico = @CorreoElectronico, RTN = @RTN, Telefono = @Telefono, IDCargo = @IDCargo WHERE IDEmpleado = @IDEmpleado", conexion.SC))
                {
                    cmd.Parameters.AddWithValue("@IDEmpleado", txtIDEmpleado.Text);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombreEmpleado.Text);
                    cmd.Parameters.AddWithValue("@Apellido", txtApellidoEmpleado.Text);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value);
                    cmd.Parameters.AddWithValue("@CorreoElectronico", txtCorreoElectronico.Text);
                    cmd.Parameters.AddWithValue("@RTN", txtRTN.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@IDCargo", cmbCargoEmpleado.SelectedValue);

                    cmd.ExecuteNonQuery();
                }

                // Luego actualizamos el usuario
                using (SqlCommand cmd = new SqlCommand("UPDATE Usuarios SET Nombre = @Nombre, Contraseña = @Contraseña, IDNivel = @IDNivel WHERE IDEmpleado = @IDEmpleado", conexion.SC))
                {
                    cmd.Parameters.AddWithValue("@IDEmpleado", txtIDUsuario.Text);  // El IDUsuario es el mismo que el IDEmpleado
                    cmd.Parameters.AddWithValue("@Nombre", txtNombreUsuario.Text);
                    cmd.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);
                    cmd.Parameters.AddWithValue("@IDNivel", cmbNivelUsuario.SelectedValue);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Empleado y usuario actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar los DataGridView
                acciones.CargarDatos(dgvRegistroEmpleado, "Empleados");
                acciones.CargarDatos(dgvRegistroUsuario, "Usuarios");

                // Limpiar los campos
                txtIDEmpleado.Clear();
                txtNombreEmpleado.Clear();
                txtApellidoEmpleado.Clear();
                dtpFechaNacimiento.Value = DateTime.Now;
                txtCorreoElectronico.Clear();
                txtRTN.Clear();
                txtTelefono.Clear();
                txtNombreUsuario.Clear();
                txtContraseña.Clear();
                txtConfirmarContraseña.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar empleado y usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
