namespace Para_inventario.ABM
{
    partial class login
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtContraseñaCrear = new System.Windows.Forms.TextBox();
            this.txtUsuarioCrear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.dataUsuarios = new System.Windows.Forms.DataGridView();
            this.nroUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::Para_inventario.Properties.Resources.Captura;
            this.btnCerrar.Location = new System.Drawing.Point(392, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 31);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(182, 83);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(155, 23);
            this.txtContraseña.TabIndex = 38;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(182, 50);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(155, 23);
            this.txtUsuario.TabIndex = 37;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContraseña.Location = new System.Drawing.Point(62, 83);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(108, 21);
            this.lblContraseña.TabIndex = 36;
            this.lblContraseña.Text = "Contraseña: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(90, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 21);
            this.lblNombre.TabIndex = 35;
            this.lblNombre.Text = "Usuario: ";
            // 
            // txtContraseñaCrear
            // 
            this.txtContraseñaCrear.Location = new System.Drawing.Point(182, 184);
            this.txtContraseñaCrear.Name = "txtContraseñaCrear";
            this.txtContraseñaCrear.PasswordChar = '*';
            this.txtContraseñaCrear.Size = new System.Drawing.Size(155, 23);
            this.txtContraseñaCrear.TabIndex = 42;
            this.txtContraseñaCrear.Visible = false;
            // 
            // txtUsuarioCrear
            // 
            this.txtUsuarioCrear.Location = new System.Drawing.Point(182, 151);
            this.txtUsuarioCrear.Name = "txtUsuarioCrear";
            this.txtUsuarioCrear.Size = new System.Drawing.Size(155, 23);
            this.txtUsuarioCrear.TabIndex = 41;
            this.txtUsuarioCrear.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Contraseña: ";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(90, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Usuario: ";
            this.label2.Visible = false;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIniciarSesion.Location = new System.Drawing.Point(261, 112);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(92, 23);
            this.btnIniciarSesion.TabIndex = 43;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrear.ForeColor = System.Drawing.Color.Brown;
            this.btnCrear.Location = new System.Drawing.Point(163, 112);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(92, 23);
            this.btnCrear.TabIndex = 44;
            this.btnCrear.Text = "Crear Usuario";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // dataUsuarios
            // 
            this.dataUsuarios.AllowUserToAddRows = false;
            this.dataUsuarios.AllowUserToDeleteRows = false;
            this.dataUsuarios.AllowUserToOrderColumns = true;
            this.dataUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroUsuario,
            this.nombreUsuario,
            this.contraseña});
            this.dataUsuarios.Location = new System.Drawing.Point(289, 151);
            this.dataUsuarios.Name = "dataUsuarios";
            this.dataUsuarios.ReadOnly = true;
            this.dataUsuarios.RowTemplate.Height = 25;
            this.dataUsuarios.Size = new System.Drawing.Size(143, 77);
            this.dataUsuarios.TabIndex = 45;
            this.dataUsuarios.Visible = false;
            // 
            // nroUsuario
            // 
            this.nroUsuario.DataPropertyName = "nroUsuario";
            this.nroUsuario.HeaderText = "nroUsuario";
            this.nroUsuario.Name = "nroUsuario";
            this.nroUsuario.ReadOnly = true;
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.DataPropertyName = "nombreUsuario";
            this.nombreUsuario.HeaderText = "nombreUsuario";
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.ReadOnly = true;
            // 
            // contraseña
            // 
            this.contraseña.DataPropertyName = "contraseña";
            this.contraseña.HeaderText = "contraseña";
            this.contraseña.Name = "contraseña";
            this.contraseña.ReadOnly = true;
            this.contraseña.Visible = false;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCrearUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCrearUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrearUsuario.ForeColor = System.Drawing.Color.Brown;
            this.btnCrearUsuario.Location = new System.Drawing.Point(261, 213);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(92, 23);
            this.btnCrearUsuario.TabIndex = 46;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Visible = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Location = new System.Drawing.Point(163, 213);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(54, 23);
            this.btnVolver.TabIndex = 47;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Visible = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Para_inventario.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(430, 257);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.dataUsuarios);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtContraseñaCrear);
            this.Controls.Add(this.txtUsuarioCrear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCerrar;
        private TextBox txtContraseña;
        private Label lblContraseña;
        private Label lblNombre;
        private TextBox txtContraseñaCrear;
        private TextBox txtUsuarioCrear;
        private Label label1;
        private Label label2;
        private Button btnIniciarSesion;
        private Button btnCrear;
        private DataGridView dataUsuarios;
        private DataGridViewTextBoxColumn nroUsuario;
        private DataGridViewTextBoxColumn nombreUsuario;
        private DataGridViewTextBoxColumn contraseña;
        private Button btnCrearUsuario;
        private Button btnVolver;
        private TextBox txtUsuario;
    }
}