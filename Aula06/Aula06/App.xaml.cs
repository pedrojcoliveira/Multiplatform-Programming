using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Aula06
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Views
        public WindowListarNotas View_ListarNotas { get; private set; }
        public WiindowListaAvaliacoes View_ListaAvaliacoes { get; private set; }

        //Models
        public ModelAvaliacoes Model_Avaliacoes { get; private set; }

        public App()
        {
            //Models antes das Views


            //Instanciação dos Models
            Model_Avaliacoes = new ModelAvaliacoes();

            //Instanciação das Views
            View_ListarNotas = new WindowListarNotas();
            View_ListaAvaliacoes = new WiindowListaAvaliacoes();
        }
    }
}
