using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08
{
    public class ModelTexto
    {
        //Propriedade que representa a Lista de texto (Estado da aplicalão)
        public List<string> Lista { get; private set; }

        //Declaração de event para notificação de alteração de estado da aplicação
        public event MetodosComString TextoValidado;

        public ModelTexto()
        {
            Lista= new List<string>();
        }

        public void ValidarTexto(string texto)
        {
            if (texto.Length > 0 && texto.Length <= 5)
            {
                texto = texto.ToUpper(); //Para meter em maíuscula

                //Armazenamento do texto válido (Atualização dos estado da aplicação)
                Lista.Add(texto);

                //Lançamento do evento (Notificação da View da alteração de estado da aplicação)
                if(TextoValidado != null)
                    TextoValidado(texto);
            }
            else
            {
                //Exemplo de erro de manipulação de dados
                //Convert.ToInt16(texto);
                //throw new ArgumentOutOfRangeException();
                //throw new ArgumentOutOfRangeException("", "Texto inválido! [1-5] caracteres!");
                //throw new TextoInvalidoException();
                throw new TextoInvalidoException("Texto Inválido! [1-5] caracteres!");
            }
        }
    }
}
