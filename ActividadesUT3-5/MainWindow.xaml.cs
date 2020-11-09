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

namespace ActividadesUT3_5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           // Grid contenedor = gridcalc;
            TextBlock ddawda = new TextBlock
            {
                Text = "0",
            };
            Viewbox dada = new Viewbox();
            Button uno = new Button
            {
                Tag = "0",
                
                             
            };
            contenedor.children.Add(uno);
            Grid.SetRow(uno, 1); Grid.SetColumn(uno, 1);
            //creo el textblock objeto, new textblock y text
            //creo el viewbox que tiene .child que será el textblock
            //metemos el viewbox en el content del boton ej: button1.content = nombreviewbox;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resultadoTextBlock.Text = resultadoTextBlock.Text + (sender as Button).Tag.ToString();
            //Si del sender cogemos el content, casteamos viewbox(cogemos child) > label
        }
    }
}
