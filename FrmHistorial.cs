using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace Proyecto_Motopartes_Jireh
{
    public partial class FrmHistorial : Form
    {
        public FrmHistorial()
        {
            InitializeComponent();
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            // los vectores con los datos
            string[] series = { "eduardo", "jorge", "chris" };
            int[] puntos = { 23, 10, 70 };
            chart1.Palette = ChartColorPalette.Pastel;
            chart1.Titles.Add("Transacciones");

            for (int i = 0; i < series.Length; i++)
            {
                Series serie = chart1.Series.Add(series[i]);
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
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

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario inve = new FrmInventario();
            this.Hide();
            inve.Show();
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
    }
}
