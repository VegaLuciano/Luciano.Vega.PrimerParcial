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
    public partial class FrmJugador : Form
    {
        public Jugador Jugador;
        public Equipo equipo;
        private int index;
        private bool esNuevo;

        public FrmJugador(Jugador jugador, Equipo equipo)
        {
            this.Jugador = jugador;
            InitializeComponent();
            this.equipo = equipo;
            this.esNuevo = false;
        }
        public FrmJugador(Jugador jugador, Equipo equipo, int index)
        {
            this.Jugador = jugador;
            InitializeComponent();
            this.equipo = equipo;
            this.index = index;
            this.esNuevo=true;
        }

        private void FrmJugador_Load(object sender, EventArgs e)
        {
            this.lblErrorAltura.Text = string.Empty;
            this.lblErrorDeporte.Text = string.Empty;
            this.lblErrorApellido.Text = string.Empty;
            this.lblErrorDivision.Text = string.Empty;
            this.lblErrorDni.Text = string.Empty;
            this.lblErrorGenero.Text = string.Empty;
            this.lblErrorNombre.Text = string.Empty;
            this.lblErrorEdad.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            bool allOk = true;

            if (!Validaciones.ValidarAtributos(this.txtNombre.Text, 1))
            {
                allOk = false;
                this.lblErrorNombre.Text = "Error, nombre invalido";
            }
            else
                this.lblErrorNombre.Text = string.Empty;

            if (!Validaciones.ValidarAtributos(this.txtApellido.Text, 1))
            {
                allOk = false;
                this.lblErrorApellido.Text = "Error, apellido invalido";
            }
            else
                this.lblErrorApellido.Text = string.Empty;

            if (Validaciones.ValidarAtributos(this.npdEdad.Text, 1))
            {
                allOk = false;
                this.lblErrorEdad.Text = "Error, Edad invalido";
            }
            else
                this.lblErrorEdad.Text = string.Empty;

            if (Validaciones.ValidarAtributos(this.npdDni.Text, 1) || this.npdDni.Text.Length > 11)
            {
                allOk = false;
                this.lblErrorDni.Text = "Error, dni invalido";
            }
            else
                this.lblErrorDni.Text = string.Empty;

            if (Validaciones.ValidarAtributos(this.txtAltura.Text, 1) || !Validaciones.EsFormtatoAlturaValido(this.txtAltura.Text))
            {
                allOk = false;
                this.lblErrorAltura.Text = "Error, altura invalido";
            }
            else
                this.lblErrorAltura.Text = string.Empty;

            if (this.cmbDivision.SelectedItem == null)
            {
                allOk = false;
                this.lblErrorDivision.Text = "Error, complete el campo";
            }
            else
                this.lblErrorDivision.Text = string.Empty;

            if (this.cmbGenero.SelectedItem == null)
            {
                allOk = false;
                this.lblErrorGenero.Text = "Error, complete el campo";
            }
            else
                this.lblErrorGenero.Text = string.Empty;

            if (this.cmbDeporte.SelectedItem == null)
            {
                allOk = false;
                this.lblErrorDeporte.Text = "Error, complete el campo";
            }
            else
                this.lblErrorDeporte.Text = string.Empty;

            if (allOk)
            {
                //this.equipo.Jugadores.Add();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
