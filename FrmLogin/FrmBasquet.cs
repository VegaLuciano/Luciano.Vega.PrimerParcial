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
    public partial class FrmBasquet : FrmCRUD
    {
        public FrmBasquet(List<Equipo> listaEquipos, Usuario usuario) : base(listaEquipos, usuario)
        {
            InitializeComponent();

        }

        private void FrmBasquet_Load(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click_1(object sender, EventArgs e)
        {
            if (FuncionContinuar())
            {
                if (Validaciones.ValidarAtributos(this.txtSponsor.Text, 1))
                {
                    if (!this.rdbNo.Checked == this.RdbSi.Checked)
                    {
                        Basquet EquipoVoley = new Basquet(this.txtNombre.Text, (int)this.npdCantTitulares.Value, base.SetearCampoDivision(), this.txtNombreEntrenador.Text,
                            this.RdbSi.Checked, this.txtSponsor.Text, EDeporte.Basquet, (int)this.npdCantSuplentes.Value);

                        this.listaEquipos.Add(EquipoVoley);
                        EquipoVoley.Jugadores = this.listJugadores;
                        MessageBox.Show(EquipoVoley.ToString());
                        MessageBox.Show("Se cargó todo exitosamente!");
                        this.lblErrorSponsor.Text = string.Empty;
                        this.lblErrorCmb.Text = string.Empty;
                    }
                    else
                    {
                        this.lblErrorSponsor.Text = "Error, complete los campos";
                    }
                }
                else
                {
                    this.lblErrorSponsor.Text = "Error, sponsor invalido";
                }
            }
        }
    }
}
