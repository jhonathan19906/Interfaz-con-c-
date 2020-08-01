using System.Collections.Generic;

namespace Conductor.Implementacion
{
    public class ConductorModerno :  IConductor
    {
        public int Id { get; set; }

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
