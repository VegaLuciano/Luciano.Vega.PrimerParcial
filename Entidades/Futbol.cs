using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Futbol : Equipo
    { 
        private Color colorCamisetaLocal;
        private Color colorCamisetaVisitante;

        public Futbol() : base() 
        {
            this.deporte = EDeporte.Futbol;
        }

        public Futbol(string nombre, int cantTitulares, EDivisiones division, string entrenador) : base( nombre, cantTitulares, division)
        {
            this.deporte = EDeporte.Futbol;
            this.entrenador = entrenador;
        }

        public Futbol(string nombre, int cantTitulares, EDivisiones division, string entrenador, Color camisetaLocal, Color camisteVisitante) : this(nombre, cantTitulares, division, entrenador)
        {
            this.colorCamisetaLocal = camisetaLocal;
            this.colorCamisetaVisitante = camisteVisitante;
        }
        public Futbol(string nombre, int cantTitulares, EDivisiones division, string entrenador, Color camisetaLocal, Color camisteVisitante, EDeporte deporte, int cantSuplentes) : this(nombre, cantTitulares, division, entrenador, camisetaLocal, camisteVisitante)
        {
            this.deporte = deporte;
            this.cantSuplentes = cantSuplentes;
        }

        public override List<Jugador> Jugadores { get => Jugadores;}
        public Color ColorCamiseteLocal { get => colorCamisetaLocal; set => colorCamisetaLocal = value; }
        public Color ColorCamisetaVisitante { get => colorCamisetaVisitante; set => colorCamisetaVisitante = value; }


        private void Formacion(int titulares) 
        {
            Random random = new Random();
            //this.titulares = this.jugadores.OrderBy(x => random.Next()).Take(titulares).ToList();
            //this.suplentes = this.jugadores.Except(this.titulares).ToList();
        }

        public override string PresentarFormacion() 
        {
            this.Formacion(this.cantTitulares);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Titulares:");
            /*foreach(Jugador jugador in this.titulares)
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
