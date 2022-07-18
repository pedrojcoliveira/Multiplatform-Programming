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
    /// Interaction logic for WiindowListaAvaliacoes.xaml
    /// </summary>
    public partial class WiindowListaAvaliacoes : Window
    {
        //Apontador para classe App
        private App app;
        public WiindowListaAvaliacoes()
        {
            InitializeComponent();

            //Obtém instância para a classe App
            app = App.Current as App;

            //Subscrição de método da View no Event do Model
            app.Model_Avaliacoes.Inserido += Model_Avaliacoes_Inserido;
        }

        private void Model_Avaliacoes_Inserido(int dados)
        {
            if(dados >= 10)
            {
                lvAvaliacoes.Items.Add("Aprovado (" + dados + ")");
            }
            else
            {
                lvAvaliacoes.Items.Add("Reprovado (" + dados + ")");
            }
        }
    }
}
