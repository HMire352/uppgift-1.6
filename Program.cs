using System;
namespace Uppgift_._16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur lång låt är den låten du vill spela?) (minst 2 min 45 sek och max 4 min 20 sek)");
            int långtminut = int.Parse(Console.ReadLine());
            int sek = int.Parse(Console.ReadLine());
            int m = långtminut * 60;
            int total = sek + m;

            if (total >= 165 && total <= 260)
            {
                Console.WriteLine("Din låt får spelas på radiosystemet");

            }
            else
            {
                Console.WriteLine("Din låt får inte spelas på radiosystemet");

            }
        }
    }

}

  
