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

namespace WPFConversor
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String centi = Centi.Text;
            String faren = Faren.Text;

            if(centi != "" || faren != "")
            {
                if(centi != "")
                {
                    int fareng = (Int16.Parse(centi) * 9 / 5) + 32;
                    Faren.Text = fareng.ToString();
                    Centi.Text = "";
                }
                else
                {
                    int centig = ((Int16.Parse(faren) - 32)  *  5/9);
                    Centi.Text = centig.ToString();
                    Faren.Text = "";
                }
            }
        }


    }
}
