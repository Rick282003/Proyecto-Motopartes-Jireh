namespace Proyecto_Motopartes_Jireh
{
    partial class Ventas
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
            this.btnimprimir = new System.Windows.Forms.Button();
            this.lblidventa = new System.Windows.Forms.Label();
            this.lblverdetails = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxfiltro = new System.Windows.Forms.ComboBox();
            this.Btn_ExportarExcel = new System.Windows.Forms.Button();
            this.Btn_ExportarPDF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnimprimir
            // 
            this.btnimprimir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnimprimir.FlatAppearance.BorderSize = 0;
            this.btnimprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnimprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimir.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.ForeColor = System.Drawing.Color.White;
            this.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimir.Location = new System.Drawing.Point(627, 12);
            this.btnimprimir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnimprimir.Size = new System.Drawing.Size(117, 35);
            this.btnimprimir.TabIndex = 86;
            this.btnimprimir.Text = "  IMPRIMIR";
            this.btnimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnimprimir.UseVisualStyleBackColor = false;
            // 
            // lblidventa
            // 
            this.lblidventa.AutoSize = true;
            this.lblidventa.BackColor = System.Drawing.SystemColors.Control;
            this.lblidventa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidventa.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblidventa.Location = new System.Drawing.Point(829, 33);
            this.lblidventa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblidventa.Name = "lblidventa";
            this.lblidventa.Size = new System.Drawing.Size(19, 16);
            this.lblidventa.TabIndex = 85;
            this.lblidventa.Text = "ID";
            // 
            // lblverdetails
            // 
            this.lblverdetails.AutoSize = true;
            this.lblverdetails.BackColor = System.Drawing.SystemColors.Control;
            this.lblverdetails.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblverdetails.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblverdetails.Location = new System.Drawing.Point(829, 12);
            this.lblverdetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblverdetails.Name = "lblverdetails";
            this.lblverdetails.Size = new System.Drawing.Size(79, 16);
            this.lblverdetails.TabIndex = 84;
            this.lblverdetails.Text = "Ver detalles:";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtID.Location = new System.Drawing.Point(852, 28);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(97, 22);
            this.txtID.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(336, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 82;
            this.label1.Text = "Importar a:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(-89, 135);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 81;
            this.label10.Text = "Filtrar por:";
            // 
            // cbxfiltro
            // 
            this.cbxfiltro.BackColor = System.Drawing.Color.CadetBlue;
            this.cbxfiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxfiltro.ForeColor = System.Drawing.Color.White;
            this.cbxfiltro.FormattingEnabled = true;
            this.cbxfiltro.Location = new System.Drawing.Point(95, 38);
            this.cbxfiltro.Margin = new System.Windows.Forms.Padding(2);
            this.cbxfiltro.Name = "cbxfiltro";
            this.cbxfiltro.Size = new System.Drawing.Size(133, 23);
            this.cbxfiltro.TabIndex = 80;
            // 
            // Btn_ExportarExcel
            // 
            this.Btn_ExportarExcel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Btn_ExportarExcel.FlatAppearance.BorderSize = 0;
            this.Btn_ExportarExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_ExportarExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_ExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ExportarExcel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExportarExcel.ForeColor = System.Drawing.Color.White;
            this.Btn_ExportarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ExportarExcel.Location = new System.Drawing.Point(519, 12);
            this.Btn_ExportarExcel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn_ExportarExcel.Name = "Btn_ExportarExcel";
            this.Btn_ExportarExcel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Btn_ExportarExcel.Size = new System.Drawing.Size(104, 35);
            this.Btn_ExportarExcel.TabIndex = 79;
            this.Btn_ExportarExcel.Text = " EXCEL";
            this.Btn_ExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ExportarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ExportarExcel.UseVisualStyleBackColor = false;
            // 
            // Btn_ExportarPDF
            // 
            this.Btn_ExportarPDF.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Btn_ExportarPDF.FlatAppearance.BorderSize = 0;
            this.Btn_ExportarPDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_ExportarPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_ExportarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ExportarPDF.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExportarPDF.ForeColor = System.Drawing.Color.White;
            this.Btn_ExportarPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ExportarPDF.Location = new System.Drawing.Point(411, 12);
            this.Btn_ExportarPDF.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn_ExportarPDF.Name = "Btn_ExportarPDF";
            this.Btn_ExportarPDF.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Btn_ExportarPDF.Size = new System.Drawing.Size(104, 35);
            this.Btn_ExportarPDF.TabIndex = 78;
            this.Btn_ExportarPDF.Text = "   PDF";
            this.Btn_ExportarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ExportarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ExportarPDF.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(27, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 87;
            this.label2.Text = "Filtrar por:";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.lblidventa);
            this.Controls.Add(this.lblverdetails);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxfiltro);
            this.Controls.Add(this.Btn_ExportarExcel);
            this.Controls.Add(this.Btn_ExportarPDF);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Label lblidventa;
        private System.Windows.Forms.Label lblverdetails;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxfiltro;
        private System.Windows.Forms.Button Btn_ExportarExcel;
        private System.Windows.Forms.Button Btn_ExportarPDF;
        private System.Windows.Forms.Label label2;
    }
}