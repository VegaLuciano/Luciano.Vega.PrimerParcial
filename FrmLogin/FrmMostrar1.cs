using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms
{
    public partial class FrmMostrar1 : Form
    {
        private Tabla tabla;
        private EDeporte deporteSeleccionado;
        private Equipo? equipoSeleccionado;

        public FrmMostrar1()
        {
            InitializeComponent();
            this.tabla = new Tabla();
        }

        public FrmMostrar1(Tabla tabla, EDeporte deporte) : this()
        {
            this.tabla = tabla;
            this.deporteSeleccionado = deporte;
        }


        private void FrmMostrar1_Load(object sender, EventArgs e)
        {
            switch (deporteSeleccionado)
            {
                case EDeporte.Futbol:
                    this.dtgMostrar.DataSource = this.tabla.ListaFutbol;
                    break;
                case EDeporte.Basquet:
                    this.dtgMostrar.DataSource = this.tabla.ListaBasquet;
                    break;
                case EDeporte.Voley:
                    this.dtgMostrar.DataSource = this.tabla.ListaVoley;
                    break;
            };
        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            List<Jugador>? list = new List<Jugador>();
            list = this.equipoSeleccionado.Jugadores;

            if (this.dtgMostrar.SelectedRows.Count > 0)
            {
                this.dtgMostrar.DataSource = null;
                this.dtgMostrar.DataSource = list;
            }

        }

        private void dtgMostrar_SelectionChanged(object sender, EventArgs e)
        {

            if (this.dtgMostrar.SelectedRows.Count > 0)
            {
                // Obtén el índice de la fila seleccionada
                int index = this.dtgMostrar.SelectedRows[0].Index;

                if (index >= 0)
                {
                    switch (this.deporteSeleccionado)
                    {
                        case EDeporte.Futbol:
                            this.equipoSeleccionado = this.tabla.ListaFutbol[index];
                            break;
                        case EDeporte.Voley:
                            this.equipoSeleccionado = this.tabla.ListaVoley[index];
                            break;
                        case EDeporte.Basquet:
                            this.equipoSeleccionado = this.tabla.ListaBasquet[index];
                            break;
                    };
                }
            }
        }

        private void ActualizarDataGridView()
        {
            this.dtgMostrar.DataSource = null;

            switch (this.deporteSeleccionado)
            {
                case EDeporte.Futbol:
                    this.dtgMostrar.DataSource = this.tabla.ListaFutbol;
                    break;
                case EDeporte.Voley:
                    this.dtgMostrar.DataSource = this.tabla.ListaVoley;
                    break;
                case EDeporte.Basquet:
                    this.dtgMostrar.DataSource = this.tabla.ListaBasquet;
                    break;

            };
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            switch (this.deporteSeleccionado)
            {
                case EDeporte.Futbol:
                    this.tabla.ListaFutbol.Remove((Futbol)this.equipoSeleccionado);
                    break;
                case EDeporte.Voley:
                    this.tabla.ListaVoley.Remove((Voley)this.equipoSeleccionado);
                    break;
                case EDeporte.Basquet:
                    this.tabla.ListaBasquet.Remove((Basquet)this.equipoSeleccionado);
                    break;

            };

            this.ActualizarDataGridView();
        }

    }

}