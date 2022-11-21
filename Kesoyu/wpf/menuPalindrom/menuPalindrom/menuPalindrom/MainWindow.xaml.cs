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
        private string liczbyPreSet = "Liczby: ";
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
            sortBubbleNumbers.Text = liczbyPreSet;
            sortBubbleOutput.Text = liczbyPreSet;
            listBubbleNumbers = randomNumbers(1, 100, 10);
            showIntList(listBubbleNumbers, sortBubbleNumbers);
        }

        private void sortWst(object sender, RoutedEventArgs e)
        {
            SelectWindow("wst");
            sortInsertionNumbers.Text = liczbyPreSet;
            sortInsertionOutput.Text = liczbyPreSet;
            listInsertionNumbers = randomNumbers(1, 100, 10);
            showIntList(listInsertionNumbers, sortInsertionNumbers);
        }

        private void sortWbr(object sender, RoutedEventArgs e)
        {
            SelectWindow("wbr");
            sortSelectionNumbers.Text = liczbyPreSet;
            sortSelectionOutput.Text = liczbyPreSet;
            listSelectionNumbers = randomNumbers(1, 100, 10);
            showIntList(listSelectionNumbers, sortSelectionNumbers);
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
                palindromOutput.Text = "źle";
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
                anagramOutput.Text = "źle";
        }
        List<int> pierwszeNumberList = new List<int>();

        private List<int> randomNumbers(int a, int b, int c)
        {
            List<int> result = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < c; i++)
            {
                result.Add(rand.Next(a, b));
            }
            return result;
        }

        private void showIntList(List<int> list, TextBlock textBlock)
        {
            string result = string.Empty;
            for(int i = 0; i < list.Count; i++)
            {
                result += list[i] + ", ";
            }
            result = result.Remove(result.Length - 1);
            result = result.Remove(result.Length - 1);
            textBlock.Text =liczbyPreSet + result;
        }
        private void pierwsze(object sender, RoutedEventArgs e)
        {
            pierwszeNumberText.Text = "Liczby: ";
            pierwszeOutputText.Text = "Liczby: ";
            pierwszeNumberList.Clear();
            
            SelectWindow("pierwsze");
            pierwszeNumberList = randomNumbers(1, 100, 10);
            showIntList(pierwszeNumberList, pierwszeNumberText);
            
        }

        private void searchFirstNumber(object sender, RoutedEventArgs e)
        {
            bool warunek;
            String returnText = String.Empty;
            if(pierwszeNumberList.Count != 0)
            {
                for(int i = 0; i < pierwszeNumberList.Count; i++)
                {
                    warunek = true;
                    for (int j = 2; j < pierwszeNumberList[i]; j++)
                    {
                        if (pierwszeNumberList[i] % j == 0)
                        {
                            warunek = false;
                        }
                    }
                    if(warunek)
                        returnText += pierwszeNumberList[i] + ", ";
                }
                if (returnText != String.Empty)
                {
                    returnText = returnText.Remove(returnText.Length - 1);
                    returnText = returnText.Remove(returnText.Length - 1);
                }
                pierwszeOutputText.Text += returnText;
            }
        }
        private void nwdClick(object sender, RoutedEventArgs e)
        {
            int.TryParse(nwdA.Text, out int a);
            int.TryParse(nwdB.Text, out int b);
            nwdOutput.Text = searchNWD(a, b).ToString();

        }
        private int searchNWD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
        private void nwwClick(object sender, RoutedEventArgs e)
        {
            int.TryParse(nwwA.Text, out int a);
            int.TryParse(nwwB.Text, out int b);
            nwwOutput.Text = searchNWW(a, b).ToString();
        }
        private int searchNWW(int a, int b)
        {
            return Math.Abs(a * b) / searchNWD(a,b);
        }

        List<int> listBubbleNumbers = new List<int>();

        private void sortBubbleClick(object sender, RoutedEventArgs e)
        {
            sortBubble();
            showIntList(listBubbleNumbers, sortBubbleOutput);

        }

        private void sortBubble()
        {
            int temp = new int();
            for (int i = 0; i < listBubbleNumbers.Count; i++)
            {
                for (int j = 0; j < listBubbleNumbers.Count - 1; j++)
                {
                    if (listBubbleNumbers[j] > listBubbleNumbers[j + 1])
                    {
                        temp = listBubbleNumbers[j + 1];
                        listBubbleNumbers[j + 1] = listBubbleNumbers[j];
                        listBubbleNumbers[j] = temp;
                    }
                }
            }
        }

        List<int> listInsertionNumbers = new List<int>();

        private void sortInsertionClick(object sender, RoutedEventArgs e)
        {
            sortInsertion();
            showIntList(listInsertionNumbers, sortInsertionOutput);
        }

        private void sortInsertion()
        {
            for (int i = 1; i < listInsertionNumbers.Count; i++)
            {
                var key = listInsertionNumbers[i];
                var flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (key < listInsertionNumbers[j])
                    {
                        listInsertionNumbers[j + 1] = listInsertionNumbers[j];
                        j--;
                        listInsertionNumbers[j + 1] = key;
                    }
                    else flag = 1;
                }
            }
        }

        List<int> listSelectionNumbers = new List<int>();

        private void sortSelectionClick(object sender, RoutedEventArgs e)
        {
            sortSelection();
            showIntList(listSelectionNumbers, sortSelectionOutput);
        }

        private void sortSelection()
        {
            for (int i = 0; i < listSelectionNumbers.Count - 1; i++)
            {
                var smallestVal = i;
                for (int j = i + 1; j < listSelectionNumbers.Count; j++)
                {
                    if (listSelectionNumbers[j] < listSelectionNumbers[smallestVal])
                    {
                        smallestVal = j;
                    }
                }
                var tempVar = listSelectionNumbers[smallestVal];
                listSelectionNumbers[smallestVal] = listSelectionNumbers[i];
                listSelectionNumbers[i] = tempVar;
            }
        }
    }
}
