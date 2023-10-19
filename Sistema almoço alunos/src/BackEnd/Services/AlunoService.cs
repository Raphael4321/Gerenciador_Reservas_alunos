using Sistema_almoço_alunos.src.Entities;
using System.Data;
using Sistema_almoço_alunos.src.Repository;
using System;

namespace Sistema_almoço_alunos.src.Services
{
    internal class AlunoService
    {
        AlunoRepository rep = new();

        // Método que salva um aluno no banco de dados
        public bool SalvarAluno(Aluno aluno)
        {
            // Verifica se o nome do aluno e os dados da turma estão preenchidos
            if (string.IsNullOrEmpty(aluno.Nome) || string.IsNullOrEmpty(aluno.Turma))
            {
                throw new ArgumentException("Por favor, preencha o nome e a turma do aluno antes de salvar.");
            }

            // Se o aluno possui um ID maior que 0, significa que já existe e é uma edição
            if (aluno.Id > 0)
            {
                return rep.AtualizarAluno(aluno);
            }
            // Caso contrário, é um novo aluno a ser salvo no banco de dados
            else
            {
                return rep.SalvarAluno(aluno);
            }
        }

        // Método que lista os alunos com base em um dado, filtro de pesquisa e status ativo/inativo
        public DataTable ListarAlunos(string dado, string filtro, int ativo)
        {
            return rep.ListarAlunos(dado, filtro, ativo);
        }

        // Método que inativa um aluno no banco de dados
        public void InativarAluno(Aluno aluno)
        {
            // Verifica se o objeto aluno é nulo
            if (aluno is null)
            {
                throw new ArgumentNullException(nameof(aluno), "O objeto aluno não pode ser nulo.");
            }

            // Chama o método para inativar o aluno no repositório
            rep.InativarAluno(aluno);
        }

        // Método que inativa um aluno no banco de dados
        public void AtivarAluno(Aluno aluno)
        {
            // Verifica se o objeto aluno é nulo
            if (aluno is null)
            {
                throw new ArgumentNullException(nameof(aluno), "O objeto aluno não pode ser nulo.");
            }

            // Chama o método para inativar o aluno no repositório
            rep.AtivarAluno(aluno);
        }

        public void DeletarAluno(Aluno aluno)
        {
            // Verifica se o objeto aluno é nulo
            if (aluno is null)
            {
                throw new ArgumentNullException(nameof(aluno), "O objeto aluno não pode ser nulo.");
            }

            AgendamentoRepository age = new AgendamentoRepository();
            // Deleta todos os agendamentos referentes ao aluno.
            age.DeletarAgendamentosPorAluno(aluno.Id);

            // Chama o método para deletar o aluno no repositório
            rep.DeletarAluno(aluno);
        }

    }
}
