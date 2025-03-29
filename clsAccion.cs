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
    internal class clsAccion
    {
        clsConexion conexion = new clsConexion(); //Instancia de clase
        SqlDataAdapter da; //Crear un objeto, un alias. Para adaptar datos a tabla
        DataTable dt; //Alias

        //METODO
        public void CargarDatos(DataGridView dgv, string nameTable)//primer parametro: que llenar, segundo: de donde llenar
        {
            try
            {/*ESTO LLENA UN DGV CON UNA TABLA*/
                da = new SqlDataAdapter("select * from " + nameTable, conexion.SC); //Como argumento va la consulta que queramos hacer
                dt = new DataTable(); //Creamos espacio para que guarde
                da.Fill(dt); //Para llenar
                dgv.DataSource = dt;
            }//Fin try
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los datos" + ex);
            }//Fin catch
        }
        //Fin METODO

        
    }
}
