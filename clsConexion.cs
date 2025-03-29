using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Motopartes_Jireh
{
    internal class clsConexion
    {
        string conexion = "Data Source = DESKTOP-QBA3PNK; Initial Catalog = Proyecto_MotopartesJireh; Integrated Security = true";//Nombre del server//Nombre DataBase//Cadena de conexion

        //INSTANCIA DE CLASE
        public SqlConnection SC = new SqlConnection();
        //Fin INSTANCIA DE CLASE

        //METODO COSNTRUCTOR
        public clsConexion()
        {
            SC.ConnectionString = conexion;//Inicializamos la cadena de conexion con la cadena de la DataBase
        }
        //Fin METODO COSNTRUCTOR

        //METODOS
        public void Abrir()
        {
            try
            {
                if (SC.State == ConnectionState.Closed)
                {
                    SC.Open();
                    MessageBox.Show("Conexión Abierta Correctamente", "MENSAJE");
                }//Fin if
            }//Fin try
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error al abrir la Base de Datos\n" + ex, "MENSAJE");
            }
        }//Fin Abrir

        public void Cerrar()
        {
            try
            {
                if (SC.State == ConnectionState.Open)
                {
                    SC.Close();
                    MessageBox.Show("Conexión Cerrada Correctamente", "MENSAJE");

                }//Fin if
            }//Fin try
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un Error al cerrar la Base de Datos\n" + ex, "MENSAJE");
            }
        }//Fin Cerrar

        //Fin METODOS
    }
}
