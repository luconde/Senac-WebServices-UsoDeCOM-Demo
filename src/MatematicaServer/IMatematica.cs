using System;
using System.Runtime.InteropServices;
using System.EnterpriseServices;


namespace MatematicaServer
{
    // Guid foi gerado a partir do utilitário "Create GUID" do Visual Studio 2022
    [InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("57CF9B41-4B09-4D68-83D6-A40C3F183128")]
    public interface IMatematica
    {
        int Somar(int Primeiro, int Segundo);
        int Subtrair(int Primeiro, int Segundo);
        int Multiplicar(int Primeiro, int Segundo);
        float Dividir(int Primeiro, int Segundo);
    }
}
