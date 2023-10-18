using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace Forms
{
    public partial class FrmVoley : FrmCRUD
    {
        public FrmVoley(List<Equipo> listaEquipo, Usuario usuario) : base(listaEquipo, usuario)
        {
            InitializeComponent();
        }

        private void FrmVoley_Load(object sender, EventArgs e)
        {
            this.cmbCancha.Items.AddRange(Enum.GetNames(typeof(ECancha)));
        }

        public ECancha SetearCampoCancha()
        {
            ECancha retorno;
            if (this.cmbDivision.SelectedIndex == 0)
            {
                retorno = ECancha.Playa;

            }
            else
            {
                retorno = ECancha.Cemento;
            }

            return retorno;
        }

        private void btnContinuar_Click_1(object sender, EventArgs e)
        {
            if (base.FuncionContinuar())
            {
                if (this.cmbCancha.SelectedIndex > -1)
                {
                    if (Validaciones.ValidarCampo(this.txtSedeEquipo.Text))
                    {
                        Voley EquipoVoley = new Voley(this.txtNombre.Text, (int)this.npdCantTitulares.Value, base.SetearCampoDivision(), this.txtNombreEntrenador.Text,
                            SetearCampoCancha(), this.txtSedeEquipo.Text, EDeporte.Voley, (int)this.npdCantSuplentes.Value);

                        this.listaEquipos.Add(EquipoVoley);
                        EquipoVoley.Jugadores = this.listJugadores;
                        MessageBox.Show(EquipoVoley.ToString());
                        MessageBox.Show("Se cargó todo exitosamente!");
                        this.lblErrorSede.Text = string.Empty;
                        this.lblErrorCancha.Text = string.Empty;
                    }
                    else
                    {
                        this.lblErrorSede.Text = "Error, seleccione sede invalida";
                    }
                }
                else
                {
                    this.lblErrorCancha.Text = "Error, seleccione un color";
                }

            }

        }
    }
}
