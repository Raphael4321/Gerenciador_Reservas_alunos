using Sistema_almoço_alunos.src.Entities;
using System.Data;
using Sistema_almoço_alunos.src.Repository;

namespace Sistema_almoço_alunos.src.Services
{
    internal class AlunoService
    {
        AlunoRepository rep = new();

        // salvar aluno
        public bool SalvarAluno(Aluno aluno)
        {
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

        public DataTable ListarAlunos(string text, string filtro)
        {
            return rep.listAlunos(text, filtro); ;
        }

        public void DeletarAluno(Aluno aluno)
        {
            rep.DelAluno(aluno);
        }

        public void InativarAluno(Aluno aluno)
        {
            rep.InativarAluno(aluno);
        }
    }
}
