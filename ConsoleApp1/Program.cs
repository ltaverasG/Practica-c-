using System;
using System.Collections.Concurrent;

namespace Practica_Bucles
{
    class Program
    {
        static void Main(string[] args)
        {// programa que genere un numero aleatorio, entre 0 a 100, y nos pregunte que numero es, si introducimos un numero que nos
         // diga si es un numero mayo o un numero menor y que diga el numero exacto y que diga los intentos para ubicar el numero.

            // variables 
            Random rdm = new Random();
            int numeroRandom = rdm.Next(0, 100);
            int intentos = 0;
            int numeroPlayer = 0;
            Console.WriteLine("BIENVENIDO ¿DESEA JUGAR?");
            string respuesta = "si";
            string respuestaPlayer = Console.ReadLine();
            //condicion 
            if (respuestaPlayer  == "si")
            {
                Console.WriteLine("INGRESE UN NUMERO");
                numeroPlayer = Convert.ToInt32(Console.ReadLine());
            }
              //bucle 
            while (respuestaPlayer != "no")
            {
                if (numeroPlayer < numeroRandom )
                {
                    Console.WriteLine("EL NUMERO INGRESADO ES MENOR. INTENTE DE NUEVO");
                    numeroPlayer = Convert.ToInt32 (Console.ReadLine());
                    intentos++;
                }
                else if (numeroPlayer > numeroRandom)
                {
                    Console.WriteLine("EL NUMERO INGRESADO ES MAYOR. INTENTE DE NUEVO ");
                    numeroPlayer = Convert.ToInt32(Console.ReadLine());
                    intentos++; 
                }
                else
                { 
                    Console.WriteLine(" HAS GANADO!!!!!!!!!");
                    Console.WriteLine("TOTAL DE INTENTOS:{0} ",intentos );
                    break;
                }
            }
        }
    }
}
