using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms
{
    public partial class FrmCRUD : Form
    {
        public List<Equipo> listaEquipos;
        public Usuario? usuario;
        public List<Jugador>? listJugadores;
        public FrmCRUD()
        {
            this.listaEquipos = new List<Equipo>();
            this.listJugadores = new List<Jugador>();
            InitializeComponent();
        }

        public FrmCRUD(List<Equipo> listaEquipos, Usuario usuario) : this()
        {
            this.listaEquipos = listaEquipos;
            this.usuario = usuario;
        }

        protected void FrmCRUD_Load(object sender, EventArgs e)
        {
            FrmCRUD.ClearErrorLabels(this.Controls);
        }

        protected void btnCargarPlanilla_Click(object sender, EventArgs e)
        {
            List<string> extensiones = new List<string> { "json", "xml" };

            string path = FrmCRUD.CargarPlanilla(this.lblErrorCargarPlanilla, extensiones);

            if (path != string.Empty)
            {
                string extension = Path.GetExtension(path);
                if (extension == ".json")
                {
                    this.listJugadores = Archivo.LeerArchivoJson<Jugador>(path);
                }
                else
                {
                    this.listJugadores = Archivo.LeerArchivoXML<Jugador>(path);
                }

                this.npdCantJugadores.Value = this.listJugadores.Count;
                this.npdCantJugadores.Enabled = false;
                Equipo.ElegirTitulares(this.listJugadores, (int)this.npdCantTitulares.Value);
                this.npdCantSuplentes.Value = this.listJugadores.Count - Equipo.ContarTitulares(this.listJugadores);
                MessageBox.Show($"{this.npdCantSuplentes.Value} suplentes");
                this.npdCantSuplentes.Enabled = false;
            }
        }

        protected static string CargarPlanilla(Label labelError, List<string> extensionesPermitidas)
        {
            string path = string.Empty;
            labelError.Text = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Cargue su planilla";

            if (extensionesPermitidas != null && extensionesPermitidas.Count > 0)
            {
                string filtro = "Archivos permitidos (";

                foreach (string extension in extensionesPermitidas)
                {
                    filtro += $"*.{extension};";
                }

                filtro = filtro.TrimEnd(';');
                filtro += ")|";

                foreach (string extension in extensionesPermitidas)
                {
                    filtro += $"*.{extension};";
                }

                openFileDialog.Filter = filtro;
            }
            else
            {
                openFileDialog.Filter = "Todos los archivos (*.*)|*.*";
            }

            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
            }
            else
            {
                labelError.Text = "No se seleccionó ningún archivo.";
            }
            return path;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void btnContinuar_Click(object sender, EventArgs e)
        {
            if (this.listJugadores != null)
            {
                if (this.listJugadores.Count > 0)
                {

                    if (this.npdCantTitulares.Value > this.listJugadores.Count || this.npdCantSuplentes.Value > this.listJugadores.Count)
                    {
                        this.lblErrorCantidades.Text = "Error, las cantidades no coinciden";
                    }
                    else if (!(this.listJugadores.Count == (this.npdCantTitulares.Value + this.npdCantSuplentes.Value)))
                    {
                        this.lblErrorCantidades.Text = "Error, las cantidades no coinciden";
                    }
                    else
                    {
                        this.lblErrorCantidades.Text = string.Empty;
                    }
                }
            }
        }

        public bool FuncionContinuar()
        {
            bool allOk = true;
            if (!Validaciones.ValidarAtributos(this.txtNombre.Text, 1))
            {
                allOk = false;
                this.lblErrorNombre.Text = "Error, nomber invalido";
            }
            else
                this.lblErrorNombre.Text = string.Empty;

            if (!Validaciones.ValidarAtributos(this.txtNombreEntrenador.Text, 1))
            {
                this.lblErrorNombreEntrenador.Text = "Error, nombre invalido";
                allOk = false;
            }
            else
                this.lblErrorNombreEntrenador.Text = string.Empty;

            if (!((this.npdCantSuplentes.Value + this.npdCantTitulares.Value) == this.npdCantJugadores.Value))
            {
                this.lblErrorCantidades.Text = "Error, las cantidades no coinciden";
                allOk = false;
            }
            else
                this.lblErrorCantidades.Text = string.Empty;

            if (!(this.cmbDivision.SelectedItem != null))
            {
                this.lblErrorCmb.Text = "Error, complete los campos";
                allOk = false;
            }
            else
                this.lblErrorCmb.Text = string.Empty;

            if (!(this.listJugadores != null))
            {
                this.lblErrorCargarPlanilla.Text = "Error, cargue la planilla";
                allOk = false;
            }
            else
                this.lblErrorCargarPlanilla.Text = string.Empty;

            return allOk;
        }

        public static void ClearErrorLabels(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Label && control.Name.StartsWith("lblError"))
                {
                    Label errorLabel = (Label)control;
                    errorLabel.Text = string.Empty;
                }
            }
        }
        public EDivisiones SetearCampoDivision()
        {
            EDivisiones retorno;
            switch (this.cmbDivision.SelectedIndex)
            {
                case 0:
                    retorno = EDivisiones.Sub16;
                    break;
                case 1:
                    retorno = EDivisiones.Sub18;
                    break;
                case 2:
                    retorno = EDivisiones.Sub21;
                    break;
                default:
                    retorno = EDivisiones.Mayores;
                    break;
            };

            return retorno;
        }
    }

}