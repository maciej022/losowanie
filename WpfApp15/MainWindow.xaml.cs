using System.Security.Cryptography.X509Certificates;
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

namespace WpfApp15
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
     
        private void zatwierdzbtn_Click(object sender, RoutedEventArgs e)
        {
            int dlugosc;
            if (!int.TryParse(ileznakowtxt.Text, out dlugosc))
            {
                MessageBox.Show("Podaj dlugosc");
                return;
            }
            string litery = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            string liczby = "1234567890";
            string specjalne = "!@#$%^&*()-_+";
            List<char> list = new List<char>();
            if (literycheck.IsChecked == true)
            {
                list.AddRange(litery);
            }
            if (znakicheck.IsChecked == true)
            {
                list.AddRange(specjalne);
            }
            if (cyfrycheck.IsChecked == true)
            {
                list.AddRange(liczby);
            }
            if (list.Count == 0)
            {
                MessageBox.Show("Wybierz conajmiej 1 opcje");
                return;
            }
            Random losuj = new Random();
            string haslo = "";
            for(int i=0; i<dlugosc; i++)
            {
                haslo += list[losuj.Next(list.Count)];
               
            }
            MessageBox.Show(haslo);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         //   MessageBox.Show(imietext.Text.ToString || nazwiskotxt.Text.ToString);
            string imie=imietext.Text;
            string nazwisko=nazwiskotxt.Text;
            string? stanowisko=(combobox.SelectedItem as ComboBoxItem)?.Content.ToString();
            MessageBox.Show($"Dane Pracownika:Imie:{imie} Nazwisko:{nazwisko} Stanowisko{stanowisko}");

        }
    }
}