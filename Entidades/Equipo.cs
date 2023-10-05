using System.Text;

namespace Entidades
{
    public abstract class Equipo
    {
        protected int cantJugadores;
        protected string nombre;
        protected int cantSuplentes;
        protected int cantTitulares;
        protected List<Jugador> suplentes;
        protected List<Jugador> titulares;

        public Equipo(int cantJugadores, string nombre, int cantSuplentes, int cantTitulares)
        {
            this.cantJugadores = cantJugadores;
            this.nombre = nombre;
            this.cantSuplentes = cantSuplentes;
            this.cantTitulares = cantTitulares;
        }

        public abstract EDeporte Deporte { get; }
        public abstract List<Jugador> Jugadores { get; }
        public abstract string PresentarFormacion();

        protected virtual string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre} ");
            sb.AppendLine($"Deporte: {this.Deporte}");
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