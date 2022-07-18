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

using Microsoft.Win32;

namespace Aula07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Variável que representa acesso à camada de "Interligação" (App)
        private App app;
        public MainWindow()
        {
            InitializeComponent();

            //Instância da camada de "Interligação" (App)
            app = App.Current as App;

            //Subscrição de método da View em event do Model
            app.Model_Ficheiro.LeituraTerminada += Model_Ficheiro_LeituraTerminada;
            app.Model_Ficheiro.EscritaTerminada += Model_Ficheiro_EscritaTerminada;
        }

        private void Model_Ficheiro_EscritaTerminada()
        {
            MessageBox.Show("Ficheiro guardado com sucesso!");
        }

        private void Model_Ficheiro_LeituraTerminada()
        {
            tbFicheiro.Text = app.Model_Ficheiro.Texto;
        }

        private void btnAbrir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Ficheiros de texto|*.txt|Todos os ficheiros|*.*";

            if (dlg.ShowDialog() == true)
            {
                //Ligação View->Model (Invocação de método do Model)
                app.Model_Ficheiro.AbrirFicheiro(dlg.FileName);
            }
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Ficheiros de texto|*.txt|Todos os ficheiros|*.*";
            if (dlg.ShowDialog() == true)
            {
                //Ligação View->Model (Invocação de método do Model)
                app.Model_Ficheiro.GuardarFicheiro(dlg.FileName, tbFicheiro.Text);
            }
        }
    }
}
