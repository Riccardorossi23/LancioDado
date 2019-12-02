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

namespace LancioDado
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int da = 1;
            int a = 7;
            Random random = new Random();
            int numeroCasuale = random.Next(da, a);
            int numero = int.Parse(txtRandom.Text);
            if (numero == numeroCasuale)
            {
                txtVinto.Text = r + " Complimenti, hai vinto!";
            }
            else
            {
               txtVinto.Text = r + "  Ritenta, sarai più fortunato";
            }
            if(numeroCasuale> 1||numeroCasuale<0)
            {
                MessageBox.Show("Inserisci un numero da 1 a 6", "Numero non corretto", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btn_Ritenta(object sender, RoutedEventArgs e)
        {
            txtVinto.Clear();
            txtRandom.Clear();
        }

    }
}

            


         
        }
    }
}
