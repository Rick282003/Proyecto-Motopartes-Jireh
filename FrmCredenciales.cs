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
    public partial class Credenciales : Form
    {
        public Credenciales()
        {
            InitializeComponent();
        }
        clsConexion conexion = new clsConexion(); //Instancia de Clase Global

        private void Form1_Load(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
            conexion.Abrir(); //Abrimos conexion a SQL
        }
    
        private void pobmostrar_Click(object sender, EventArgs e)
        {
            pobocultar.BringToFront();
            txtContraseña.PasswordChar = '\0';
        }

        private void pobocultar_Click(object sender, EventArgs e)
        {
            pobmostrar.BringToFront();
            txtContraseña.PasswordChar = '*';
        }

        private void lblOlvidar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contacte al administrador ejemploCorreo@gmail.com", "AYUDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Variables de los TextBox
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Crear la consulta SQL
            string query = "SELECT IDEmpleado FROM Usuarios WHERE Nombre = @usuario AND Contraseña = @contraseña";

            /* Consulta SQL para obtener ID_Empleado
            string query1 = "SELECT IDEmpleado FROM Usuarios WHERE Nombre = @usuario AND Contraseña = @contraseña";*/

            // Parámetros SQL
            SqlCommand cmd = new SqlCommand(query, conexion.SC);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);

            try
            {
                // Ejecutar la consulta
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) // Si encontró el usuario
                {

                    // Si existe, mostrar mensaje y abrir formulario de bienvenido
                    reader.Read();  // Mover al primer (y único) resultado

                    UsuarioActual.IDEmpleado = reader.GetInt32(0); // Obtener IDEmpleado
                    MessageBox.Show($"IDEmpleado recuperado: {UsuarioActual.IDEmpleado}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmBienvenido bienve = new FrmBienvenido(txtUsuario.Text);
                    this.Hide();
                    bienve.Show();
                }
                else
                {
                    // Si no existe, mostrar mensaje de error
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                // Cerrar el reader
                reader.Close();
                MessageBox.Show("Insertando compras y ventas con IDEmpleado: " + UsuarioActual.IDEmpleado);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al validar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static class UsuarioActual
        {
            public static int IDEmpleado { get; set; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
