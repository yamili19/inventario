namespace Para_inventario.Transacciones
{
    partial class prestamoHerramientas
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.dataHerramientasBaja = new System.Windows.Forms.DataGridView();
            this.nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPrestamos = new System.Windows.Forms.DataGridView();
            this.inventarioHerramienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.herramienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboHerramienta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskCantidad = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarPrestamos = new System.Windows.Forms.Button();
            this.btnRegistrarPrestamos = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataHerramientasBaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Red;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(450, 375);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(95, 38);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dataHerramientasBaja
            // 
            this.dataHerramientasBaja.AllowUserToAddRows = false;
            this.dataHerramientasBaja.AllowUserToDeleteRows = false;
            this.dataHerramientasBaja.AllowUserToOrderColumns = true;
            this.dataHerramientasBaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHerramientasBaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nro,
            this.nombre,
            this.marca,
            this.material,
            this.lugar,
            this.cantidad});
            this.dataHerramientasBaja.Location = new System.Drawing.Point(12, 319);
            this.dataHerramientasBaja.Name = "dataHerramientasBaja";
            this.dataHerramientasBaja.ReadOnly = true;
            this.dataHerramientasBaja.RowTemplate.Height = 25;
            this.dataHerramientasBaja.Size = new System.Drawing.Size(107, 119);
            this.dataHerramientasBaja.TabIndex = 19;
            this.dataHerramientasBaja.Visible = false;
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
            // material
            // 
            this.material.DataPropertyName = "material";
            this.material.HeaderText = "Material";
            this.material.Name = "material";
            this.material.ReadOnly = true;
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
            // dataPrestamos
            // 
            this.dataPrestamos.AllowUserToAddRows = false;
            this.dataPrestamos.AllowUserToDeleteRows = false;
            this.dataPrestamos.AllowUserToOrderColumns = true;
            this.dataPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventarioHerramienta,
            this.herramienta,
            this.cantidadDisponible,
            this.fechaPrestamo,
            this.fechaDevolucion,
            this.encargado});
            this.dataPrestamos.Location = new System.Drawing.Point(12, 100);
            this.dataPrestamos.Name = "dataPrestamos";
            this.dataPrestamos.ReadOnly = true;
            this.dataPrestamos.RowTemplate.Height = 25;
            this.dataPrestamos.Size = new System.Drawing.Size(714, 269);
            this.dataPrestamos.TabIndex = 20;
            this.dataPrestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPrestamos_CellClick);
            // 
            // inventarioHerramienta
            // 
            this.inventarioHerramienta.DataPropertyName = "inventarioHerramienta";
            this.inventarioHerramienta.HeaderText = "inventarioHerramienta";
            this.inventarioHerramienta.Name = "inventarioHerramienta";
            this.inventarioHerramienta.ReadOnly = true;
            this.inventarioHerramienta.Visible = false;
            // 
            // herramienta
            // 
            this.herramienta.DataPropertyName = "herramienta";
            this.herramienta.HeaderText = "Herramienta";
            this.herramienta.Name = "herramienta";
            this.herramienta.ReadOnly = true;
            this.herramienta.Width = 150;
            // 
            // cantidadDisponible
            // 
            this.cantidadDisponible.DataPropertyName = "cantidad";
            this.cantidadDisponible.HeaderText = "Cantidad";
            this.cantidadDisponible.Name = "cantidadDisponible";
            this.cantidadDisponible.ReadOnly = true;
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
            this.encargado.HeaderText = "Encargado";
            this.encargado.Name = "encargado";
            this.encargado.ReadOnly = true;
            this.encargado.Width = 120;
            // 
            // comboHerramienta
            // 
            this.comboHerramienta.FormattingEnabled = true;
            this.comboHerramienta.Location = new System.Drawing.Point(125, 21);
            this.comboHerramienta.Name = "comboHerramienta";
            this.comboHerramienta.Size = new System.Drawing.Size(172, 23);
            this.comboHerramienta.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Herramienta: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cantidad: ";
            // 
            // maskCantidad
            // 
            this.maskCantidad.Location = new System.Drawing.Point(125, 52);
            this.maskCantidad.Mask = "99999";
            this.maskCantidad.Name = "maskCantidad";
            this.maskCantidad.Size = new System.Drawing.Size(100, 23);
            this.maskCantidad.TabIndex = 24;
            this.maskCantidad.ValidatingType = typeof(int);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(551, 47);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(63, 30);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrarPrestamos
            // 
            this.btnMostrarPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMostrarPrestamos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMostrarPrestamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnMostrarPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMostrarPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarPrestamos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarPrestamos.Location = new System.Drawing.Point(277, 375);
            this.btnMostrarPrestamos.Name = "btnMostrarPrestamos";
            this.btnMostrarPrestamos.Size = new System.Drawing.Size(167, 38);
            this.btnMostrarPrestamos.TabIndex = 32;
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
            this.btnRegistrarPrestamos.Location = new System.Drawing.Point(551, 375);
            this.btnRegistrarPrestamos.Name = "btnRegistrarPrestamos";
            this.btnRegistrarPrestamos.Size = new System.Drawing.Size(175, 38);
            this.btnRegistrarPrestamos.TabIndex = 31;
            this.btnRegistrarPrestamos.Text = "Registrar Prestamos";
            this.btnRegistrarPrestamos.UseVisualStyleBackColor = false;
            this.btnRegistrarPrestamos.Click += new System.EventHandler(this.btnRegistrarPrestamos_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(344, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(201, 23);
            this.txtNombre.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(248, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Encargado: ";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(620, 47);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(67, 30);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUser.Location = new System.Drawing.Point(557, 18);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(57, 20);
            this.lblUser.TabIndex = 45;
            this.lblUser.Text = "asdasd";
            // 
            // prestamoHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnMostrarPrestamos);
            this.Controls.Add(this.btnRegistrarPrestamos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.maskCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboHerramienta);
            this.Controls.Add(this.dataPrestamos);
            this.Controls.Add(this.dataHerramientasBaja);
            this.Controls.Add(this.btnVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "prestamoHerramientas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "prestamoHerramientas";
            this.Load += new System.EventHandler(this.prestamoHerramientas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHerramientasBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVolver;
        private DataGridView dataHerramientasBaja;
        private DataGridViewTextBoxColumn nro;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn marca;
        private DataGridViewTextBoxColumn material;
        private DataGridViewTextBoxColumn lugar;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridView dataPrestamos;
        private ComboBox comboHerramienta;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskCantidad;
        private Button btnAgregar;
        private Button btnMostrarPrestamos;
        private Button btnRegistrarPrestamos;
        private TextBox txtNombre;
        private Label label3;
        private DataGridViewTextBoxColumn inventarioHerramienta;
        private DataGridViewTextBoxColumn herramienta;
        private DataGridViewTextBoxColumn cantidadDisponible;
        private DataGridViewTextBoxColumn fechaPrestamo;
        private DataGridViewTextBoxColumn fechaDevolucion;
        private DataGridViewTextBoxColumn encargado;
        private Button btnEliminar;
        private Label lblUser;
    }
}