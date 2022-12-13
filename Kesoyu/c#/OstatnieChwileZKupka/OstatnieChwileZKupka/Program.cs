using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OstatnieChwileZKupka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pytanie = "Oblicz: 2+2=?";
            List<string> odpowiedzi = new List<string>();
            odpowiedzi.Add("2");
            odpowiedzi.Add("3");
            odpowiedzi.Add("4");
            odpowiedzi.Add("5");
            int poprawnaOdpowiedz = 2;
            Pytanie pytanie1 = new Pytanie(pytanie,odpowiedzi,poprawnaOdpowiedz);
            Console.WriteLine(pytanie1.getPytanie());
            int odp;
            while(!int.TryParse(Console.ReadLine(), out odp))
            pytanie1.udzielOdpowiedz(odp);
            if (pytanie1.isPoprawna())
                Console.WriteLine("Odp jest poprawna");
            else
                Console.WriteLine("Odp jest niepoprawna");
            Console.ReadLine();
        }
    }
}
