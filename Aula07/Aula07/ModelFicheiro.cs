using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Aula07
{
    //Alterar a classe para public
    public class ModelFicheiro
    {
        //Estado da aplicação
        public string Texto { get; private set; }

        //Declarações dos events (2º passo)
        public event MetodosSemParametros LeituraTerminada;
        public event MetodosSemParametros EscritaTerminada;

        //Método invocado pela View (Camada de Apresentação)
        public void AbrirFicheiro(string fich)
        {
            StreamReader sr = new StreamReader(fich);
            Texto = sr.ReadToEnd();
            sr.Close();  

            //Notificação de alteração de estado
            //Lançamento do event (3º passo)
            if(LeituraTerminada != null)
                LeituraTerminada();
        }

        public void GuardarFicheiro(string fich, string conteudo)
        {
            StreamWriter sw = new StreamWriter(fich);
            sw.Write(conteudo);
            sw.Close();

            //Notificação de alteração de estado
            if(EscritaTerminada != null)
                EscritaTerminada();
           
        }
    }
}
