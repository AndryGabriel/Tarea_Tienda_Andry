using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_Ucan_Martin_Andry_Gabriel.Entities;

namespace Tienda_Ucan_Martin_Andry_Gabriel.Services
{
    public class ClienteService
    {
        public Cliente AgregarDatos()
        {
            try
            {
                Cliente DatosCliente = new Cliente();
                {
                    Console.WriteLine("======TUS DATOS======");
                    Console.WriteLine("Ingresa nombre: ");
                    DatosCliente.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingresa Telefono: ");
                    DatosCliente.Telefono = Console.ReadLine();
                    Console.WriteLine("Ingresa correo: ");
                    DatosCliente.Correo = Console.ReadLine();

                    Console.Clear();

                    Console.Clear();
                   
                    Console.WriteLine("Tus datos son: ");
                    Console.WriteLine("Nombre: " + DatosCliente.Nombre);
                    Console.WriteLine("Telefono: " + DatosCliente.Telefono);
                    Console.WriteLine("Correo: " + DatosCliente.Correo);
                  
                }
                return DatosCliente;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error. " + ex.Message);
            }

        }

        public void NumerosYFunciones()
        {
            try
            {
                int num1, num2, num3, num4, num5, Resultado;
                Console.WriteLine("Ingresa tu primer numero:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa tu segundo numero:");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa tu tercer numero:");
                num3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa tu cuarto numero:");
                num4 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa tu quinto numero:");
                num5 = int.Parse(Console.ReadLine());

                Resultado = num1 + num2 + num3 + num4 + num5;
                Console.WriteLine("La suma de los numeros ingresados es: " + Resultado);
           

                if (Resultado >= 5000 && Resultado < 8000)
                {
                    double Descuento = Resultado * 0.10;
                    Console.WriteLine("El descuento del 10% es: " + Descuento);

                }
                if (Resultado >= 8000 && Resultado < 10000)
                {
                    double TresMeses = Resultado / 3;
                    Console.WriteLine("Se le cobra en tres meses sin intereses, por lo cual son " + TresMeses + " por mes.");

                }
                if (Resultado >= 10000)
                {
                    Console.WriteLine("Click num 3 para sacar 3 MESES o click num 6 para  6 MESES?");
                    int CantidadMeses = int.Parse(Console.ReadLine());

                    switch (CantidadMeses)
                    {
                        case 3:
                            double TresM = Resultado / 3;
                            Console.WriteLine("En tres meses, se le cobra " + TresM + " por mes.");
                            break;

                        case 6:
                            double SeisM = Resultado / 6;
                            Console.WriteLine("En seis meses, se le cobra " + SeisM + " por mes.");
                            break;

                        default:
                            Console.WriteLine("Ocurrio un error - Selecciona  3 o 6.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrio un error. " + ex.Message);
            }

        }

    }
}
