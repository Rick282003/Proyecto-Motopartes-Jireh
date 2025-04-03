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
    public partial class FrmVentas : Form
    {
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private TextBox txtIDVenta;
        private Label label3;
        private TextBox txtIDEmpleado;
        private Label label4;
        private TextBox txtRTNCliente;
        private Label label5;
        private TextBox txtDireccionCliente;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtObservaciones;
        private TextBox txtIDProducto;
        private Label label9;
        private TextBox txtNombreProducto;
        private Label label10;
        private TextBox txtPrecio;
        private Label label11;
        private TextBox txtCantidad;
        private Label label12;
        private TextBox txtIVA;
        private Label label13;
        private TextBox txtDescuento;
        private Label label14;
        private Label lblTotal;
        private Label label;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtNombreCliente;
        private Label label16;
        private TextBox txtApellidoCliente;
        private Label label17;
        private Label label18;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtCorreoCliente;
        private Label label19;
        private DataGridView dgvProductos;
        private PictureBox pbProducto;
        private TextBox txtMetodoPago;
        private Label label15;
        private Label label20;
        private PictureBox pictureBox4;

        public FrmVentas()
        {
            InitializeComponent();
        }

        clsConexion conexion = new clsConexion();
        clsAccion acciones = new clsAccion();
        SqlCommand cmd;

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDVenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRTNCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtIDProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.pbProducto = new System.Windows.Forms.PictureBox();
            this.txtMetodoPago = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 34);
            this.label1.TabIndex = 49;
            this.label1.Text = "Gestión de Venta (Encabezado)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(839, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 34);
            this.label2.TabIndex = 50;
            this.label2.Text = "Gestión de Venta (Detalle)";
            // 
            // txtIDVenta
            // 
            this.txtIDVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDVenta.Location = new System.Drawing.Point(389, 137);
            this.txtIDVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDVenta.Name = "txtIDVenta";
            this.txtIDVenta.Size = new System.Drawing.Size(301, 27);
            this.txtIDVenta.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(148, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "ID de la Venta:";
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDEmpleado.Location = new System.Drawing.Point(389, 208);
            this.txtIDEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.ReadOnly = true;
            this.txtIDEmpleado.Size = new System.Drawing.Size(301, 27);
            this.txtIDEmpleado.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(148, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 19);
            this.label4.TabIndex = 53;
            this.label4.Text = "ID del Empleado:";
            // 
            // txtRTNCliente
            // 
            this.txtRTNCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRTNCliente.Location = new System.Drawing.Point(389, 275);
            this.txtRTNCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRTNCliente.Name = "txtRTNCliente";
            this.txtRTNCliente.Size = new System.Drawing.Size(301, 27);
            this.txtRTNCliente.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(148, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "RTN del Cliente:";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCliente.Location = new System.Drawing.Point(389, 488);
            this.txtDireccionCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(301, 27);
            this.txtDireccionCliente.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(148, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 19);
            this.label6.TabIndex = 57;
            this.label6.Text = "Dirección del Cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(148, 557);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 19);
            this.label7.TabIndex = 59;
            this.label7.Text = "Metodo de Pago:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(148, 617);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 19);
            this.label8.TabIndex = 62;
            this.label8.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(389, 614);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(301, 116);
            this.txtObservaciones.TabIndex = 63;
            // 
            // txtIDProducto
            // 
            this.txtIDProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDProducto.Location = new System.Drawing.Point(1095, 162);
            this.txtIDProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDProducto.Name = "txtIDProducto";
            this.txtIDProducto.ReadOnly = true;
            this.txtIDProducto.Size = new System.Drawing.Size(301, 27);
            this.txtIDProducto.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(855, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 19);
            this.label9.TabIndex = 64;
            this.label9.Text = "ID del Producto:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(1095, 230);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProducto.Size = new System.Drawing.Size(301, 27);
            this.txtNombreProducto.TabIndex = 67;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(855, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 19);
            this.label10.TabIndex = 66;
            this.label10.Text = "Nombre del Producto:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(1095, 367);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(301, 27);
            this.txtPrecio.TabIndex = 71;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(855, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 19);
            this.label11.TabIndex = 70;
            this.label11.Text = "Precio:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(1095, 300);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(301, 27);
            this.txtCantidad.TabIndex = 69;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(855, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 19);
            this.label12.TabIndex = 68;
            this.label12.Text = "Cantidad:";
            // 
            // txtIVA
            // 
            this.txtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIVA.Location = new System.Drawing.Point(1095, 502);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(301, 27);
            this.txtIVA.TabIndex = 75;
            this.txtIVA.TextChanged += new System.EventHandler(this.txtIVA_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(855, 502);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 19);
            this.label13.TabIndex = 74;
            this.label13.Text = "IVA:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(1095, 434);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(301, 27);
            this.txtDescuento.TabIndex = 73;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(855, 434);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 19);
            this.label14.TabIndex = 72;
            this.label14.Text = "Descuento:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(1271, 580);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(14, 19);
            this.lblTotal.TabIndex = 78;
            this.lblTotal.Text = ".";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(855, 580);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(51, 19);
            this.label.TabIndex = 76;
            this.label.Text = "Total:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.btnGuardar.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(700, 780);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(147, 46);
            this.btnGuardar.TabIndex = 81;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(1015, 780);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 46);
            this.btnCancelar.TabIndex = 80;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox4.Location = new System.Drawing.Point(596, 761);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(717, 92);
            this.pictureBox4.TabIndex = 79;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.pictureBox2.Location = new System.Drawing.Point(817, 46);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(657, 601);
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.pictureBox1.Location = new System.Drawing.Point(129, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 711);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(153, 371);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(169, 27);
            this.txtNombreCliente.TabIndex = 83;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(148, 334);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(174, 19);
            this.label16.TabIndex = 82;
            this.label16.Text = "Nombre del Cliente:";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoCliente.Location = new System.Drawing.Point(343, 371);
            this.txtApellidoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(169, 27);
            this.txtApellidoCliente.TabIndex = 85;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(338, 334);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(176, 19);
            this.label17.TabIndex = 84;
            this.label17.Text = "Apellido del Cliente:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(530, 334);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(192, 19);
            this.label18.TabIndex = 86;
            this.label18.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(534, 375);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(252, 22);
            this.dtpFechaNacimiento.TabIndex = 87;
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoCliente.Location = new System.Drawing.Point(389, 434);
            this.txtCorreoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.Size = new System.Drawing.Size(301, 27);
            this.txtCorreoCliente.TabIndex = 89;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(148, 434);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(166, 19);
            this.label19.TabIndex = 88;
            this.label19.Text = "Correo Electronico:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(1480, 46);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(428, 239);
            this.dgvProductos.TabIndex = 90;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // pbProducto
            // 
            this.pbProducto.Location = new System.Drawing.Point(1480, 300);
            this.pbProducto.Name = "pbProducto";
            this.pbProducto.Size = new System.Drawing.Size(428, 261);
            this.pbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProducto.TabIndex = 91;
            this.pbProducto.TabStop = false;
            // 
            // txtMetodoPago
            // 
            this.txtMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetodoPago.Location = new System.Drawing.Point(389, 549);
            this.txtMetodoPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMetodoPago.Name = "txtMetodoPago";
            this.txtMetodoPago.Size = new System.Drawing.Size(301, 27);
            this.txtMetodoPago.TabIndex = 92;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(1402, 442);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 19);
            this.label15.TabIndex = 93;
            this.label15.Text = "%";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.Control;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(1402, 505);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 19);
            this.label20.TabIndex = 94;
            this.label20.Text = "%";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1920, 919);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtMetodoPago);
            this.Controls.Add(this.pbProducto);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtCorreoCliente);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIDProducto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDireccionCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRTNCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIDEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIDVenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmVentas";
            this.Text = "Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            FrmCompras comp = new FrmCompras();
            this.Hide();
            comp.Show();
        }


        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuarios user = new FrmUsuarios();
            this.Hide();
            user.Show();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            conexion.Abrir();
            acciones.CargarDatos(dgvProductos, "Productos");
            txtIDEmpleado.Text = UsuarioActual.IDEmpleado.ToString();
            lblTotal.Text = "0.00";
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

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];

                txtIDProducto.Text = row.Cells["IDProducto"].Value.ToString();
                txtNombreProducto.Text = row.Cells["NombreProducto"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();

                // Cargar la imagen del producto
                if (row.Cells["Imagen"].Value != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row.Cells["Imagen"].Value;
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pbProducto.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pbProducto.Image = null;
                }
            }
        }

        private void CalcularTotal()
        {
            // Verificar que todos los campos necesarios tengan valores válidos
            if (decimal.TryParse(txtCantidad.Text, out decimal cantidad) &&
                decimal.TryParse(txtPrecio.Text, out decimal precio) &&
                decimal.TryParse(txtDescuento.Text, out decimal descuento) &&
                decimal.TryParse(txtIVA.Text, out decimal iva))
            {
                // Calcular subtotal (cantidad * precio)
                decimal subtotal = cantidad * precio;

                // Calcular el descuento
                decimal montoDescuento = subtotal * (descuento / 100);

                // Calcular el IVA
                decimal montoIVA = (subtotal - montoDescuento) * (iva / 100);

                // Calcular total final
                decimal total = (subtotal - montoDescuento) + montoIVA;

                // Mostrar el total en el Label
                lblTotal.Text = total.ToString("C2"); // Formato moneda
            }
            else
            {
                lblTotal.Text = "0.00";
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
             try
             {
                 // Verificar que los campos necesarios tengan valores
                 if (string.IsNullOrEmpty(txtIDVenta.Text) ||
                     string.IsNullOrEmpty(txtIDEmpleado.Text) ||
                     string.IsNullOrEmpty(txtIDProducto.Text) ||
                     string.IsNullOrEmpty(txtRTNCliente.Text) ||
                     string.IsNullOrEmpty(txtMetodoPago.Text) ||
                     string.IsNullOrEmpty(lblTotal.Text))
                 {
                     MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     return;
                 }

                 string idCliente = txtRTNCliente.Text;

                 // Verificar si el RTN del cliente existe en la tabla RegistroClientes
                 string queryVerificarCliente = "SELECT COUNT(*) FROM RegistroClientes WHERE RTN = @RTN";
                 SqlCommand cmdVerificarCliente = new SqlCommand(queryVerificarCliente, conexion.SC);
                 cmdVerificarCliente.Parameters.AddWithValue("@RTN", idCliente);

                 conexion.Abrir();
                 int clienteExistente = (int)cmdVerificarCliente.ExecuteScalar();

                 if (clienteExistente == 0)
                 {
                     // Si el cliente no existe, agregarlo a la tabla RegistroClientes
                     string queryInsertarCliente = "INSERT INTO RegistroClientes (RTN, Nombre, Apellido, FechaNacimiento, CorreoElectronico, Direccion) " +
                                                   "VALUES (@RTN, @Nombre, @Apellido, @FechaNacimiento, @CorreoElectronico, @Direccion)";
                     SqlCommand cmdInsertarCliente = new SqlCommand(queryInsertarCliente, conexion.SC);

                     cmdInsertarCliente.Parameters.AddWithValue("@RTN", idCliente);
                     cmdInsertarCliente.Parameters.AddWithValue("@Nombre", txtNombreCliente.Text);  // Suponiendo que tienes un campo para nombre del cliente
                     cmdInsertarCliente.Parameters.AddWithValue("@Apellido", txtApellidoCliente.Text); // Suponiendo que tienes un campo para apellido
                     cmdInsertarCliente.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value); // Fecha de nacimiento
                     cmdInsertarCliente.Parameters.AddWithValue("@CorreoElectronico", txtCorreoCliente.Text); // Correo del cliente
                     cmdInsertarCliente.Parameters.AddWithValue("@Direccion", txtDireccionCliente.Text); // Dirección del cliente

                     cmdInsertarCliente.ExecuteNonQuery();
                     MessageBox.Show("Cliente registrado con éxito.", "Cliente Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }

                 // Convertir valores
                 int idVenta = int.Parse(txtIDVenta.Text);  // IDVenta lo ingresa el usuario
                 int idEmpleado = int.Parse(txtIDEmpleado.Text);
                 int idProducto = int.Parse(txtIDProducto.Text);
                 int metodoPago = int.Parse(txtMetodoPago.Text);
                 DateTime fechaVenta = DateTime.Now; // Fecha actual
                 decimal totalPagar = decimal.Parse(lblTotal.Text, System.Globalization.NumberStyles.Currency); // Formato moneda

                 // Insertar en RegistroVentaEncabezado
                 string queryEncabezado = "INSERT INTO RegistroVentaEncabezado (IDVenta, IDEmpleado, IDProducto, IDCliente, MetodoPago, FechaVenta, TotalPagar, Observaciones) " +
                                          "VALUES (@IDVenta, @IDEmpleado, @IDProducto, @IDCliente, @MetodoPago, @FechaVenta, @TotalPagar, @Observaciones)" +
                          "SELECT SCOPE_IDENTITY();";

                 SqlCommand cmdEncabezado = new SqlCommand(queryEncabezado, conexion.SC);
                 cmdEncabezado.Parameters.AddWithValue("@IDVenta", idVenta);
                 cmdEncabezado.Parameters.AddWithValue("@IDEmpleado", idEmpleado);
                 cmdEncabezado.Parameters.AddWithValue("@IDProducto", idProducto);
                 cmdEncabezado.Parameters.AddWithValue("@IDCliente", idCliente);
                 cmdEncabezado.Parameters.AddWithValue("@MetodoPago", metodoPago);
                 cmdEncabezado.Parameters.AddWithValue("@FechaVenta", fechaVenta);
                 cmdEncabezado.Parameters.AddWithValue("@TotalPagar", totalPagar);
                 cmdEncabezado.Parameters.AddWithValue("@Observaciones", txtObservaciones.Text);
                
                 cmdEncabezado.ExecuteNonQuery();



                 int cantidad = int.Parse(txtCantidad.Text);
                 decimal precioUnitario = decimal.Parse(txtPrecio.Text);
                 decimal descuento = decimal.Parse(txtDescuento.Text);
                 decimal iva = decimal.Parse(txtIVA.Text);


                 // Insertar en RegistroVentaDetalle

                 string queryDetalle = "INSERT INTO RegistroVentaDetalle (IDDetalle, IDVenta, Cantidad, PrecioUnitario, Descuento, IVA, Subtotal, Observaciones) " +
                           "VALUES (@IDDetalle, @IDVenta, @Cantidad, @PrecioUnitario, @Descuento, @IVA, @Subtotal, @Observaciones)";

                 SqlCommand cmdDetalle = new SqlCommand(queryDetalle, conexion.SC);

                 cmdDetalle.Parameters.AddWithValue("@IDDetalle", idVenta);
                 cmdDetalle.Parameters.AddWithValue("@IDVenta", idVenta);
                 cmdDetalle.Parameters.AddWithValue("@Cantidad", cantidad);
                 cmdDetalle.Parameters.AddWithValue("@PrecioUnitario", precioUnitario);
                 cmdDetalle.Parameters.AddWithValue("@Descuento", descuento);
                 cmdDetalle.Parameters.AddWithValue("@IVA", iva);
                 cmdDetalle.Parameters.AddWithValue("@Subtotal", totalPagar);
                 cmdDetalle.Parameters.AddWithValue("@Observaciones", txtObservaciones.Text);

                 cmdDetalle.ExecuteNonQuery();




                 // Actualizar stock en la tabla Productos
                 string queryStock = "SELECT Cantidad FROM Productos WHERE IDProducto = @IDProducto";
                 SqlCommand cmdStock = new SqlCommand(queryStock, conexion.SC);
                 cmdStock.Parameters.AddWithValue("@IDProducto", idProducto);

                 int stockActual = Convert.ToInt32(cmdStock.ExecuteScalar());
                 if (stockActual < cantidad)
                 {
                     MessageBox.Show("No hay suficiente stock disponible.", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     return;
                 }

                 string queryActualizarStock = "UPDATE Productos SET Cantidad = Cantidad - @Cantidad WHERE IDProducto = @IDProducto";
                 SqlCommand cmdActualizarStock = new SqlCommand(queryActualizarStock, conexion.SC);
                 cmdActualizarStock.Parameters.AddWithValue("@Cantidad", cantidad);
                 cmdActualizarStock.Parameters.AddWithValue("@IDProducto", idProducto);
                 cmdActualizarStock.ExecuteNonQuery();


                 MessageBox.Show("Venta guardada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtIDVenta.Clear();
                txtIDEmpleado.Clear();
                txtIDProducto.Clear();
                txtNombreProducto.Clear();
                txtRTNCliente.Clear();
                txtMetodoPago.Clear();
                txtNombreCliente.Clear();
                txtApellidoCliente.Clear();
                txtCorreoCliente.Clear();
                txtDireccionCliente.Clear();
                pbProducto.Image = null;
                txtObservaciones.Clear();
                txtCantidad.Clear();
                txtPrecio.Clear();
                txtDescuento.Clear();
                txtIVA.Clear();
                lblTotal.Text = "0.00"; // Restablecer el total a 0 o su valor predeterminado
                dtpFechaNacimiento.Value = DateTime.Now; // Resetear fecha al día actual

                acciones.CargarDatos(dgvProductos, "Productos");

            }
             catch (FormatException ex)
             {
                 MessageBox.Show("Error en formato de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Ocurrió un error al guardar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }


            


        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void txtIVA_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIDVenta.Clear();
            txtIDEmpleado.Clear();
            txtIDProducto.Clear();
            txtRTNCliente.Clear();
            txtMetodoPago.Clear();
            txtNombreCliente.Clear();
            txtApellidoCliente.Clear();
            txtCorreoCliente.Clear();
            txtDireccionCliente.Clear();
            txtObservaciones.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtDescuento.Clear();
            txtIVA.Clear();
            lblTotal.Text = "0.00"; // Restablecer el total a 0 o su valor predeterminado
            dtpFechaNacimiento.Value = DateTime.Now; // Resetear fecha al día actual
        }
    }
}
