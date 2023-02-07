using Para_inventario.Clases;
using Para_inventario.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Para_inventario.ABM
{
    public partial class login : Form
    {
        Usuario usuario = new Usuario();
        public login()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {
            usuario.mostrar(dataUsuarios);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            if (txtUsuarioCrear.Text == "" || txtContraseñaCrear.Text == "")
            {
                MessageBox.Show("Falta completar algunos datos");
            }
            else
            {
                usuario.nombreUsuario = txtUsuarioCrear.Text;
                usuario.contraseña = txtContraseñaCrear.Text;
                bool bandera = usuario.verificarUsuario(usuario, dataUsuarios);
                if (bandera == false)
                {
                    limpiar();
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtContraseñaCrear.Text = "";
            txtUsuarioCrear.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtContraseña.Enabled = true;
            txtUsuario.Enabled = true;
            lblContraseña.Enabled = true;
            lblNombre.Enabled = true;
            txtContraseñaCrear.Visible = false;
            txtUsuarioCrear.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            btnCrear.Enabled = true;
            btnIniciarSesion.Enabled = true;
            btnCrearUsuario.Visible = false;
            btnVolver.Visible = false;
        }

        private void mostrar()
        {
            txtContraseña.Enabled = false;
            txtUsuario.Enabled = false;
            lblContraseña.Enabled = false;
            lblNombre.Enabled = false;
            txtContraseñaCrear.Visible = true;
            txtUsuarioCrear.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            btnCrear.Enabled = false;
            btnIniciarSesion.Enabled = false;
            btnCrearUsuario.Visible = true;
            btnVolver.Visible = true;
            txtContraseña.Text = "";
            txtUsuario.Text = "";
            txtContraseñaCrear.Text = "";
            txtUsuarioCrear.Text = "";
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "" || txtUsuario.Text == "")
            {
                MessageBox.Show("Por favor ingrese un nombre de usuario y contraseña para poder iniciar sesión");
            }
            else
            {
                usuario.nombreUsuario = txtUsuario.Text;
                usuario.contraseña = txtContraseña.Text;
                (bool bandera, int numero) = usuario.login(usuario, dataUsuarios);
                if (bandera)
                {
                    ValoresPublicos.nombreUsuario = txtUsuario.Text;
                    ValoresPublicos.nroUsuario = numero;
                    MessageBox.Show("Bienvenido: " + usuario.nombreUsuario);
                    frmPrincipal ventana = new frmPrincipal();
                    ventana.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El nombre de usuario o la contraseña ingresados son incorrectos");
                }
            }
        }
    }
}
