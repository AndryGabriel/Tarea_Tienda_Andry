using System;
using Tienda_Ucan_Martin_Andry_Gabriel.Services;

namespace Tienda_Ucan_Martin_Andry_Gabriel
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
             

                ClienteService AgregarDatos = new ClienteService();
                AgregarDatos.AgregarDatos();

                ClienteService Funciones = new ClienteService();
                Funciones.NumerosYFunciones();


            }
        
    }
}
