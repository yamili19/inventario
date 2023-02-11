namespace Para_inventario.Transacciones
{
    partial class mostrarPrestamosInformatica
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
            this.inventarioInformatica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informatica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealizadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtEncargado = new System.Windows.Forms.ToolStripTextBox();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnRegistrarDev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataPrestamos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPrestamos
            // 
            this.dataPrestamos.AllowUserToAddRows = false;
            this.dataPrestamos.AllowUserToDeleteRows = false;
            this.dataPrestamos.AllowUserToOrderColumns = true;
            this.dataPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventarioInformatica,
            this.informatica,
            this.cant,
            this.fechaPrestamo,
            this.fechaDevolucion,
            this.encargado,
            this.RealizadoPor});
            this.dataPrestamos.Location = new System.Drawing.Point(33, 46);
            this.dataPrestamos.Name = "dataPrestamos";
            this.dataPrestamos.ReadOnly = true;
            this.dataPrestamos.RowTemplate.Height = 25;
            this.dataPrestamos.Size = new System.Drawing.Size(814, 345);
            this.dataPrestamos.TabIndex = 24;
            this.dataPrestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPrestamos_CellClick);
            // 
            // inventarioInformatica
            // 
            this.inventarioInformatica.DataPropertyName = "inventarioInformatica";
            this.inventarioInformatica.HeaderText = "inventarioInformatica";
            this.inventarioInformatica.Name = "inventarioInformatica";
            this.inventarioInformatica.ReadOnly = true;
            this.inventarioInformatica.Visible = false;
            // 
            // informatica
            // 
            this.informatica.DataPropertyName = "informatica";
            this.informatica.HeaderText = "Informatica";
            this.informatica.Name = "informatica";
            this.informatica.ReadOnly = true;
            this.informatica.Width = 150;
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
            this.encargado.DataPropertyName = "solicitante";
            this.encargado.HeaderText = "Solicitante";
            this.encargado.Name = "encargado";
            this.encargado.ReadOnly = true;
            this.encargado.Width = 120;
            // 
            // RealizadoPor
            // 
            this.RealizadoPor.DataPropertyName = "responsable";
            this.RealizadoPor.HeaderText = "Responsable";
            this.RealizadoPor.Name = "RealizadoPor";
            this.RealizadoPor.ReadOnly = true;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Red;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(553, 397);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(95, 38);
            this.btnVolver.TabIndex = 69;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.txtEncargado,
            this.btnBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(873, 27);
            this.toolStrip1.TabIndex = 70;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(90, 24);
            this.toolStripLabel2.Text = "Solicitante: ";
            // 
            // txtEncargado
            // 
            this.txtEncargado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(100, 27);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Image = global::Para_inventario.Properties.Resources.pngtree_search_icon_creative_design_template_png_image_1998500;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 24);
            this.btnBuscar.Text = "toolStripButton1";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRegistrarDev
            // 
            this.btnRegistrarDev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRegistrarDev.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRegistrarDev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnRegistrarDev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnRegistrarDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarDev.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarDev.Location = new System.Drawing.Point(663, 397);
            this.btnRegistrarDev.Name = "btnRegistrarDev";
            this.btnRegistrarDev.Size = new System.Drawing.Size(184, 38);
            this.btnRegistrarDev.TabIndex = 71;
            this.btnRegistrarDev.Text = "Registrar Devolución";
            this.btnRegistrarDev.UseVisualStyleBackColor = false;
            this.btnRegistrarDev.Click += new System.EventHandler(this.btnRegistrarDev_Click);
            // 
            // mostrarPrestamosInformatica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.btnRegistrarDev);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dataPrestamos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mostrarPrestamosInformatica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mostrarPrestamosInformatica";
            this.Load += new System.EventHandler(this.mostrarPrestamosInformatica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPrestamos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataPrestamos;
        private Button btnVolver;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripTextBox txtEncargado;
        private ToolStripButton btnBuscar;
        private Button btnRegistrarDev;
        private DataGridViewTextBoxColumn inventarioInformatica;
        private DataGridViewTextBoxColumn informatica;
        private DataGridViewTextBoxColumn cant;
        private DataGridViewTextBoxColumn fechaPrestamo;
        private DataGridViewTextBoxColumn fechaDevolucion;
        private DataGridViewTextBoxColumn encargado;
        private DataGridViewTextBoxColumn RealizadoPor;
    }
}