using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace PPT
{
    class Program
    {
        public static void players()
        {
            Console.WriteLine("Esciba su nombre");
            string player = Console.ReadLine();
        }
       
        public static void Lifes()
        {                                    
           int life = 3;
            while (life > 0)
            {
                Random rand = new Random();
                int objecto = rand.Next(1, 4);
                string ppt = "";
                life = life - 1;
                bool lose = false;
                Console.WriteLine("Cual es tu jugada");
                string jugada = Console.ReadLine();
                int number_object = 0;
                switch (jugada)
                {
                    case "piedra":
                        number_object = 1;
                        break;
                    case "papel":
                        number_object = 2;
                        break;
                    case "tijera":
                        number_object = 3;
                        break;
                }
                switch (objecto)
                {
                    case 1:
                        ppt = "piedra";
                        break;
                    case 2:
                        ppt = "papel";
                        break;
                    case 3:
                        ppt = "tijera";
                        break;
                }
                Console.WriteLine("La pc escogio {0}", ppt);
                
                if (objecto == 2 && number_object == 1) { lose = false; }
                else if (objecto == number_object)
                {
                    Console.WriteLine("Empate");
                    life = life + 1;
                    // Console.WriteLine("Te quedan {0} vida(s)", life);
                }
                else if(objecto == 2 && number_object == 3) { lose = true; }
                else if (objecto == 1 && number_object == 2) { lose = false; }
                else if (objecto == 1 && number_object == 3) { lose = true; }
                else if (objecto == 3 && number_object == 1) { lose = false; }
                else if (objecto == 3 && number_object == 2) { lose = true; }
                if (lose == true)
                {
                    Console.WriteLine("Perdiste");
                    life = life - 1;
                    Console.WriteLine("Te quedan {0} vida(s)", life);
                }
                
                
                else {
                    Console.WriteLine("Ganaste");
                    life = life + 1;
                    Console.WriteLine("Te quedan {0} vida(s)", life);
                }

                if (life == 0)
                {
                    Console.WriteLine("Has perdido todas tu vidas, quedas descalificado.");
                }
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a piedra, papel o tijera" +
                " Reglas:" +
                " 1.Si tu contador de vidas llega a 0 pierdes" +
                " 2.Tu contador de vidas subira cada vez que ganes" +
                " 3.Empiezas con tres vidas");
            players();
            Lifes();

        }
    }
}
