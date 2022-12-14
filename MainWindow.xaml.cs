using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        int tempo = 0;
        Task task;
        CancellationToken cancellationToken;
        CancellationTokenSource tokenSource;

        private void IniciarTaskContagem()
        {
            tokenSource = new CancellationTokenSource();
            cancellationToken = tokenSource.Token;
            task = IniciarContagem(tokenSource.Token);
        }

        private async Task IniciarContagem(CancellationToken token)
        {
            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (cancellationToken.IsCancellationRequested)
                {
                    cancellationToken.ThrowIfCancellationRequested();
                }
                await Task.Delay(1000);

                tempo++;

            }
        }
        
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
            tempo = 0;
            
        }

        private void marmota2_click(object sender, MouseButtonEventArgs e)
        {
            marmota2.Visibility = Visibility.Hidden;
            numeros += 1;
            contador.Text = numeros.ToString();
            AparecerMarmota();
            tempo = 0;
        }

        private void marmota3_click(object sender, MouseButtonEventArgs e)
        {
            marmota3.Visibility = Visibility.Hidden;
            numeros += 1;
            contador.Text = numeros.ToString();
            AparecerMarmota();
            tempo = 0;
        }

        private void marmota4_click(object sender, MouseButtonEventArgs e)
        {
            marmota4.Visibility = Visibility.Hidden;
            numeros += 1;
            contador.Text = numeros.ToString();
            AparecerMarmota();
            tempo = 0;
        }

        private void marmota5_click(object sender, MouseButtonEventArgs e)
        {
            marmota5.Visibility = Visibility.Hidden;
            numeros += 1;
            contador.Text = numeros.ToString();
            AparecerMarmota();
            tempo = 0;
        }
        private void Temporizador()
        {
                if (tempo == 2)
                {
                    marmota1.Visibility = Visibility.Hidden;
                    marmota2.Visibility = Visibility.Hidden;
                    marmota3.Visibility = Visibility.Hidden;
                    marmota4.Visibility = Visibility.Hidden;
                    marmota5.Visibility = Visibility.Hidden;
                    AparecerMarmota();
                    tempo = 0;
            }
        }
        private void click_jogar(object sender, RoutedEventArgs e)
        {
            btn_jogar.Visibility = Visibility.Hidden;
            AparecerMarmota();
            IniciarTaskContagem();
            Temporizador();
        }
    }
}
