using System;
using System.Data;
using Sistema_almoço_alunos.src.Entities;
using Sistema_almoço_alunos.src.Services;

namespace Sistema_almoço_alunos.src.Controllers
{
    internal class PlanoController
    {
        PlanoService servico = new PlanoService();

        // Retorna uma tabela com os planos cadastrados
        public DataTable ListaPlanos(string dado)
        {
            return servico.ListarPlanos(dado);
        }

        // Salva um novo plano
        public void salvar(Plano plano)
        {
            // Verifica se o objeto plano é nulo
            if (plano == null)
                throw new ArgumentNullException(nameof(plano), "O objeto plano não pode ser nulo.");

            // Chama o método da classe PlanoService para salvar o plano
            servico.savePl(plano);
        }

        // Retorna um plano com base em seu ID
        public Plano Selectplano(string id)
        {
            // Verifica se o ID é nulo ou vazio
            if (string.IsNullOrEmpty(id))
                throw new ArgumentException("O parâmetro 'id' não pode ser nulo ou vazio.");

            // Chama o método da classe PlanoService para obter o plano correspondente
            return servico.SelectPlano(id);
        }

        // Deleta um plano com base em seu ID
        public void deletarPlano(int id)
        {
            // Verifica se o ID é um valor positivo
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "O parâmetro 'id' deve ser um valor positivo.");

            // Chama o método da classe PlanoService para deletar o plano correspondente
            servico.deletarPL(id);
        }

    }
}
