using Sistema_almoço_alunos.src.Entities;
using System.Data;
using Sistema_almoço_alunos.src.Repository;
using System;

namespace Sistema_almoço_alunos.src.Services
{
    internal class AlunoService
    {
        AlunoRepository rep = new();

        // salvar aluno
        public bool SalvarAluno(Aluno aluno)
        {
            // Verifica se o nome do aluno e os dados da turma estão preenchidos
            if (string.IsNullOrEmpty(aluno.Nome) || string.IsNullOrEmpty(aluno.Turma))
            {
                throw new ArgumentException("Por favor, preencha o nome e a turma do aluno antes de salvar.");
            }

            //se for encontrado Um Id maior que 0 no aluno, então ele ja existe e se trata de uma edição
            if (aluno.Id > 0)
            {
                return rep.AtualizarAluno(aluno);
            }
            // Caso contrario, trata-se de um novo aluno que será salvo no banco de dados
            else
            {
                return rep.SalvarAluno(aluno);
            }
        }


        public DataTable ListarAlunos(string dado, string filtro, int ativo)
        {
            return rep.listAlunos(dado, filtro, ativo);
        }

        public void InativarAluno(Aluno aluno)
        {
            // Verifica se o objeto aluno é nulo.
            if (aluno is null)
            {
                throw new ArgumentNullException(nameof(aluno), "O objeto aluno não pode ser nulo.");
            }

            // Chama o método para inativar o aluno no repositório.
            rep.InativarAluno(aluno);
        }


    }
}
