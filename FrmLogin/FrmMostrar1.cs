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
    public partial class FrmMostrar1 : Form
    {
        Tabla tabla;
        public FrmMostrar1(Tabla tabla)
        {
            this.tabla = tabla;
            InitializeComponent();
        }

        private void btnVoley_Click(object sender, EventArgs e)
        {
            List<Voley> list = new List<Voley>();

            foreach (var equipo in tabla.ListaVoley)
            {
                if (equipo.Deporte == EDeporte.Voley)
                {
                    list.Add(equipo);
                }
            }

            this.dtgMostrar.DataSource = null;
            this.dtgMostrar.DataSource = list;

        }

        private void btnBasquet_Click(object sender, EventArgs e)
        {
            List<Basquet> list = new List<Basquet>();

            foreach (var equipo in tabla.ListaBasquet)
            {
                if (equipo.Deporte == EDeporte.Basquet)
                {
                    list.Add((Basquet)equipo);
                }
            }

            this.dtgMostrar.DataSource = null;
            this.dtgMostrar.DataSource = list;

        }


        private void btnFutbol_Click(object sender, EventArgs e)
        {
            List<Futbol> list = new List<Futbol>();

            foreach (var equipo in tabla.ListaFutbol)
            {
                if (equipo.Deporte == EDeporte.Futbol)
                {
                    list.Add((Futbol)equipo);
                }
            }

            this.dtgMostrar.DataSource = null;
            this.dtgMostrar.DataSource = list;
        }

        private void FrmMostrar1_Load(object sender, EventArgs e)
        {

        }


        /*private void btnEscalada_Click(object sender, EventArgs e)
        {
            this.dtgMostrar.DataSource = null;
            this.dtgMostrar.DataSource = clasificacion.listaEscalada;
            ultimoBotonPresionado = TipoDeDeportista.Escalada;

        }

        private void btnAtletismo_Click(object sender, EventArgs e)
        {
            this.dtgMostrar.DataSource = null;
            this.dtgMostrar.DataSource = clasificacion.listaAtletismo;
            ultimoBotonPresionado = TipoDeDeportista.Atletismo;
        }

        private void btnVoley_Click(object sender, EventArgs e)
        {
            this.dataGrid.DataSource = null; 
            this.dataGrid.DataSource = clasificacion.listaVoley;
            ultimoBotonPresionado = TipoDeDeportista.Voley;
        }*/
    }
}
