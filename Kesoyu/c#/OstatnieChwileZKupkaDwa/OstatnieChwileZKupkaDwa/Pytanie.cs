using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OstatnieChwileZKupka
{
    internal class Pytanie
    {
        private string tresc;
        private List<string> odpowiedzi;
        private int poprawnaOdpowiedz;
        private bool isUdzielona;
        private int udzielonaOdpowiedz;
        
        public Pytanie(string t, List<string> o, int PO)
        {
            tresc = t;
            odpowiedzi = o;
            poprawnaOdpowiedz = PO;
            isUdzielona = false;
        }

        public string getPytanie()
        {
            return tresc;
        }
        
        public string getOdpowiedzAt(int index)
        {
            return odpowiedzi.ElementAt(index);
        }
        public void udzielOdpowiedz(int udzielona)
        {
            udzielonaOdpowiedz = udzielona;
            isUdzielona = true;
        }

        public bool isPoprawna()
        {
            
            if (isUdzielona)
                if (udzielonaOdpowiedz == poprawnaOdpowiedz)
                    return true;

            return false;
        }
    }
}
