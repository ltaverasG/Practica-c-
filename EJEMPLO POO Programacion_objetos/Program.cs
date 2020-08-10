using System;

namespace EJEMPLO_POO_Programacion_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo; // creacion de objeto tipo circulo 
            miCirculo = new Circulo(); // iniciacion de variable // nuevo objeto 

            Circulo TuCirculo = new Circulo();// creacion de un objeto circulo 

            miCirculo.CalculoArea(5);

            Console.WriteLine(miCirculo.CalculoArea (5));

            Console.WriteLine(TuCirculo.CalculoArea(9)); 
        }
    }
    class Circulo
    {
        
        const  double PI = 3.1416; // PROPIEDAD CLASE CIRCULO / O / CAMPOS DE CLASE 

       public  double  CalculoArea (int radio)      // metodo de clase // public para que se pueda usar en ontra clase 
       {
         return PI * radio * radio ;
       }
    }
}
