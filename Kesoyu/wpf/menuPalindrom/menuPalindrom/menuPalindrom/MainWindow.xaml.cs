using System;
using System.Collections;
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

namespace menuPalindrom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<String, StackPanel> allWindow = new Dictionary<string, StackPanel>();
        public MainWindow()
        {
            InitializeComponent();
            allWindow.Add("palindrom", palindromWindow);
            allWindow.Add("anagram", angaramWindow);
            allWindow.Add("pierwsze", pierwszeWindow);
            allWindow.Add("nwd", nwdWindow);
            allWindow.Add("nww", nwwWindow);
            allWindow.Add("babelkowe", sortowanieBabelkowe);
            allWindow.Add("wst", sortowaniePrzezWstawianie);
            allWindow.Add("wbr", sortowaniePrzezWybieranie);
        }

        private void SelectWindow(String name)
        {
            foreach (StackPanel panel in allWindow.Values)
            {
                panel.Visibility = Visibility.Hidden;
            }
            allWindow[name].Visibility = Visibility.Visible;
        }

        private void Palindrom(object sender, RoutedEventArgs e)
        {
            SelectWindow("palindrom");
        }

        private void Anagram(object sender, RoutedEventArgs e)
        {
            SelectWindow("anagram");
        }

        private void NWD(object sender, RoutedEventArgs e)
        {
            SelectWindow("nwd");
        }

        private void NWW(object sender, RoutedEventArgs e)
        {
            SelectWindow("nww");
        }

        private void sortBabelkowe(object sender, RoutedEventArgs e)
        {
            SelectWindow("babelkowe");
        }

        private void sortWst(object sender, RoutedEventArgs e)
        {
            SelectWindow("wst");
        }

        private void sortWbr(object sender, RoutedEventArgs e)
        {
            SelectWindow("wbr");
        }
        private bool isPalindrom(string text)
        {
            if (text.Length % 2 == 0)
            {
                for(int i = 0; i < text.Length/2; i++)
                {
                    if(text[i] != text[text.Length-1-i])
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < (text.Length-1) / 2; i++)
                {
                    if (text[i] != text[text.Length -1- i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool isAnagram(string firstText, string secondText)
        {
            if (firstText.Length != secondText.Length)
                return false;
            List<Char> firstTextTable = new List<Char>();
            List<Char> secondTextTable = new List<Char>();
            for(int i = 0; i < firstText.Length; i++)
            {
                firstTextTable.Add(firstText[i]);
            }
            for (int i = 0; i < secondText.Length; i++)
            {
                secondTextTable.Add(secondText[i]);
            }
            firstTextTable.Sort();
            secondTextTable.Sort();
            for(int i = 0; i < firstTextTable.Count; i++)
            {
                if(firstTextTable[i] != secondTextTable[i])
                {
                    return false;
                }
            }
            return true;
        }

        private void isPalindromClick(object sender, RoutedEventArgs e)
        {
            String palindromText = palindromTextField.Text;
            if (palindromText.Length == 0)
                palindromOutput.Text = "ale coś wpisz ok?";
            if (palindromText.Length == 0)
                return;
            if (isPalindrom(palindromText))
                palindromOutput.Text = "Podane słowo jest palindromem";
            else {
                palindromOutput.Text = "zjebales";
            }
        }

        private void isAngaramClick(object sender, RoutedEventArgs e)
        {
            String firstAngramText = anagramFirstText.Text;
            String secondAngramText = anagramSecondText.Text;
            if (firstAngramText.Length == 0 || secondAngramText.Length == 0)
                anagramOutput.Text = "ale wpisz coś ok?";
            if (isAnagram(firstAngramText, secondAngramText))
                anagramOutput.Text = "Slowa sa anagramami";
            else
                anagramOutput.Text = "zjebales";
        }
        List<int> pierwszeNumberList = new List<int>();
        private void pierwsze(object sender, RoutedEventArgs e)
        {
            
            Random rand = new Random();
            SelectWindow("pierwsze");
            String numbers = string.Empty;
            for(int i = 0; i < 10; i++)
            {
                pierwszeNumberList.Add(rand.Next(1, 100));
                if (i == 9)
                    numbers += pierwszeNumberList[i];
                else
                    numbers += pierwszeNumberList[i] + ", ";
            }
            pierwszeNumberText.Text += numbers;
            
        }

        private void searchFirstNumber(object sender, RoutedEventArgs e)
        {
            if(pierwszeNumberList.Count != 0)
            {

            }
        }
    }
}
