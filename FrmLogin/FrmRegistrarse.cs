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
    public partial class FrmRegistrarse : Form
    {
        public List<Usuario> listaUsuarios;
        private Usuario usuario;
        public FrmRegistrarse(List<Usuario> listaUsuarios)
        {
            InitializeComponent();
            this.listaUsuarios = listaUsuarios;
            this.usuario = new Usuario();
        }

        private void FrmRegistrarse_Load(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {

        }
    }
}
