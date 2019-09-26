using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите любое число");
            int digit = Convert.ToInt32(Console.ReadLine());
            int initialdigit = digit;
            int initialdigit2 = digit;
            int digitqty = 0;
            int chetnih = 0;
            int nech = 0;


            while (digit != 0)
            {
                digit = digit / 10;
                digitqty++;

                if ((initialdigit % 2) == 0)
                {
                    chetnih = chetnih + (initialdigit % 10);

                }
                initialdigit = initialdigit / 10;

                if (((initialdigit2) % 10 % 3) == 0)
                {
                    nech++;

                }
                initialdigit2 = initialdigit2 / 10;
            }
            Console.WriteLine("Количество цифр в числе " + initialdigit + " равно - " + digitqty);
            Console.WriteLine($"Сумма четных цифр равна - " + chetnih);
            Console.WriteLine($"Сумма цифр кратных трем - " + nech);

            Console.ReadKey();
        }
    }
}
