using OstatnieChwileZKupka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OstatnieChwileZKupkaDwa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Pytanie> pytania;
        int questCounter = 0;
        public MainWindow()
        {
            InitializeComponent();
            pytania = new List<Pytanie>();
            initializeData();
            nextQuestion();
        }

        private void AnswerClick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string udzielonaOdpowiedz = button.Content.ToString();
            int.TryParse(""+udzielonaOdpowiedz.ElementAt(0), out int udzielonaOdpowiedzId);
            udzielonaOdpowiedzId--;
            pytania.ElementAt(questCounter).udzielOdpowiedz(udzielonaOdpowiedzId);
            if (pytania.ElementAt(questCounter).isPoprawna())
            {
                MessageBox.Show("Dobrze"+udzielonaOdpowiedzId);
            }
            else
            {
                MessageBox.Show("Źle"+udzielonaOdpowiedzId);
            }
            questCounter++;
            nextQuestion();
        }

        private void nextQuestion()
        {
            if (questCounter >= pytania.Count)
                return;

            trescPytania.Text = pytania.ElementAt(questCounter).getPytanie();
            opd1.Content = "1. " + pytania.ElementAt(questCounter).getOdpowiedzAt(0);
            opd2.Content = "2. " + pytania.ElementAt(questCounter).getOdpowiedzAt(1);
            opd3.Content = "3. " + pytania.ElementAt(questCounter).getOdpowiedzAt(2);
            opd4.Content = "4. " + pytania.ElementAt(questCounter).getOdpowiedzAt(3);
        }

        void initializeData()
        {
            List<String> trescipytan = new List<String>();
            trescipytan.Add("2*2=?");
            trescipytan.Add("2**2=?");
            trescipytan.Add("2+2=?");
            trescipytan.Add("1/2**-1=?");
            trescipytan.Add("sqrt(4)=?");
            List<List<string>> odpowiedziPytan = new List<List<string>>();
            List<string> odp1 = new List<string>(); 
            List<string> odp2 = new List<string>(); 
            List<string> odp3 = new List<string>(); 
            List<string> odp4 = new List<string>(); 
            List<string> odp5 = new List<string>();
            odp1.Add("1");
            odp2.Add("2");
            odp3.Add("3");
            odp4.Add("4");
            odp5.Add("1");
            odp1.Add("2");
            odp2.Add("3");
            odp3.Add("4");
            odp4.Add("1");
            odp5.Add("2");
            odp1.Add("3");
            odp2.Add("4");
            odp3.Add("1");
            odp4.Add("2");
            odp5.Add("3");
            odp1.Add("4");
            odp2.Add("1");
            odp3.Add("2");
            odp4.Add("3");
            odp5.Add("4");
            odpowiedziPytan.Add(odp1);
            odpowiedziPytan.Add(odp2);
            odpowiedziPytan.Add(odp3);
            odpowiedziPytan.Add(odp4);
            odpowiedziPytan.Add(odp5);
            List<int> poprawneOdpowiedzi = new List<int>();
            poprawneOdpowiedzi.Add(3);
            poprawneOdpowiedzi.Add(2);
            poprawneOdpowiedzi.Add(1);
            poprawneOdpowiedzi.Add(0);
            poprawneOdpowiedzi.Add(3);
            for(int i = 0; i < 5; i++)
            {
                pytania.Add(new Pytanie(trescipytan.ElementAt(i), odpowiedziPytan.ElementAt(i), poprawneOdpowiedzi.ElementAt(i)));
            }
        }
    }
}
