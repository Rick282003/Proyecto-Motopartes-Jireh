﻿using System;
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
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
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
    }
}
