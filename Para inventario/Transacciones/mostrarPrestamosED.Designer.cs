﻿namespace Para_inventario.Transacciones
{
    partial class mostrarPrestamosED
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
            this.dataPrestamos = new System.Windows.Forms.DataGridView();
            this.inventarioElementosDibujo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementosDibujo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrarDev = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPrestamos
            // 
            this.dataPrestamos.AllowUserToAddRows = false;
            this.dataPrestamos.AllowUserToDeleteRows = false;
            this.dataPrestamos.AllowUserToOrderColumns = true;
            this.dataPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventarioElementosDibujo,
            this.elementosDibujo,
            this.cant,
            this.fechaPrestamo,
            this.fechaDevolucion,
            this.encargado});
            this.dataPrestamos.Location = new System.Drawing.Point(45, 27);
            this.dataPrestamos.Name = "dataPrestamos";
            this.dataPrestamos.ReadOnly = true;
            this.dataPrestamos.RowTemplate.Height = 25;
            this.dataPrestamos.Size = new System.Drawing.Size(714, 345);
            this.dataPrestamos.TabIndex = 23;
            this.dataPrestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPrestamos_CellClick);
            // 
            // inventarioElementosDibujo
            // 
            this.inventarioElementosDibujo.DataPropertyName = "inventarioElementosDibujo";
            this.inventarioElementosDibujo.HeaderText = "inventarioElementosDibujo";
            this.inventarioElementosDibujo.Name = "inventarioElementosDibujo";
            this.inventarioElementosDibujo.ReadOnly = true;
            this.inventarioElementosDibujo.Visible = false;
            // 
            // elementosDibujo
            // 
            this.elementosDibujo.DataPropertyName = "elementosDibujo";
            this.elementosDibujo.HeaderText = "Elemento de Dibujo";
            this.elementosDibujo.Name = "elementosDibujo";
            this.elementosDibujo.ReadOnly = true;
            this.elementosDibujo.Width = 150;
            // 
            // cant
            // 
            this.cant.DataPropertyName = "cantidad";
            this.cant.HeaderText = "Cantidad";
            this.cant.Name = "cant";
            this.cant.ReadOnly = true;
            // 
            // fechaPrestamo
            // 
            this.fechaPrestamo.DataPropertyName = "fechaPrestamo";
            this.fechaPrestamo.HeaderText = "Fecha Prestamo";
            this.fechaPrestamo.Name = "fechaPrestamo";
            this.fechaPrestamo.ReadOnly = true;
            this.fechaPrestamo.Width = 150;
            // 
            // fechaDevolucion
            // 
            this.fechaDevolucion.DataPropertyName = "fechaDevolucion";
            this.fechaDevolucion.HeaderText = "Fecha Devolucion";
            this.fechaDevolucion.Name = "fechaDevolucion";
            this.fechaDevolucion.ReadOnly = true;
            this.fechaDevolucion.Width = 150;
            // 
            // encargado
            // 
            this.encargado.DataPropertyName = "encargado";
            this.encargado.HeaderText = "Encargado";
            this.encargado.Name = "encargado";
            this.encargado.ReadOnly = true;
            this.encargado.Width = 120;
            // 
            // btnRegistrarDev
            // 
            this.btnRegistrarDev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRegistrarDev.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRegistrarDev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnRegistrarDev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnRegistrarDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarDev.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarDev.Location = new System.Drawing.Point(575, 389);
            this.btnRegistrarDev.Name = "btnRegistrarDev";
            this.btnRegistrarDev.Size = new System.Drawing.Size(184, 38);
            this.btnRegistrarDev.TabIndex = 36;
            this.btnRegistrarDev.Text = "Registrar Devolución";
            this.btnRegistrarDev.UseVisualStyleBackColor = false;
            this.btnRegistrarDev.Click += new System.EventHandler(this.btnRegistrarDev_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Red;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(463, 389);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(95, 38);
            this.btnVolver.TabIndex = 35;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // mostrarPrestamosED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrarDev);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dataPrestamos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mostrarPrestamosED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mostrarPrestamosED";
            this.Load += new System.EventHandler(this.mostrarPrestamosED_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPrestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataPrestamos;
        private DataGridViewTextBoxColumn inventarioElementosDibujo;
        private DataGridViewTextBoxColumn elementosDibujo;
        private DataGridViewTextBoxColumn cant;
        private DataGridViewTextBoxColumn fechaPrestamo;
        private DataGridViewTextBoxColumn fechaDevolucion;
        private DataGridViewTextBoxColumn encargado;
        private Button btnRegistrarDev;
        private Button btnVolver;
    }
}