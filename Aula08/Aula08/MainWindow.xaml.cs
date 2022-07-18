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

namespace Aula08
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Variável que representa apontador para App
        private App app;
        public MainWindow()
        {
            InitializeComponent();

            //Obter o apontador (instância) da classe App (Camada de Interligação)
            app = App.Current as App;  //Cast (Ver Isto em casa)

            //Subscrição de método da View em event do Model
            app.M_Texto.TextoValidado += M_Texto_TextoValidado;
        }

        private void M_Texto_TextoValidado(string texto)
        {
            //Atualização do estado da aplicação na View
            lbTexto.Items.Add(texto);
        }

        private void btnValidar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Invocação do método do Model
                app.M_Texto.ValidarTexto(tbTexto.Text);
            }
           /* catch(FormatException erro)
            {
                //MessageBox.Show("O Texto é Inválido");
               MessageBox.Show(erro.Message);
            }
           */
            /* catch(ArgumentOutOfRangeException erro)
            {
                MessageBox.Show(erro.Message);
            } 
            */
            catch (TextoInvalidoException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        

    }
}
