using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beisbol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo equipo1 = new Equipo();
            equipo1.Nombre = "Yaquis";
            equipo1.Ciudad = "Obregon";
            equipo1.Entrenador = "Jose";
            equipo1.jugadores.Add(new Jugador("Jeferson Gutierritos", "1"));
            equipo1.jugadores.Add(new Jugador("Alvin Yakitori", "2"));
            equipo1.jugadores.Add(new Jugador("Pepe Gonzales", "3"));
            equipo1.jugadores.Add(new Jugador("German Adrian", "4"));
            equipo1.jugadores.Add(new Jugador("Francisco Ayala", "5"));
            equipo1.jugadores.Add(new Jugador("Juan Alfoso", "6"));
            equipo1.jugadores.Add(new Jugador("Roberto Carrizo", "7"));
            equipo1.jugadores.Add(new Jugador("Andrew Garcia", "8"));
            equipo1.jugadores.Add(new Jugador("Potente Powers", "9"));

            equipos.Add(equipo1);

            Equipo equipo2 = new Equipo();
            equipo2.Nombre = "Tomateros";
            equipo2.Ciudad = "Culiacan";
            equipo2.Entrenador = "Rayan";
            equipo2.jugadores.Add(new Jugador("Sebas The Rat", "1"));
            equipo2.jugadores.Add(new Jugador("Tony Tompson", "2"));
            equipo2.jugadores.Add(new Jugador("Osvaldo Beltran", "3"));
            equipo2.jugadores.Add(new Jugador("Akim Aguilar", "4"));
            equipo2.jugadores.Add(new Jugador("Ryck Sanchez", "5"));
            equipo2.jugadores.Add(new Jugador("Juan Guarnizo", "6"));
            equipo2.jugadores.Add(new Jugador("Victor Ochoa", "7"));
            equipo2.jugadores.Add(new Jugador("Franco Escamilla", "8"));
            equipo2.jugadores.Add(new Jugador("Mym Alkapone", "9"));

            equipos.Add(equipo2);

            foreach (Equipo equipox in equipos)
            {
                Console.WriteLine("Equipo: " + equipox.Nombre);
                foreach (Jugador jugadorx in equipox.jugadores)
                {
                    Console.WriteLine("Jugador" + jugadorx.Numero+": "+jugadorx.Nombre);
                }
                Console.WriteLine("");

            }
            Console.ReadLine();
        }
    }
}
