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
using Tools;

namespace Forms
{
    public partial class FrmMenuPrincipal : Form
    {
        public List<Usuario> listaUsuarios;
        public Usuario usuario;
        private DateTime fecha;
        private string pathUsuarios;
        private string pathEquiposVoley;
        private Form? formularioAcutal = null;
        public Tabla tabla;

        public FrmMenuPrincipal(List<Usuario> listaUsuarios, Usuario usuario)
        {
            InitializeComponent();
            this.listaUsuarios = listaUsuarios;
            this.usuario = usuario;
            this.fecha = DateTime.Now;
            this.pathUsuarios = "usuarios.log";
            this.pathEquiposVoley = "voley.json";
            this.lblUsuario.Text = this.usuario.Nombre;
            this.btnFutbol.Enabled = false;
            this.btnFutbol.Visible = false;
            this.btnVoley.Visible = false;
            this.btnVoley.Visible = false;
            this.btnBasquet.Visible = false;
            this.btnBasquet.Visible = false;
            this.tabla = new Tabla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.btnFutbol.Enabled = true;
            this.btnFutbol.Visible = true;
            this.btnVoley.Visible = true;
            this.btnVoley.Visible = true;
            this.btnBasquet.Visible = true;
            this.btnBasquet.Visible = true;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.CargarArchivos();
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.GuardarArhivos();
            this.DialogResult = DialogResult.OK;
        }

        private void CargarArchivos()
        {
            List<Voley>? listAux = Archivo.LeerArchivoJson<Voley>(this.pathEquiposVoley);

            if (listAux != null)
            {
                this.tabla.ListaVoley = listAux;
            }

        }

        private void GuardarArhivos()
        {
            using (StreamWriter sw = new StreamWriter(this.pathUsuarios, true, Encoding.UTF8))
            {
                sw.WriteLine(this.usuario.ToString());
                sw.WriteLine("  " + fecha.ToString("yyyy-MM-dd HH:mm:ss"));
            }

            Archivo.GuardarArchivoJson(this.pathEquiposVoley, this.tabla.ListaVoley);
        }

        private void lblUsuario_Click_1(object sender, EventArgs e)
        {
            FrmUsuario1 frmUsuario = new FrmUsuario1(this.usuario);
            frmUsuario.ShowDialog();
        }

        private void btnVoley_Click(object sender, EventArgs e)
        {
            FrmVoley frmVoley = new FrmVoley(this.tabla);
            AbrirFormularioHijo(frmVoley);

        }

        private void btnFutbol_Click(object sender, EventArgs e)
        {
            FrmFutbol frmFutbol = new FrmFutbol(this.tabla);
            AbrirFormularioHijo(frmFutbol);
        }

        private void btnBasquet_Click(object sender, EventArgs e)
        {
            FrmBasquet frmBasquet = new FrmBasquet(this.tabla);
            AbrirFormularioHijo(frmBasquet);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void AbrirFormularioHijo(Form formularioHijo)
        {

            if (formularioAcutal != null)
            {
                this.formularioAcutal.Close();
            }

            formularioAcutal = formularioHijo;

            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            this.pnlFormulario.Controls.Add(formularioHijo);
            this.pnlFormulario.Tag = formularioHijo;

            formularioHijo.BringToFront();
            formularioHijo.Show();

        }

        private void btnMostrarVoley_Click(object sender, EventArgs e)
        {
            FrmMostrar1 frmMostrar = new FrmMostrar1(this.tabla, EDeporte.Voley);
            AbrirFormularioHijo(frmMostrar);
        }

        private void btnMostrarFutbol_Click(object sender, EventArgs e)
        {
            FrmMostrar1 frmMostrar = new FrmMostrar1(this.tabla, EDeporte.Futbol);
            AbrirFormularioHijo(frmMostrar);
        }

        private void btnMostrarBasquet_Click(object sender, EventArgs e)
        {
            FrmMostrar1 frmMostrar = new FrmMostrar1(this.tabla, EDeporte.Basquet);
            AbrirFormularioHijo(frmMostrar);
        }
    }
}
