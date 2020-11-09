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

namespace pierwiastek__przyblizenie
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int liczba_w = 0;
            int licznik = 0;
            int dzielnik=0;
            Int32.TryParse(Textbox1.Text, out liczba_w);
            int pomocnicza = 0;
            float pomocnicza1;
            pomocnicza = liczba_w;
            pomocnicza1 = liczba_w;
            Label3.Content = slider.Value;
            while (liczba_w > 0)
            {
                liczba_w /= 10;
                licznik++;

            }
            int n = 0;
            for (int i = 1; i <= pomocnicza; i++)
            {
                if (pomocnicza % i == 0 && n < 1 && i != 1)
                {
                    dzielnik = i;
                    n++;

                }
            }

            float x0;
            
            double e1 = 0.001;
            double z, xn, xnn = 0,s, modul;
            z = Math.Pow(10.0, dzielnik);
            x0 = (float)(licznik * z);

            float ulamek;
            int co = 0;
            xn = x0;
           
           
            do
            {

                xnn = (xn + (pomocnicza1 / xn)) / (2);

                s = Math.Pow(xnn, 2.0);
                
                modul = Math.Abs(s - pomocnicza1);
                co++;
                Label2.Content = Math.Round(xnn, (int)slider.Value);
                xn = xnn;
            } while (modul > e1);


            



            
           

        }
    }
}
