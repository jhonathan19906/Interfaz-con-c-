using System.Collections.Generic;


namespace Conductor.Entidad
{
    public  class Conductor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<string> LlavesEncendido{ get; set;}
    }
}
