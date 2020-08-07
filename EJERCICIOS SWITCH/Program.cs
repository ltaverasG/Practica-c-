using System;

namespace EJERCICIOS_SWITCH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elige un medio de transporte: coche,tren,avion ");
            Console.WriteLine();

            string medioTransporte = Console.ReadLine();
            Console.WriteLine();

            switch (medioTransporte )
            {
                case "coche":
                    Console.WriteLine("Velocidad media: 100 km/h");
                    break;

                case "tren":
                    Console.WriteLine("Velocidad media: 250km/h");
                        break;
                case "avion":
                    Console.WriteLine("Velocidad media: 800km/h");
                    break;

                default:
                    Console.WriteLine("Transporte no contemplado");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Ha terminado el programa.");


        }
    }
}
