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
            string specjalne="!@#$%^&*()-_+"
            List<char> list = new List<char>();
        }
    }
}