﻿using Entidades;
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
    public partial class FrmFutbol : FrmCRUD
    {
        private Color colorCamisetaLocal;
        private Color colorCamisetaVisitante;
        public FrmFutbol(List<Equipo> listaEquipo, Usuario usuario) : base(listaEquipo, usuario)
        {
            InitializeComponent();

        }

        private void btnContinuar_Click_1(object sender, EventArgs e)
        {
            if (base.FuncionContinuar())
            {

                if (this.colorLocal.Color != Color.Empty)
                {

                    if (this.colorVisitante.Color != Color.Empty)
                    {

                        Futbol EquipoFutbol = new Futbol(this.txtNombre.Text, (int)this.npdCantTitulares.Value, base.SetearCampoDivision(), this.txtNombreEntrenador.Text,
                            this.colorCamisetaLocal, this.colorCamisetaVisitante, EDeporte.Futbol, (int)this.npdCantSuplentes.Value);
                        this.listaEquipos.Add(EquipoFutbol);

                        EquipoFutbol.Jugadores = this.listJugadores;
                        MessageBox.Show(EquipoFutbol.ToString());
                        MessageBox.Show("Se cargó todo exitosamente!");
                        this.lblErrorLocal.Text = string.Empty;
                        this.lblErrorVisitante.Text = string.Empty;
                    }
                    else
                    {
                        this.lblErrorVisitante.Text = "Error, seleccione un color";
                    }
                }
                else
                {
                    this.lblErrorLocal.Text = "Error, seleccione un color";
                }

            }
        }

        private void btnCamisetaLocal_Click(object sender, EventArgs e)
        {
            if (colorLocal.ShowDialog() == DialogResult.OK)
            {
                this.colorCamisetaLocal = colorLocal.Color;
                this.btnCamisetaLocal.BackColor = this.colorLocal.Color;
            }
        }

        private void btnVisitante_Click(object sender, EventArgs e)
        {
            if (colorVisitante.ShowDialog() == DialogResult.OK)
            {
                this.btnVisitante.BackColor = this.colorVisitante.Color;
                this.colorCamisetaVisitante = colorVisitante.Color;
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmFutbol_Load(object sender, EventArgs e)
        {

        }
    }
}
