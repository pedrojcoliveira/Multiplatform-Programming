using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06
{
    //1º PASSO: Declaração do Delegate
    public delegate void MetodosComInt(int dados); 

    public class ModelAvaliacoes
    {
        //Estrutura de dados com o histórico das notas
        public List<int> ListaNotas { get; private set; }

        //2º PASSO: Criar Event associado ao Delegate
        public event MetodosComInt Inserido;

        public ModelAvaliacoes()
        {
            //Incialização da estrutura de dados
            ListaNotas = new List<int>();
        }
        public void Inserir(string nota)
        {
            //Manipulação de dados
            int valor = Convert.ToInt16(Math.Round(Convert.ToDouble(nota), MidpointRounding.AwayFromZero)); 

            //Armazenamento de dados
            ListaNotas.Add(valor);

            //Lançar event
            if (Inserido != null)
                Inserido(valor);
        }
    }
}
