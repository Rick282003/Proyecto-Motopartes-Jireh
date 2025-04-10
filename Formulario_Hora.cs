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
    public partial class Formulario_Hora : Form
    {
        public Formulario_Hora(string user)
        {
            InitializeComponent();
            txtBienvenido.Text = "BIENVENIDO " + user.ToUpper();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss"); // Formato de 24 horas
            lblFecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy"); // Fecha completa
        }

    }
}
