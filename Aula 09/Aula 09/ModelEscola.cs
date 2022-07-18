using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Aula_09
{
    public class ModelEscola : IEnumerable
    {
        //Propriedade que representa nome da Escola
        public string Escola { get; set; }

        //Propriedade eque representa nome da Escola
        //public List<Departamento> Departamentos { get; private set;}
        public List<Departamento> Departamentos;

        //Declaração de event (notificação da view) associação do delegate
        public event MetodosSemParametros InicializacaoTerminada;

        public ModelEscola()
        {
            //Inicialização da lista de departamentos
            Departamentos = new List<Departamento>();
        }
        public void Inicializar()
        {
            //Similar leitura de dados de uma fonte de dados
            Escola = "Ciências e Tecnologia";

            Departamentos.Add(new Departamento("Engenharias", "150"));
            Departamentos.Add(new Departamento("Física", "30"));
            Departamentos.Add(new Departamento("Matemática", "60"));

            //Lancamento do event (notificação)
            if(InicializacaoTerminada != null)
                InicializacaoTerminada();
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Departamentos.Count; i++)
                yield return Departamentos[i];
        }

        public string ObterDocentes (int index) //Escolha do Departamento
        {
            return Departamentos[index].NDocentes;

        }
    }
}
