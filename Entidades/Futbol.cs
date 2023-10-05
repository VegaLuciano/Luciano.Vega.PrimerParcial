using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Futbol : Equipo
    {
        private EDeporte deporte;
        private List<Jugador> jugadores;

        public override EDeporte Deporte { get => deporte;}
        public override List<Jugador> Jugadores { get => Jugadores;}

        private void Formacion(int titulares) 
        {
            Random random = new Random();
            this.titulares = this.jugadores.OrderBy(x => random.Next()).Take(titulares).ToList();
            this.suplentes = this.jugadores.Except(this.titulares).ToList();
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
