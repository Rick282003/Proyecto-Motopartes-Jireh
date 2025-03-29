namespace Proyecto_Motopartes_Jireh
{
    partial class FrmCierreCaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dvgData = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gastos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetiroCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbCierreCaja = new System.Windows.Forms.GroupBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtRetiroCaja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaldoFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGastos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaCierre = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtTotalVentas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSaldoInicial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgData)).BeginInit();
            this.grbCierreCaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgData
            // 
            this.dvgData.AllowUserToAddRows = false;
            this.dvgData.AllowUserToDeleteRows = false;
            this.dvgData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dvgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Hora,
            this.SaldoInicial,
            this.TotalVentas,
            this.Gastos,
            this.SaldoFinal,
            this.RetiroCaja});
            this.dvgData.Location = new System.Drawing.Point(336, 32);
            this.dvgData.Margin = new System.Windows.Forms.Padding(2);
            this.dvgData.Name = "dvgData";
            this.dvgData.RowHeadersWidth = 62;
            this.dvgData.RowTemplate.Height = 24;
            this.dvgData.Size = new System.Drawing.Size(1093, 739);
            this.dvgData.TabIndex = 44;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 8;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 200;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 8;
            this.Hora.Name = "Hora";
            this.Hora.Width = 200;
            // 
            // SaldoInicial
            // 
            this.SaldoInicial.HeaderText = "Saldo Inicial";
            this.SaldoInicial.MinimumWidth = 8;
            this.SaldoInicial.Name = "SaldoInicial";
            this.SaldoInicial.Width = 200;
            // 
            // TotalVentas
            // 
            this.TotalVentas.HeaderText = "Total de Ventas en Efectivo";
            this.TotalVentas.MinimumWidth = 8;
            this.TotalVentas.Name = "TotalVentas";
            this.TotalVentas.Width = 150;
            // 
            // Gastos
            // 
            this.Gastos.HeaderText = "Gastos";
            this.Gastos.MinimumWidth = 8;
            this.Gastos.Name = "Gastos";
            this.Gastos.Width = 200;
            // 
            // SaldoFinal
            // 
            this.SaldoFinal.HeaderText = "Saldo Final";
            this.SaldoFinal.MinimumWidth = 8;
            this.SaldoFinal.Name = "SaldoFinal";
            this.SaldoFinal.Width = 150;
            // 
            // RetiroCaja
            // 
            this.RetiroCaja.HeaderText = "Retiro de Caja";
            this.RetiroCaja.MinimumWidth = 8;
            this.RetiroCaja.Name = "RetiroCaja";
            this.RetiroCaja.Width = 200;
            // 
            // grbCierreCaja
            // 
            this.grbCierreCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.grbCierreCaja.Controls.Add(this.btnGenerarReporte);
            this.grbCierreCaja.Controls.Add(this.btnLimpiar);
            this.grbCierreCaja.Controls.Add(this.txtRetiroCaja);
            this.grbCierreCaja.Controls.Add(this.label2);
            this.grbCierreCaja.Controls.Add(this.txtSaldoFinal);
            this.grbCierreCaja.Controls.Add(this.label3);
            this.grbCierreCaja.Controls.Add(this.txtGastos);
            this.grbCierreCaja.Controls.Add(this.label1);
            this.grbCierreCaja.Controls.Add(this.dtpFechaCierre);
            this.grbCierreCaja.Controls.Add(this.btnGuardar);
            this.grbCierreCaja.Controls.Add(this.textBox1);
            this.grbCierreCaja.Controls.Add(this.btnEliminar);
            this.grbCierreCaja.Controls.Add(this.btnEditar);
            this.grbCierreCaja.Controls.Add(this.btnBuscar);
            this.grbCierreCaja.Controls.Add(this.txtTotalVentas);
            this.grbCierreCaja.Controls.Add(this.label5);
            this.grbCierreCaja.Controls.Add(this.txtSaldoInicial);
            this.grbCierreCaja.Controls.Add(this.label6);
            this.grbCierreCaja.Controls.Add(this.txtHora);
            this.grbCierreCaja.Controls.Add(this.label7);
            this.grbCierreCaja.Controls.Add(this.label8);
            this.grbCierreCaja.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCierreCaja.ForeColor = System.Drawing.Color.White;
            this.grbCierreCaja.Location = new System.Drawing.Point(4, 32);
            this.grbCierreCaja.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grbCierreCaja.Name = "grbCierreCaja";
            this.grbCierreCaja.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.grbCierreCaja.Size = new System.Drawing.Size(308, 592);
            this.grbCierreCaja.TabIndex = 54;
            this.grbCierreCaja.TabStop = false;
            this.grbCierreCaja.Text = "Cierre de Caja";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(203)))));
            this.btnGenerarReporte.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.Location = new System.Drawing.Point(80, 531);
            this.btnGenerarReporte.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(143, 31);
            this.btnGenerarReporte.TabIndex = 22;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(203)))));
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(227, 531);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(70, 31);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // txtRetiroCaja
            // 
            this.txtRetiroCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.txtRetiroCaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRetiroCaja.ForeColor = System.Drawing.Color.White;
            this.txtRetiroCaja.Location = new System.Drawing.Point(9, 413);
            this.txtRetiroCaja.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtRetiroCaja.Name = "txtRetiroCaja";
            this.txtRetiroCaja.Size = new System.Drawing.Size(282, 26);
            this.txtRetiroCaja.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 392);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Retiro de Caja";
            // 
            // txtSaldoFinal
            // 
            this.txtSaldoFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.txtSaldoFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldoFinal.ForeColor = System.Drawing.Color.White;
            this.txtSaldoFinal.Location = new System.Drawing.Point(9, 352);
            this.txtSaldoFinal.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtSaldoFinal.Name = "txtSaldoFinal";
            this.txtSaldoFinal.Size = new System.Drawing.Size(282, 26);
            this.txtSaldoFinal.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 331);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Saldo Final";
            // 
            // txtGastos
            // 
            this.txtGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.txtGastos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGastos.ForeColor = System.Drawing.Color.White;
            this.txtGastos.Location = new System.Drawing.Point(9, 285);
            this.txtGastos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtGastos.Name = "txtGastos";
            this.txtGastos.Size = new System.Drawing.Size(282, 26);
            this.txtGastos.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 264);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Gastos";
            // 
            // dtpFechaCierre
            // 
            this.dtpFechaCierre.Location = new System.Drawing.Point(9, 58);
            this.dtpFechaCierre.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaCierre.Name = "dtpFechaCierre";
            this.dtpFechaCierre.Size = new System.Drawing.Size(277, 26);
            this.dtpFechaCierre.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(203)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(80, 486);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 31);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 26);
            this.textBox1.TabIndex = 12;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(203)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(227, 486);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 31);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(203)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(154, 486);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(70, 31);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(203)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(5, 486);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(70, 31);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtTotalVentas
            // 
            this.txtTotalVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.txtTotalVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalVentas.ForeColor = System.Drawing.Color.White;
            this.txtTotalVentas.Location = new System.Drawing.Point(9, 224);
            this.txtTotalVentas.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtTotalVentas.Name = "txtTotalVentas";
            this.txtTotalVentas.Size = new System.Drawing.Size(282, 26);
            this.txtTotalVentas.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total de Ventas";
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.txtSaldoInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldoInicial.ForeColor = System.Drawing.Color.White;
            this.txtSaldoInicial.Location = new System.Drawing.Point(9, 168);
            this.txtSaldoInicial.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.Size = new System.Drawing.Size(282, 26);
            this.txtSaldoInicial.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Saldo Inicial";
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(170)))));
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHora.ForeColor = System.Drawing.Color.White;
            this.txtHora.Location = new System.Drawing.Point(9, 113);
            this.txtHora.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(282, 26);
            this.txtHora.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Hora";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Fecha de Cierre";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // FrmCierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1440, 747);
            this.Controls.Add(this.grbCierreCaja);
            this.Controls.Add(this.dvgData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCierreCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cierre de Caaja";
            ((System.ComponentModel.ISupportInitialize)(this.dvgData)).EndInit();
            this.grbCierreCaja.ResumeLayout(false);
            this.grbCierreCaja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dvgData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gastos;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetiroCaja;
        private System.Windows.Forms.GroupBox grbCierreCaja;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtTotalVentas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSaldoInicial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaCierre;
        private System.Windows.Forms.TextBox txtRetiroCaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaldoFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGastos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnLimpiar;
    }
}