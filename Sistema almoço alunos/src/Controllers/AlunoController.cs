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
            // Verifica se o objeto aluno é nulo.
            if (aluno is null)
            {
                throw new ArgumentNullException(nameof(aluno), "O objeto aluno não pode ser nulo.");
            }

            // Verifica se o aluno já está inativo.
            if (aluno.Status == 0)
            {
                MessageBox.Show("O aluno já está inativo!");
                return;
            }

            // Pergunta ao usuário se deseja realmente inativar o aluno.
            DialogResult dialogResult = MessageBox.Show($"Tem certeza que deseja inativar o aluno {aluno.Nome}?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            // Chama o método para inativar o aluno no banco de dados.
            service.InativarAluno(aluno);

            MessageBox.Show("Aluno inativado com sucesso!");
        }


    }
}
