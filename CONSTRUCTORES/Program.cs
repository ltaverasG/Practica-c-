using System;

namespace CONSTRUCTORES
{
    class Program
    {
        static void Main(string[] args)
        {
            coche coche1 = new coche();  // crea un nuevo objeto o una nueva instancia coche.

            Console.WriteLine(coche1.GetInfoCoche());
            coche coche2 = new coche(4500.25,1200.35);
            Console.WriteLine(coche2.GetInfoCoche());
        }
    }   
    class coche
    {
        // contructor   
        public coche ()
        {
            Ruedas= 4;
            Ancho = 2300.5;
            Largo  = 0.800;
        }

        public int getRuedas()  // se le da acceso a las caracteristicas o propiedades del coche privadas (private).
        {
            return Ruedas; 
        }

        public String GetInfoCoche() // constructor que trae las propiedades concatenadas 
        {
            return "Informacion del coche:\n" + "RUEDAS: " + Ruedas + "\nANCHO: " + Ancho + "\nLARGO: " + Largo; ;
        }

        public coche ( double LargoCoche , double AnchoCoche) // SOBRECARGA DE CONSTRUCTORES  
        {
            Ruedas = 4;

            Largo = LargoCoche;

            Ancho = AnchoCoche; 
        }

        // caracteristicas / o / propiedades 
        private int Ruedas;
        private double Largo;
        private double Ancho;
        private bool Climatizador;
        private string Tapiceria; 
    }
}
