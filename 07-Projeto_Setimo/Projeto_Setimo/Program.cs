using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Setimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseDeDados baseDeDados = new BaseDeDados();
            InterfaceGrafica interfaceGrafica = new InterfaceGrafica(baseDeDados);
            interfaceGrafica.IniciaInterface();
        }
    }
}
