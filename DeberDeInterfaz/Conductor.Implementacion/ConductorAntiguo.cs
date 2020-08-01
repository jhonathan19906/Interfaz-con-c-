using System;
using System.Collections.Generic;
using System.Text;

namespace Conductor.Implementacion
{
    public  class ConductorAntiguo : IConductor
    {
        private List<string> LlavesEncendido;
        private string nombre;   
        public string Nombre { get 
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
        //utilisamos verbos para los nombres de los comentarios 
        public string Encendido()
        {
            return $"Mi nonbre es: {nombre} y estoy manejando {llavesEncendido[0]}";
        }
        public string Manejar()
        {
            return "";
        }
        public string Frenando()
        {
            return "";
        }
        public string Acelerando()
        {
            return "";
        }
        public string CambiandoDeMarchas()
        {
            return "";
        }
    }
}
 