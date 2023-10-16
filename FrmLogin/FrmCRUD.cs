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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms
{
    public partial class FrmCRUD : Form
    {
        public List<Equipo> listaEquipos;
        public Usuario usuario;
        public FrmCRUD(List<Equipo> listaEquipos, Usuario usuario)
        {
            InitializeComponent();
            this.listaEquipos = listaEquipos;
            this.usuario = usuario;
        }

        private void FrmCRUD_Load(object sender, EventArgs e)
        {
            this.cmbDeporte.Items.AddRange(Enum.GetNames(typeof(EDeporte)));
            this.cmbDivision.Items.AddRange(Enum.GetNames(typeof(EDivisiones)));
            this.lblErrorNombreEntrenador.Text = string.Empty;
            this.lblNombreError.Text = string.Empty;
        }

        private void btnCargarPlanilla_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configura el cuadro de diálogo
            openFileDialog.Title = "Seleccionar un archivo";
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string archivoSeleccionado = openFileDialog.FileName;
            }
        }
    }
}
