using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Voley : Equipo
    {
        private ECancha cancha;
        private string? sedeDelEquipo;

        public Voley() : base()
        {
            this.deporte = EDeporte.Voley;
        }

        public Voley(string nombre, int cantTitulares, EDivisiones division, string entrenador) : base(nombre, cantTitulares, division)
        {
            this.deporte = EDeporte.Voley;
            this.entrenador = entrenador;
        }

        public Voley(string nombre, int cantTitulares, EDivisiones division, string entrenador, ECancha cancha, string sedeDelEquipo) : this(nombre, cantTitulares, division, entrenador)
        {
            this.cancha = cancha;
            this.sedeDelEquipo = sedeDelEquipo;
        }
        public Voley(string nombre, int cantTitulares, EDivisiones division, string entrenador, ECancha cancha, string sedeDelEquipo, EDeporte deporte, int cantSuplentes) : this(nombre, cantTitulares, division, entrenador, cancha, sedeDelEquipo)
        {
            this.deporte = deporte;
            this.cantSuplentes = cantSuplentes;
        }

        public override List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public ECancha Cancha { get => cancha; set => cancha = value; }
        public string? SedeDelEquipo { get => sedeDelEquipo; set => sedeDelEquipo = value; }

        private void Formacion(int titulares)
        {
            Random random = new Random();
            //this.titulares = this.jugadores.OrderBy(x => random.Next()).Take(titulares).ToList();
           // this.suplentes = this.jugadores.Except(this.titulares).ToList();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Cancha {this.cancha.ToString()}");
            sb.AppendLine($"Sede {this.sedeDelEquipo}");
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
