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
    public partial class FrmMenuPrincipal : Form
    {
        public List<Usuario> listaUsuarios;
        public Usuario usuario;
        public List<Equipo> listaEquipos;
        public FrmMenuPrincipal(List<Usuario> listaUsuarios, Usuario usuario)
        {
            InitializeComponent();
            this.listaUsuarios = listaUsuarios;
            this.usuario = usuario;
            this.listaEquipos = new List<Equipo>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmCRUD frmCRUD = new FrmCRUD(this.listaEquipos, this.usuario);
            frmCRUD.ShowDialog();
        }
    }
}
