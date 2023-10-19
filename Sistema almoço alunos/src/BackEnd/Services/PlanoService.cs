using System.Data;
using System.Windows.Forms;
using Sistema_almoço_alunos.src.Entities;
using Sistema_almoço_alunos.src.Repository;
using Sistema_almoço_alunos.src.Controllers;

namespace Sistema_almoço_alunos.src.Services
{
    internal class PlanoService
    {
        PlanoRepository rep = new();

        // Método para salvar um plano
        public void SavePl(Plano plano)
        {
            // Salvando novo plano com os dados fornecidos
            if (plano.Id > 0)
            {
                rep.updatePL (plano);
            }
            else
            {
                rep.savePl(plano);
            }
        }

        // Método para listar os planos com base em um dado
        public DataTable ListarPlanos(string dado)
        {
            return rep.ListarPlanos(dado);
        }

        // Método para selecionar um plano pelo ID
        public Plano SelectPlano(string id)
        {
            return rep.SelectPlano(id);
        }

        // Método para selecionar o valor de um plano pelo ID
        public double SelecionadoValor(string id)
        {
            return rep.SelecionadoValor(id);
        }

        // Método para deletar um plano pelo ID
        public void DeletarPl(int id)
        {
            AgendamentoController age = new AgendamentoController();

            // Verifica se existem agendamentos que utilizam o plano
            bool agendamentosUtilizamPlano = age.VerificarPlanoEmUso(id);

            if (agendamentosUtilizamPlano)
            {
                MessageBox.Show("Enquanto um almoço agendado estiver usando este plano, ele não pode ser excluído");
            }
            else
            {
                rep.deletarPL(id);
            }
        }

    }
}
