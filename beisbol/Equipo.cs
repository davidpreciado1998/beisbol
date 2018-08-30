﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beisbol
{
    class Equipo
    {
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Entrenador { get; set; }
        public List<Jugador> jugadores { get; set; }
        public Estadio estadio { get; set; }

        public Equipo()
        {
            jugadores = new List<Jugador>();
        }
    }
}
