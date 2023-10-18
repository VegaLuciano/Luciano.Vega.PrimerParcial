using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FrmUsuario : Form
    {
        Usuario usuario;
        string contraseñaOculta;
        public FrmUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.contraseñaOculta = new string('*', this.usuario.Contraseña.Length);
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.lblUsApellido.Text = this.usuario.Apellido;
            this.lblUsNombre.Text = this.usuario.Nombre;
            this.lblUsMail.Text = this.usuario.Mail;
            this.lblUsContraseña.Text = this.contraseñaOculta;
        }

        private void rdbContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbContraseña.Checked)
                this.lblUsContraseña.Text = this.usuario.Contraseña;
            else
                this.lblUsContraseña.Text = this.contraseñaOculta;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
