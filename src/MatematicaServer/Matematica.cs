using System;
using System.Runtime.InteropServices;
using System.EnterpriseServices;

namespace MatematicaServer
{
    // Guid & ProgId foram gerados a partir do utilitário "Create GUID" do Visual Studio 2022
    [ClassInterface(ClassInterfaceType.None), Guid("6DC23E10-C92B-442C-A7B8-FA564828EDD8"), ProgId("MatematicaServer.Matematica")]
    public class Matematica : ServicedComponent, IMatematica
    {
        public int Somar(int Primeiro, int Segundo)
        {
            return Primeiro + Segundo;
        }

        public int Subtrair(int Primeiro, int Segundo)
        {
            return Primeiro - Segundo;
        }

        public int Multiplicar(int Primeiro, int Segundo)
        {
            return Primeiro * Segundo;
        }

        public float Dividir(int Primeiro, int Segundo)
        {
            return Primeiro / Segundo;
        }
    }
}
