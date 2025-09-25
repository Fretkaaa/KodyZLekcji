using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KALKULATOR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        enum Dzialania
        {
            dodaje = 1,
            odejmuje = 2,
            sumuje = 3
        }
        Dzialania wybor = Dzialania.dodaje;
        string Nazwa;

        private void NumberSeven_Click(object sender, RoutedEventArgs e)
        {
            string AktualnyWynik = WynikTextBlock.Text;
            string NowyWynik = AktualnyWynik + "7";
            WynikTextBlock.Text = NowyWynik;
        }

        private void NumberNine_Click(object sender, RoutedEventArgs e)
        {
            string AktualnyWynik = WynikTextBlock.Text;
            string NowyWynik = AktualnyWynik + "9";
            WynikTextBlock.Text = NowyWynik;
        }

        private void NumberEight_Click(object sender, RoutedEventArgs e)
        {
            string AktualnyWynik = WynikTextBlock.Text;
            string NowyWynik = AktualnyWynik + "8";
            WynikTextBlock.Text = NowyWynik;
        }

        private void NumberFour_Click(object sender, RoutedEventArgs e)
        {
            string AktualnyWynik = WynikTextBlock.Text;
            string NowyWynik = AktualnyWynik + "4";
            WynikTextBlock.Text = NowyWynik;
        }

        private void NumberFive_Click(object sender, RoutedEventArgs e)
        {
            string AktualnyWynik = WynikTextBlock.Text;
            string NowyWynik = AktualnyWynik + "5";
            WynikTextBlock.Text = NowyWynik;
        }

        private void NumberSix_Click(object sender, RoutedEventArgs e)
        {
            string AktualnyWynik = WynikTextBlock.Text;
            string NowyWynik = AktualnyWynik + "6";
            WynikTextBlock.Text = NowyWynik;
        }

        private void NumberOne_Click_1(object sender, RoutedEventArgs e)
        {
            string AktualnyWynik = WynikTextBlock.Text;
            string NowyWynik = AktualnyWynik + "1";
            WynikTextBlock.Text = NowyWynik;

        }

        private void NumberTwo_Click(object sender, RoutedEventArgs e)
        {

            string AktualnyWynik = WynikTextBlock.Text;
            string NowyWynik = AktualnyWynik + "2";
            WynikTextBlock.Text = NowyWynik;
        }

        private void NumberThree_Click(object sender, RoutedEventArgs e)
        {
            string AktualnyWynik = WynikTextBlock.Text;
            string NowyWynik = AktualnyWynik + "3";
            WynikTextBlock.Text = NowyWynik;
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            wybor = Dzialania.dodaje;
            Nazwa = WynikTextBlock.Text;
            WynikTextBlock.Text = "";
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            wybor = Dzialania.odejmuje;
            Nazwa = WynikTextBlock.Text;
            WynikTextBlock.Text = "";
        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            if (wybor == Dzialania.dodaje)
            {
                int cok = Int32.Parse(Nazwa) + Int32.Parse(WynikTextBlock.Text);
                WynikTextBlock.Text = cok.ToString();
            }
            if (wybor == Dzialania.odejmuje)
            {
                int cok = Int32.Parse(Nazwa) - Int32.Parse(WynikTextBlock.Text);
                WynikTextBlock.Text = cok.ToString();
            }

        }

        private void NumberZero_Click(object sender, RoutedEventArgs e)
        {
            string AktualnyWynik = WynikTextBlock.Text;
            string NowyWynik = AktualnyWynik + "0";
            WynikTextBlock.Text = NowyWynik;
        }
    }
}
