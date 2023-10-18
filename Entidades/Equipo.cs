﻿using System.Text;

namespace Entidades
{
    public abstract class Equipo
    {
        protected EDeporte deporte;
        protected string nombre;
        protected int cantTitulares;
        protected int cantSuplentes;
        protected EDivisiones division;
        protected string entrenador;
        protected List<Jugador> jugadores;
        

        public Equipo()
        {
            this.deporte = new EDeporte();
            this.nombre = "None";
            this.division = new EDivisiones();
            this.entrenador = "None";
            this.jugadores = new List<Jugador>();
        }

        public Equipo( string nombre, int cantTitulares) :  this()
        {
            this.nombre = nombre;
            this.cantTitulares = cantTitulares;          
        }

        public Equipo( string nombre, int cantTitulares, EDivisiones division) : this(nombre, cantTitulares)
        {
            this.division = division;
        }

        public Equipo( string nombre,  int cantTitulares, EDivisiones division, EDeporte deporte, string entrenador, int cantSuplentes) : this( nombre, cantTitulares, division)
        {
            this.entrenador = entrenador;
            this.deporte = deporte;
            this.cantSuplentes = cantSuplentes;
        }

        public abstract List<Jugador> Jugadores { get; }
        public EDeporte Deporte { get => deporte; }
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
            sb.AppendLine($"Entrenador: {this.entrenador}");
            sb.AppendLine($"Jugadores: {this.jugadores.Count}");
            sb.AppendLine($"Suplentes: {this.cantSuplentes}");
            sb.AppendLine($"Titulares: {this.cantTitulares}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static Equipo operator +(Equipo equipo, Jugador jugador)
        {
            if (equipo.jugadores.IndexOf(jugador) == -1)
            {
                equipo.jugadores.Add(jugador);
            }
            else 
            {
                equipo.jugadores[equipo.jugadores.IndexOf(jugador)] = jugador;
            }
            
            return equipo;
        }
        public static Equipo operator -(Equipo equipo, Jugador jugador)
        {
            if (equipo.jugadores.IndexOf(jugador) != -1)
            {
                equipo.jugadores.Remove(jugador);
            }

            return equipo;
        }
    }
}