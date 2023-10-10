using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Voley : Equipo
    {
        private int cantArmadores;
        private int cantPuntas;
        private int cantLiberos;
        private int cantCentrales;
        private int cantOpuestos;

        public Voley(int cantJugadores, string nombre, int cantTitulares, int cantSuplentes) : base (cantJugadores, nombre, cantTitulares, cantSuplentes)
        {
            this.cantJugadores = cantJugadores;
            this.nombre = nombre;
            this.cantTitulares = cantTitulares;
            this.cantSuplentes = cantSuplentes;
        }

        public Voley(int cantArmadores, int cantPuntas, int cantLiberos, int cantCentrales, int cantOpuestos, int cantJugadores, string nombre, int cantTitulares, int cantSuplentes) : this(cantJugadores, nombre, cantTitulares, cantSuplentes)
        {
            this.cantArmadores = cantArmadores;
            this.cantPuntas = cantPuntas;
            this.cantLiberos = cantLiberos;
            this.cantCentrales = cantCentrales;
            this.cantOpuestos = cantOpuestos;
        }
        public Voley(int cantArmadores, int cantPuntas, int cantLiberos, int cantCentrales, int cantOpuestos, int cantJugadores, string nombre, int cantTitulares, int cantSuplentes, EDivisiones division, EDeporte deporte, string entrenador) : base(cantJugadores, nombre, cantTitulares, cantSuplentes, division, deporte, entrenador)
        {
            this.cantArmadores = cantArmadores;
            this.cantPuntas = cantPuntas;
            this.cantLiberos = cantLiberos;
            this.cantCentrales = cantCentrales;
            this.cantOpuestos = cantOpuestos;
        }

        public override List<Jugador> Jugadores { get => jugadores; }
        public override List<Jugador> Titulares { get => titulares; }
        public override List<Jugador> Suplentes { get => suplentes; }
        public int CantArmadores { get => cantArmadores; set => cantArmadores = value; }
        public int CantPuntas { get => cantPuntas; set => cantPuntas = value; }
        public int CantLiberos { get => cantLiberos; set => cantLiberos = value; }
        public int CantCentrales { get => cantCentrales; set => cantCentrales = value; }
        public int CantOpuestos { get => cantOpuestos; set => cantOpuestos = value; }

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
            foreach (Jugador jugador in this.titulares)
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
