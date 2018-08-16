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

namespace PracticaLineas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            plnLinea2.Stroke =
                    new SolidColorBrush(Color.FromRgb(255, 180, 5));

            for (float i=0; i<=360; i++)
            {
                plnLinea2.Points.Add(new Point(Math.Cos(i) * 50 + 100, 
                    Math.Sin(i) * 50 + 100));
            }
        }
    }
}
