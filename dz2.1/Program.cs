using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int random = rand.Next(1, 101);
            int chance = 5;
            bool gameOver = false;
            //Console.WriteLine(random);
            
            while (gameOver == false)
            {
                //int playerNumber = Console.ReadLine();
                int playerNumber = Convert.ToInt32(Console.ReadLine());
                chance--;
                // Пытался написать короткий код, но не вышло впихнуть туда и шансы и 4е варианта иф, елсе иф.
                if (playerNumber != random && chance == 0)
                {
                    Console.WriteLine("U have try for 5 times. you lose! ");
                    gameOver = true;
                }
                Console.WriteLine(random == playerNumber ? "You are AWESOME!" : (random < playerNumber ? "WRONG! You'r number is bigger. You have " + chance + " chance" : "WRONG! You'r number is less. You have " + chance + " chance"));

                /*
                else if (random == playerNumber)
                {
                    Console.WriteLine("You are AWESOME! that's right!");
                    gameOver = true;
                }
                else if (random < playerNumber) // научился писать код с одной строкой без фигурных скобочек.
                    Console.WriteLine("WRONG! You'r number is bigger.You have " + chance + " chance");
                else if (random > playerNumber) // научился писать код с одной строкой без фигурных скобочек.
                    Console.WriteLine("WRONG! You'r number is less. You have " + chance + " chance");
                */
            }
            //Console.ReadLine();
            Console.ReadKey();
        }
    }
}
