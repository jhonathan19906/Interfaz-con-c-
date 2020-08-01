using System;
using System.Collections.Generic;

namespace Conductor.Implementacion
{
    public class Conductor : IConductor
    {
        private List<string> LlavesEncendido;
        private string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public List<string> llavesEncendido
        {
            get
            {
                return llavesEncendido;
            }
            set
            {
                llavesEncendido = value;
            }
        }
        public string Encendido()
        {
            return "Estoy prendiendo el auto";
        }
        public string Manejar()
        {
            return "Estoy manejando por la carretera";
        }
        public string Frenando()
        {
            return "Estoy frenando el auto";
        }
        public string Acelerando()
        {
            return "Estoy acelerando el auto ";
        }
        public string CambiandoDeMarchas()
        {
            return "Estoy cambiando de marchas al auto";
        }
    }
}
