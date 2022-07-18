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

namespace Aula05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List <Figura> Lista { get; private set; }
        public MainWindow()
        {
            InitializeComponent();

            Lista = new List<Figura>(); 
        }

        private void FigurasAdicionar_Click(object sender, RoutedEventArgs e)
        {
            WindowAdicionar dlg = new WindowAdicionar();

           if (dlg.ShowDialog() == true)
            {
                lbFiguras.Items.Add(dlg.NovaFigura.Nome);
                Lista.Add(dlg.NovaFigura);
            }
        }

        private void lbFiguras_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string largura = Lista[lbFiguras.SelectedIndex].Largura;
            string altura = Lista[lbFiguras.SelectedIndex].Altura;

            sbiFiguras.Content = "Largura= " + largura + "Altura = " + altura;

                
        }
    }
}
