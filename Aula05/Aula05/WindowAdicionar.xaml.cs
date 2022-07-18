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
using System.Windows.Shapes;

namespace Aula05
{
    /// <summary>
    /// Interaction logic for WindowAdicionar.xaml
    /// </summary>
    public partial class WindowAdicionar : Window
    {
        public Figura NovaFigura { get; private set; }
        public WindowAdicionar()
        {
            InitializeComponent();

            NovaFigura = new Figura();
        }

        private void btnInserir_Click(object sender, RoutedEventArgs e)
        {
            NovaFigura.Largura = tbLargura.Text;
            NovaFigura.Altura = tbAltura.Text;

            if (rbQuadrado.IsChecked == true)
                NovaFigura.Nome = "Quadrado";
            else if (rbRetangulo.IsChecked == true)
                NovaFigura.Nome = "Quadrado";
            else
                NovaFigura.Nome = "Circulo";

            //Fecha Janela
            this.DialogResult = true;
        }
    }
}
