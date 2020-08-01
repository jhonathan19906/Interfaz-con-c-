namespace Conductor.Negocio
{
    public class EmpresaChofer
    {
        public IConductor Conductor { get;  set; }
        public string EmpresaChoferConductor(IConductor conductor)
        {
            Conductor = Conductor;
            return "contrate un conductor";
        }
        public string ManejarAuto()
        {
            return Conductor.Encendido() + "Auto" +
                Conductor.Frenando() + "Auto" +
                Conductor.Acelerando() + "Auto" +
                Conductor.CambiandoDeMarchas() + "Auto";
        }
        public string EmpresaChoferConductor()
        {
           //to do Conductor = new ConductorEstandar();
            return "Contrata un conductor";
        }

        public string EmpresaChoferConductorModerno()
        {
            //to do Conductor = new ConductorModerno();
            return "Contrate un chofer moderno";
        }
        public string EmpresaChoferConductorMusical()
        {
            //to do Conductor = new ConductorMusical();
            return " el conductor le gusta la musica mientra maneja";
        }
    }
}
