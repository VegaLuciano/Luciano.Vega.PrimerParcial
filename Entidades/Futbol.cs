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
        private int cantDelanteros;
        private int cantDefensas;
        private int cantMedioCampistas;
        private int cantArqueros;

        public Futbol(int cantJugadores, string nombre, int cantTitulares, int cantSuplentes) : base(cantJugadores, nombre, cantTitulares, cantSuplentes)
        {
            this.amonestados = new List<Jugador>();
        }

        public Futbol(int cantDelanteros, int cantDefensas, int cantMedioCampistas, int cantArqueros, int cantJugadores, string nombre, int cantTitulares, int cantSuplentes) : this(cantJugadores, nombre, cantTitulares, cantSuplentes)
        {
            this.cantDelanteros = cantDelanteros;
            this.cantDefensas = cantDefensas;
            this.cantMedioCampistas = cantMedioCampistas;
            this.cantArqueros = cantArqueros;
        }
        public Futbol(int cantDelanteros, int cantDefensas, int cantMedioCampistas, int cantArqueros, int cantJugadores, string nombre, int cantTitulares, int cantSuplentes, EDivisiones division, EDeporte deporte, string entrenador) : base(cantJugadores, nombre, cantTitulares, cantSuplentes, division, deporte, entrenador)
        {
            this.amonestados = new List<Jugador>();
            this.cantDelanteros = cantDelanteros;
            this.cantDefensas = cantDefensas;
            this.cantMedioCampistas = cantMedioCampistas;
            this.cantArqueros = cantArqueros;
        }


        public override List<Jugador> Jugadores { get => Jugadores;}
        public override List<Jugador> Titulares { get => titulares; }
        public override List<Jugador> Suplentes { get => suplentes; }
        public List<Jugador> Amonestados { get => amonestados; }
        public int CantDelanteros { get => cantDelanteros; }
        public int CantDefensas { get => cantDefensas; }
        public int CantMedioCampistas { get => cantMedioCampistas; }
        public int CantArqueros { get => cantArqueros; }

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
