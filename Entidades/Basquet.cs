using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Basquet : Equipo
    {
        private bool equipoMedico;
        private string? sponsor;

        public Basquet() : base()
        {
            this.deporte = EDeporte.Basquet;
        }

        public Basquet(string nombre, int cantTitulares, EDivisiones division, string entrenador) : base(nombre, cantTitulares, division)
        {
            this.deporte = EDeporte.Basquet;
            this.entrenador = entrenador;
        }

        public Basquet(string nombre, int cantTitulares, EDivisiones division, string entrenador, bool equipoMedico, string sponsor) : this(nombre, cantTitulares, division, entrenador)
        {
            this.equipoMedico = equipoMedico;
            this.sponsor = sponsor;
        }
        public Basquet(string nombre, int cantTitulares, EDivisiones division, string entrenador, bool equipoMedico, string sponsor , EDeporte deporte, int cantSuplentes) : this(nombre, cantTitulares, division, entrenador, equipoMedico, sponsor)
        {
            this.deporte = deporte;
            this.cantSuplentes = cantSuplentes;
        }

        public override List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public bool EquipoMedico { get => equipoMedico; set => equipoMedico = value; }
        public string? Sponsor { get => sponsor; set => sponsor = value; }

        private void Formacion(int titulares)
        {
            Random random = new Random();
            //this.titulares = this.jugadores.OrderBy(x => random.Next()).Take(titulares).ToList();
            // this.suplentes = this.jugadores.Except(this.titulares).ToList();
        }
        public override string ToString()
        {
            string respuesta = "no";
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            if (equipoMedico)
                respuesta = "si";
            sb.AppendLine($"Equipo médico {respuesta}");
            sb.AppendLine($"Sponsor {this.sponsor}");
            return sb.ToString();
        }

        public override string PresentarFormacion()
        {
            this.Formacion(this.cantTitulares);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Titulares:");
            /* foreach (Jugador jugador in this.titulares)
             {
                 if (jugador == this.titulares[0])
                     sb.Append($"{jugador.Nombre} - Capitan");
                 sb.AppendLine(jugador.Nombre);
             }
             sb.AppendLine("Suplentes:");
             foreach (Jugador jugador in this.suplentes)
             {
                 sb.AppendLine(jugador.Nombre);
             }*/

            return sb.ToString();
        }
    }
}
