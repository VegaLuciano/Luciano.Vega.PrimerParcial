using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Futbol : Equipo
    { 
        private List<Jugador> amonestados;

        
        public override List<Jugador> Jugadores { get => Jugadores;}
        public override List<Jugador> Titulares { get => titulares; }
        public override List<Jugador> Suplentes { get => suplentes; }
        public List<Jugador> Amonestados { get => amonestados; }

        private void Formacion(int titulares) 
        {
            Random random = new Random();
            this.titulares = this.jugadores.OrderBy(x => random.Next()).Take(titulares).ToList();
            this.suplentes = this.jugadores.Except(this.titulares).ToList();
        }

        private void ComprobarAmonestados() 
        {
            foreach (Jugador jugador in jugadores) 
            {
                if (jugador.Amonestado == true) 
                {
                    this.amonestados.Add(jugador);
                }
            }
        }

        public override string PresentarFormacion() 
        {
            this.Formacion(this.cantTitulares);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Titulares:");
            foreach(Jugador jugador in this.titulares)
            {
                if (jugador == this.titulares[0])
                    sb.Append($"{jugador.Nombre} - Capitan");
                sb.AppendLine(jugador.Nombre);
            }
            sb.AppendLine("Suplentes:");
            foreach (Jugador jugador in this.suplentes)
            {
                sb.AppendLine(jugador.Nombre);
            }

            return sb.ToString();
        }
    }
}
