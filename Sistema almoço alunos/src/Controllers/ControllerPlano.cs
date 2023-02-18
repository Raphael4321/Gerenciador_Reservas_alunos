using System.Data;
using Sistema_almoço_alunos.src.Entities;
using Sistema_almoço_alunos.src.Services;
using System.Windows.Forms;

namespace Sistema_almoço_alunos.src.Controllers
{
    internal class ControllerPlano
    {

        ServicePl servico = new();

        public DataTable ListaPlanos()
        {
           
            // preenchendo a tabela com os dados no banco
            DataTable consulta = servico.ListaPlanos();

            return consulta;

        }

        public void salvar(Plano plano)
        {
            // Salvando novo plano com os dados fornecidos
            if(plano.getid() > 0)
            {
                servico.updatePL(plano);
            }
            else
            {
                servico.savePl(plano);
            }

        }

        public Plano Selectplano(string id)
        {
            Plano plano = servico.SelectPlano(id);

            return plano;
        }

        public void deletarPlano(int id)
        {
            ControllerAge age = new();

            int verificacao = age.Verificar_Agendamentos_por_plano(id);

            switch (verificacao)
            {

                case 0:

                    servico.deletarPL(id, verificacao);

                    break;

                case 1:

                    MessageBox.Show("Enquanto um almoço agendado estiver usando este plano, ele não pode ser excluido");

                    break;

                case 2:

                    MessageBox.Show("Houve algum erro!!");

                    break;

            }

            
        }
    }
}
