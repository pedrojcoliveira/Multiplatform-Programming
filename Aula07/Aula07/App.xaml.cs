using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Aula07
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>

    //Camada de "Interligação"
    public partial class App : Application
    {
        //Camada Lógica
        public ModelFicheiro Model_Ficheiro { get; private set; }   

        //Construtor da camada de "Interligação"

        public App()
        {
            //Instanciação dos Models
            Model_Ficheiro = new ModelFicheiro();   
        }
    }
}
