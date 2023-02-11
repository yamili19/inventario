namespace Para_inventario.Transacciones
{
    partial class prestamosInformatica
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
            this.lblUser = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.maskCantidad = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboInformatica = new System.Windows.Forms.ComboBox();
            this.dataPrestamos = new System.Windows.Forms.DataGridView();
            this.inventarioInformatica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostrarPrestamos = new System.Windows.Forms.Button();
            this.btnRegistrarPrestamos = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dataInformaticaEliminar = new System.Windows.Forms.DataGridView();
            this.nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInformaticaEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUser.Location = new System.Drawing.Point(578, 28);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(57, 20);
            this.lblUser.TabIndex = 66;
            this.lblUser.Text = "asdasd";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(647, 66);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(67, 30);
            this.btnEliminar.TabIndex = 65;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(275, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Solicitante: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(371, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(201, 23);
            this.txtNombre.TabIndex = 63;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(578, 66);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(63, 30);
            this.btnAgregar.TabIndex = 62;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // maskCantidad
            // 
            this.maskCantidad.Location = new System.Drawing.Point(170, 71);
            this.maskCantidad.Mask = "99999";
            this.maskCantidad.Name = "maskCantidad";
            this.maskCantidad.Size = new System.Drawing.Size(100, 23);
            this.maskCantidad.TabIndex = 61;
            this.maskCantidad.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(85, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Cantidad: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Informática: ";
            // 
            // comboInformatica
            // 
            this.comboInformatica.FormattingEnabled = true;
            this.comboInformatica.Location = new System.Drawing.Point(170, 40);
            this.comboInformatica.Name = "comboInformatica";
            this.comboInformatica.Size = new System.Drawing.Size(172, 23);
            this.comboInformatica.TabIndex = 58;
            // 
            // dataPrestamos
            // 
            this.dataPrestamos.AllowUserToAddRows = false;
            this.dataPrestamos.AllowUserToDeleteRows = false;
            this.dataPrestamos.AllowUserToOrderColumns = true;
            this.dataPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventarioInformatica,
            this.inform,
            this.cant,
            this.fechaPrestamo,
            this.fechaDevolucion,
            this.encargado});
            this.dataPrestamos.Location = new System.Drawing.Point(45, 102);
            this.dataPrestamos.Name = "dataPrestamos";
            this.dataPrestamos.ReadOnly = true;
            this.dataPrestamos.RowTemplate.Height = 25;
            this.dataPrestamos.Size = new System.Drawing.Size(714, 269);
            this.dataPrestamos.TabIndex = 67;
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
            // inform
            // 
            this.inform.DataPropertyName = "informatica";
            this.inform.HeaderText = "Informática";
            this.inform.Name = "inform";
            this.inform.ReadOnly = true;
            this.inform.Width = 150;
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
            // btnMostrarPrestamos
            // 
            this.btnMostrarPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMostrarPrestamos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMostrarPrestamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnMostrarPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMostrarPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarPrestamos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarPrestamos.Location = new System.Drawing.Point(310, 387);
            this.btnMostrarPrestamos.Name = "btnMostrarPrestamos";
            this.btnMostrarPrestamos.Size = new System.Drawing.Size(167, 38);
            this.btnMostrarPrestamos.TabIndex = 70;
            this.btnMostrarPrestamos.Text = "Mostrar Prestamos";
            this.btnMostrarPrestamos.UseVisualStyleBackColor = false;
            this.btnMostrarPrestamos.Click += new System.EventHandler(this.btnMostrarPrestamos_Click);
            // 
            // btnRegistrarPrestamos
            // 
            this.btnRegistrarPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRegistrarPrestamos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRegistrarPrestamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnRegistrarPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnRegistrarPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPrestamos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarPrestamos.Location = new System.Drawing.Point(584, 387);
            this.btnRegistrarPrestamos.Name = "btnRegistrarPrestamos";
            this.btnRegistrarPrestamos.Size = new System.Drawing.Size(175, 38);
            this.btnRegistrarPrestamos.TabIndex = 69;
            this.btnRegistrarPrestamos.Text = "Registrar Prestamos";
            this.btnRegistrarPrestamos.UseVisualStyleBackColor = false;
            this.btnRegistrarPrestamos.Click += new System.EventHandler(this.btnRegistrarPrestamos_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Red;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(483, 387);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(95, 38);
            this.btnVolver.TabIndex = 68;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dataInformaticaEliminar
            // 
            this.dataInformaticaEliminar.AllowUserToAddRows = false;
            this.dataInformaticaEliminar.AllowUserToDeleteRows = false;
            this.dataInformaticaEliminar.AllowUserToOrderColumns = true;
            this.dataInformaticaEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInformaticaEliminar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nro,
            this.nombre,
            this.marca,
            this.lugar,
            this.cantidad});
            this.dataInformaticaEliminar.Location = new System.Drawing.Point(22, 339);
            this.dataInformaticaEliminar.Name = "dataInformaticaEliminar";
            this.dataInformaticaEliminar.ReadOnly = true;
            this.dataInformaticaEliminar.RowTemplate.Height = 25;
            this.dataInformaticaEliminar.Size = new System.Drawing.Size(95, 86);
            this.dataInformaticaEliminar.TabIndex = 71;
            this.dataInformaticaEliminar.Visible = false;
            // 
            // nro
            // 
            this.nro.DataPropertyName = "nro";
            this.nro.HeaderText = "Nro Inventario";
            this.nro.Name = "nro";
            this.nro.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // lugar
            // 
            this.lugar.DataPropertyName = "lugar";
            this.lugar.HeaderText = "Lugar";
            this.lugar.Name = "lugar";
            this.lugar.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // prestamosInformatica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataInformaticaEliminar);
            this.Controls.Add(this.btnMostrarPrestamos);
            this.Controls.Add(this.btnRegistrarPrestamos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dataPrestamos);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.maskCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboInformatica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "prestamosInformatica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "prestamosInformatica";
            this.Load += new System.EventHandler(this.prestamosInformatica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInformaticaEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUser;
        private Button btnEliminar;
        private Label label3;
        private TextBox txtNombre;
        private Button btnAgregar;
        private MaskedTextBox maskCantidad;
        private Label label2;
        private Label label1;
        private ComboBox comboInformatica;
        private DataGridView dataPrestamos;
        private Button btnMostrarPrestamos;
        private Button btnRegistrarPrestamos;
        private Button btnVolver;
        private DataGridView dataInformaticaEliminar;
        private DataGridViewTextBoxColumn nro;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn marca;
        private DataGridViewTextBoxColumn lugar;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn inventarioInformatica;
        private DataGridViewTextBoxColumn inform;
        private DataGridViewTextBoxColumn cant;
        private DataGridViewTextBoxColumn fechaPrestamo;
        private DataGridViewTextBoxColumn fechaDevolucion;
        private DataGridViewTextBoxColumn encargado;
    }
}