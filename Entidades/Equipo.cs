using System.Text;

namespace Entidades
{
    public abstract class Equipo
    {
        protected EDeporte deporte;
        protected int cantJugadores;
        protected string nombre;
        protected int cantTitulares;
        protected int cantSuplentes;
        protected EDivisiones division;
        protected string entrenador;
        protected List<Jugador> jugadores;
        protected List<Jugador> suplentes;
        protected List<Jugador> titulares;

        public Equipo()
        {
            this.deporte = new EDeporte();
            this.nombre = "None";
            this.division = new EDivisiones();
            this.entrenador = "None";
            this.jugadores = new List<Jugador>();
            this.suplentes = new List<Jugador>();
            this.titulares = new List<Jugador>();
        }

        public Equipo(int cantJugadores, string nombre, int cantTitulares, int cantSuplentes) :  this()
        {
            this.cantJugadores = cantJugadores;
            this.nombre = nombre;
            this.cantTitulares = cantTitulares;
            this.cantSuplentes = cantSuplentes;
           
        }

        public Equipo(int cantJugadores, string nombre, int cantTitulares, int cantSuplentes, EDivisiones division) : this(cantJugadores, nombre, cantTitulares, cantSuplentes)
        {
            this.division = division;
        }

        public Equipo(int cantJugadores, string nombre,  int cantTitulares, int cantSuplentes, EDivisiones division, EDeporte deporte, string entrenador) : this(cantJugadores, nombre, cantTitulares, cantSuplentes, division)
        {
            this.deporte = deporte;
            this.entrenador = entrenador;
        }

        public abstract List<Jugador> Jugadores { get; }
        public abstract List<Jugador> Suplentes { get; }
        public abstract List<Jugador> Titulares { get; }
        public EDeporte Deporte { get => deporte; set => deporte = value; }
        protected int CantJugadores { get => cantJugadores; set => cantJugadores = value; }
        protected string Nombre { get => nombre; set => nombre = value; }
        protected int CantTitulares { get => cantTitulares; set => cantTitulares = value; }
        protected int CantSuplentes { get => cantSuplentes; set => cantSuplentes = value; }
        protected EDivisiones Division { get => division; set => division = value; }
        protected string Entrenador { get => entrenador; set => entrenador = value; }

        public abstract string PresentarFormacion();

        protected virtual string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre} ");
            sb.AppendLine($"Deporte: {this.deporte}");
            sb.AppendLine($"Jugadores: {this.cantJugadores}");
            sb.AppendLine($"Suplentes: {this.cantSuplentes}");
            sb.AppendLine($"Titulares: {this.cantTitulares}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}