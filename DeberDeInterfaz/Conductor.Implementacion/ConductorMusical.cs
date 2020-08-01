using System;
using System.Collections.Generic;
using System.Text;
using Conductor.Implementacion;

namespace Conductor.Implementacion
{
    public class ConductorMusical :  IConductor
    {
        private Conductor conductor = new Conductor();
        public int Id { get { return conductor.Id; } set { conductor.Id = value; } } 
        public string Acelerando()
        {
            return "va mas rapido en  la carretera  para llegar pronto mientras escucha musica";
        }

        public string CambiandoDeMarchas()
        {
            return "cambian de marchas al escuchar el motor ";
        }

        public string Encendido()
        {
            return "enciende el auto y pone musica que le gusta ";
        }

        public string Frenando()
        {
            return " va frenado para poder cambiar de musica ";
        }

        public string Manejar()
        {
           return " maneja muentra va cantando su musica";
        }
    }
}
