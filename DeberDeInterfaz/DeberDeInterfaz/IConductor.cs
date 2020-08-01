using System;
using System.Collections.Generic;
using System.Text;

namespace Conductor
{
    public interface IConductor
    {
        string Encendido();
        string Manejar();
        string Frenando();
        string Acelerando();
        string CambiandoDeMarchas();
    }
}
