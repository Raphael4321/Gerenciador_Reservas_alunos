using System.Data;
using System.Windows.Forms;
using Sistema_almoço_alunos.src.Services;
using Sistema_almoço_alunos.src.Entities;
using System;

namespace Sistema_almoço_alunos.src.Controllers
{
    internal class AlunoController
    {
        AlunoService stu = new();

        public DataTable ListarAlunos(string dado, string filtro)
        {
            // Executar a função que lista alunos
            return stu.ListarAlunos(dado, filtro);
        }

        public void SalvarAluno(Aluno aluno)
        {
            // Verificar se o objeto aluno é nulo
            if (aluno is null)
            {
                throw new ArgumentNullException(nameof(aluno), "O objeto aluno não pode ser nulo.");
            }

            if (stu.SalvarAluno(aluno))
            {
                MessageBox.Show("Aluno salvo com sucesso!");
            }
        }

        public void DeletarAluno(Aluno aluno)
        {
            // Verificar se o objeto aluno é nulo
            if (aluno is null)
            {
                throw new ArgumentNullException(nameof(aluno), "O objeto aluno não pode ser nulo.");
            }

            // Avisando usuário da exclusão dos dados
            DialogResult confirm = MessageBox.Show("Excluir o aluno também excluirá seus agendamentos. Deseja continuar?", "Excluir Aluno", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            // Proceder se usuário permitir
            if (confirm == DialogResult.Yes)
            {
                AgendamentoService age = new();
                age.DelTodosAgendamentos(aluno.Id);
                stu.DeletarAluno(aluno);
            }
        }

        public void InativarAluno(Aluno aluno)
        {
            // Verificar se o objeto aluno é nulo
            if (aluno is null)
            {
                throw new ArgumentNullException(nameof(aluno), "O objeto aluno não pode ser nulo.");
            }

            // Verifica se o aluno já está inativo
            if (!aluno.ativo)
            {
                MessageBox.Show("O aluno já está inativo!");
                return;
            }

            // Pergunta ao usuário se realmente deseja inativar o aluno
            DialogResult dialogResult = MessageBox.Show($"Tem certeza que deseja inativar o aluno {aluno.Nome}?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            // Chama o método para mudar o estado do aluno para inativo
            stu.InativarAluno(aluno);

            MessageBox.Show("Aluno inativado com sucesso!");
        }

    }
}
