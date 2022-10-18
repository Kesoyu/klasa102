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
    }
}
