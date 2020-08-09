using System;
using System.Security.Cryptography.X509Certificates;

namespace Practica_imprimir_meses_del_año
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INGRESE UN NUMERO DEL MES.");
            int numeroMes = int.Parse(Console.ReadLine());
            Console.WriteLine(NombreDelMes (numeroMes ));
            Console.WriteLine("aqui continuaria la ejecucion del resto del programa");
            try
            {
                Console.WriteLine(NombreDelMes(numeroMes));
            }catch (Exception e)
            {
                Console.WriteLine("mensaje de la excepcion: " + e.Message );
            }
        }
        public static string NombreDelMes (int mes )
        {
            switch (mes )
            {
                case 1:
                    return "ENERO";
                case 2:
                    return "febrero";
                case 3:
                    return "marzo";
                case 4:
                    return "abril";
                case 5:
                    return "mayo";
                case 6:
                    return "junio";
                case 7:
                    return "julio";
                case 8:
                    return "agosto";
                case 9:
                    return "septiembre";
                case 10:
                    return "octubre";
                case 11:
                    return "noviembre";
                case 12:
                    return "diciembre";
                default:
                    throw new ArgumentOutOfRangeException(); 
            }
        }
    }
}