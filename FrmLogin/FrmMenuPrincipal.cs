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
        private DateTime fecha;
        private string pathUsuarios;

        public FrmMenuPrincipal(List<Usuario> listaUsuarios, Usuario usuario)
        {
            InitializeComponent();
            this.listaUsuarios = listaUsuarios;
            this.usuario = usuario;
            this.listaEquipos = new List<Equipo>();
            this.fecha = DateTime.Now;
            this.pathUsuarios = "usuarios.log";
            this.lblUsuario.Text = this.usuario.Nombre;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmJugador frmCRUD = new FrmJugador(this.listaEquipos[0].Jugadores[0], this.listaEquipos[0]);
            frmCRUD.ShowDialog();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.GuardarArhivos();
        }

        private void GuardarArhivos()
        {
            using (StreamWriter sw = new StreamWriter(this.pathUsuarios, true, Encoding.UTF8))
            {
                sw.WriteLine(this.usuario.ToString());
                sw.WriteLine("  " + fecha.ToString("yyyy-MM-dd HH:mm:ss"));
            }
        }

        private void lblUsuario_Click_1(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario(this.usuario);
            frmUsuario.ShowDialog();
        }
    }
}
