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
            
            Random random = new Random();
            int numeroCasuale = random.Next(1, 7);
            string numero = numeroCasuale.ToString();
            int valore = int.Parse(txtNumero.Text);
            if (valore == numeroCasuale)
            {
                txtRandom.Text =  numero + " Congratulazioni hai vinto!";
            }
            else
            {
               txtRandom.Text = numero +  " che sfortuna hai perso";
            }
            if(valore< 1||valore>6)
            {
                MessageBox.Show("Inserisci un numero da 1 a 6", "Numero non corretto", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void btnRitenta_Click(object sender, RoutedEventArgs e)
        {
            txtRandom.Clear();
            txtNumero.Clear();
        }
    }
}

            


         