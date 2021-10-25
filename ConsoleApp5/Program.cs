using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        { //2.2 средний уровень.
            try 
            {
                Console.WriteLine("Введите сумму покупки");
                int x = int.Parse(Console.ReadLine());
                if (x < 500)
                {
                    Console.WriteLine("При такой сумме скидка не предоставляется!");
                    Console.WriteLine("Введите сумму покупки");
                    x = int.Parse(Console.ReadLine());
                }
                else if (x >= 500 && x < 1000)
                {
                    Console.WriteLine("Если сумма покупки выше 500гр скидка 5%: {0}", (x - (x * 0.05)));
                    Console.ReadLine();
                }
                else if (x >= 1000)
                {
                    Console.WriteLine("Если сумма покупки выше 1000гр скидка 10%: {0}", (x - (x * 0.10)));
                    Console.ReadLine();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
     
        }
    }
}
