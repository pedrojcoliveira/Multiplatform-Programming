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

namespace Aula_09
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Variável que representa apontador para App (Camada de Interligação)
        private App app;
        public MainWindow()
        {
            InitializeComponent();

            //Obtenção do apontador para classe App (Camada de Interligação)
            app = App.Current as App;

            //subscrição de método da view em event do Model
            app.M_Escola.InicializacaoTerminada += M_Escola_InicializacaoTerminada;
        }

        private void M_Escola_InicializacaoTerminada()
        {
            tbEscola.Text = app.M_Escola.Escola;

            //foreach (Departamento dep in app.M_Escola.Departamentos)
            foreach (Departamento dep in app.M_Escola)
            {
                cbDepartamento.Items.Add(dep.Designacao);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Invocação de método do Model por parte da View
            //Pedido alteração estado da aplicação (carregar dados do MODEL)
            app.M_Escola.Inicializar();
        }

        private void cbDepartamento_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Invocação de método do Model por parte da View
            //Pedido de docentes de determinado departamento selecionado pelo utilizador
            sbiNDocentes.Content =  "NºDocentes: " + app.M_Escola.ObterDocentes(cbDepartamento.SelectedIndex);
        }
    }
}
