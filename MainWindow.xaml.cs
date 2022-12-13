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

namespace Jogo_da_Marmota
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
        int escolhaComputador;
        int numeros = 0;
        List<int> aparecerMarmotas = new List<int>() { 1, 2, 3, 4, 5};

        public void AparecerMarmota()
        {
            var rnd = new Random();
            escolhaComputador = aparecerMarmotas[rnd.Next(aparecerMarmotas.Count)];

            if (escolhaComputador == 1)
            {
                marmota1.Visibility = Visibility.Visible;
            }
            if (escolhaComputador == 2)
            {
                marmota2.Visibility = Visibility.Visible;
            }
            if (escolhaComputador == 3)
            {
                marmota3.Visibility = Visibility.Visible;
            }
            if (escolhaComputador == 4)
            {
                marmota4.Visibility = Visibility.Visible;
            }
            if (escolhaComputador == 5)
            {
                marmota5.Visibility = Visibility.Visible;
            }
        }
        private void marmota1_click(object sender, MouseButtonEventArgs e)
        {
            marmota1.Visibility = Visibility.Hidden;
            numeros += 1;
            contador.Text = numeros.ToString();
            AparecerMarmota();
        }

        private void marmota2_click(object sender, MouseButtonEventArgs e)
        {
            marmota2.Visibility = Visibility.Hidden;
            numeros += 1;
            contador.Text = numeros.ToString();
            AparecerMarmota();
        }

        private void marmota3_click(object sender, MouseButtonEventArgs e)
        {
            marmota3.Visibility = Visibility.Hidden;
            numeros += 1;
            contador.Text = numeros.ToString();
            AparecerMarmota();
        }

        private void marmota4_click(object sender, MouseButtonEventArgs e)
        {
            marmota4.Visibility = Visibility.Hidden;
            numeros += 1;
            contador.Text = numeros.ToString();
            AparecerMarmota();
        }

        private void marmota5_click(object sender, MouseButtonEventArgs e)
        {
            marmota5.Visibility = Visibility.Hidden;
            numeros += 1;
            contador.Text = numeros.ToString();
            AparecerMarmota();
        }

    }
}
