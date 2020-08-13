using System;

namespace CONSTRUCTORES
{
    class Program
    {
        static void Main(string[] args) /// clase principal 
        {
            coche coche1 = new coche();  // crea un nuevo objeto o una nueva instancia coche.

            Console.WriteLine(coche1.GetInfoCoche());
            coche coche2 = new coche(4500.25, 1200.35);
            Console.WriteLine(coche2.GetInfoCoche());

            coche1.setExtras(true, "cuero");
            Console.WriteLine(coche1.getExtras());
        }
    }


    partial class coche
    {
        // contructor   
        public coche()
        {
            Ruedas = 4;
            Ancho = 2300.5;
            Largo = 0.800;
            Climatizador = true;
        }

        public int getRuedas()  // se le da acceso a las caracteristicas o propiedades del coche privadas (private).
        {
            return Ruedas;
        }

        public String GetInfoCoche() // constructor que trae las propiedades concatenadas 
        {
            return "Informacion del coche: \n" + "RUEDAS: " + Ruedas + "\nANCHO: " + Ancho + "\nLARGO: " + Largo; ;
        }

        public coche(double LargoCoche, double AnchoCoche) // SOBRECARGA DE CONSTRUCTORES  
        {
            Ruedas = 4;

            Largo = LargoCoche;

            Ancho = AnchoCoche;
        }
    }
    partial class coche
    {

    
        public void setExtras(bool parametroClimatizador, string parametroTapiceria)
        {
            Climatizador = parametroClimatizador;

            Tapiceria = parametroTapiceria;

        }
        public string getExtras()
        {
            return "Extras del coche; \n" + "Tapiceria: \n" + Tapiceria + "Climatizador: \n" + Climatizador;
        }
    
        // caracteristicas / o / propiedades 
        private int Ruedas;
        private double Largo;
        private double Ancho;
        private bool Climatizador;
        private string Tapiceria;
    }




}
