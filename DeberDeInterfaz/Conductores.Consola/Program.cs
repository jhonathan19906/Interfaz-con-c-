using System;
using Conductor.Implementacion;
using Conductor.Negocio;



namespace Conductores.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EmpresaChofer MiEmpresaChofer = new EmpresaChofer();
            var conductor1 = new ConductorModerno();
            conductor1.Id = 1;
            MiEmpresaChofer.EmpresaChoferConductor(new ConductorModerno());
            MiEmpresaChofer.ManejarAuto();
            var conductor = new ConductorMusical();
            conductor.Id = 1;
            MiEmpresaChofer.EmpresaChoferConductor(conductor);
            MiEmpresaChofer.ManejarAuto();
            //MiEmpresaChofer.EmpresaChoferConductor(new ConductorEstandar());
            //MiEmpresaChofer.ManejarAuto();
            Console.ReadKey();
        }
    }
}
