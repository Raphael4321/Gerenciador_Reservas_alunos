using System;
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

        public void savePl(Plano plano)
        {
            // Salvando novo plano com os dados fornecidos
            if (plano.Id > 0)
            {
                rep.updatePL(plano);
            }
            else
            {
                rep.savePl(plano);
            }
            
        }

        public DataTable ListarPlanos(string dado)
        {
            return rep.ListarPlanos(dado);

        }

        public Plano SelectPlano(string id)
        {
            return rep.SelectPlano(id);
        }

        public Double SelecionadoValor(String id)
        {
            return rep.SelecionadoValor(id);
        }

        public void deletarPL(int id)
        {
            AgendamentoController age = new();

            bool agendamentosUtilizamPlano = age.VerificarAgendamentosPorPlano(id);

            if (agendamentosUtilizamPlano)
            {
                MessageBox.Show("Enquanto um almoço agendado estiver usando este plano, ele não pode ser excluido");
            }
            else
            {
                rep.deletarPL(id);
            }

        }
    }
}
