using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Aula_09
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Models
        public ModelEscola M_Escola { get; private set; }

        public App()
        {
            //Inicialização dos objetos Model
            M_Escola = new ModelEscola();
        }
    }
}
