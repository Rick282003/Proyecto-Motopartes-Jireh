using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Motopartes_Jireh
{
    public partial class FrmBienvenido : Form
    {
        public FrmBienvenido(string usuario)
        {
            InitializeComponent();
            this.Size = new Size(1459, 836);
            CargarFormulario(new Formulario_Hora(usuario));
           
        }

        private void FrmBienvenido_Load(object sender, EventArgs e)
        {

        }

        public void CargarFormulario(Form formulario )
        {
            // Cerrar formulario anterior si hay uno abierto
            if (pnContenedor.Controls.Count > 0)
            {
                pnContenedor.Controls[0].Dispose();
            }

            // Configurar el nuevo formulario
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agregarlo al panel y mostrarlo
            pnContenedor.Controls.Add(formulario);
            pnContenedor.Tag = formulario;
            formulario.Show();
        }


        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
                
            

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            CargarFormulario(new FrmCompras())  ;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            CargarFormulario(new FrmUsuarios())  ;
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            CargarFormulario(new FrmInventario());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            CargarFormulario(new FrmVentas());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            CargarFormulario(new FrmReportes());
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            CargarFormulario(new FrmStock());
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            CargarFormulario(new FrmHistorial());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            CargarFormulario(new FrmProveedores());
        }

        private void btnCierre_Click(object sender, EventArgs e)
        {
            CargarFormulario(new FrmCierreCaja());
        }
    }
}
