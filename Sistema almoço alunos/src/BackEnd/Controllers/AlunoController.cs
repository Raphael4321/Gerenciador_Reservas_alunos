using System.Data;
using System.Windows.Forms;
using Sistema_almoço_alunos.src.Services;
using Sistema_almoço_alunos.src.Entities;
using System;

namespace Sistema_almoço_alunos.src.Controllers
{
    public class AlunoController
    {
        AlunoService service = new();

        // Lista os alunos com base no filtro passado como parâmetro.
        public DataTable ListarAlunos(string dado, string filtro, int ativo)
        {
            // Chama o método responsável por listar os alunos.
            return service.ListarAlunos(dado, filtro, ativo);
        }

        // Salva um objeto Aluno no banco de dados.
        public bool SalvarAluno(Aluno aluno)
        {
            // Chama o método responsável por salvar o aluno.
            service.SalvarAluno(aluno);

            // Exibe uma mensagem de sucesso.
            MessageBox.Show("Aluno salvo com sucesso!");

            return true;
        }

        // Inativa um objeto Aluno no banco de dados.
        public void InativarAluno(Aluno aluno)
        {

            // Chama o método para inativar o aluno no banco de dados.
            service.InativarAluno(aluno);

            MessageBox.Show("Aluno inativado com sucesso!");
        }

        // Método que Ativa um aluno no banco de dados
        public void AtivarAluno(Aluno aluno)
        {
            // Verifica se o objeto aluno é nulo
            if (aluno is null)
            {
                throw new ArgumentNullException(nameof(aluno), "O objeto aluno não pode ser nulo.");
            }

            // Chama o método para inativar o aluno no repositório
            service.AtivarAluno(aluno);
        }

        // Deleta um objeto Aluno no banco de dados.
        public void DeletarAluno(Aluno aluno)
        {

            // Chama o método para inativar o aluno no banco de dados.
            service.DeletarAluno(aluno);

            MessageBox.Show("Aluno Deletado com sucesso!");


        }

    }
}
