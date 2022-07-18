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

namespace Aula06
{
    /// <summary>
    /// Interaction logic for WindowListarNotas.xaml
    /// </summary>
    public partial class WindowListarNotas : Window
    {
        //Apontador para a classe App
        private App app;
        public WindowListarNotas()
        {
            InitializeComponent();

            //Obtém instância da classe App
            app = App.Current as App;

            //Subscrição do método da View no Event do Model
            app.Model_Avaliacoes.Inserido += Model_Avaliacoes_Inserido;
        }

        private void Model_Avaliacoes_Inserido(int dados)
        {
            //Atualiza a interface gráfica (View) com o novo estado da aplicação
            lbNotas.Items.Add(dados + " Valores ");
        }
    }
}
