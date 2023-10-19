using Sistema_almoço_alunos.src.Entities;
using Sistema_almoço_alunos.src.Services;
using System.Data;

namespace Sistema_almoço_alunos.src.Controllers
{
    internal class TurmaController
    {
        // Cria uma instância da classe TurmaService
        TurmaService service = new TurmaService();

        // Chama o método da classe TurmaService para salvar uma turma
        public int SalvarTurma(Turma turma)
        {
            return service.SalvarTurma(turma);
        }

        // Chama o método da classe TurmaService para listar todas as turmas
        public DataTable ListarTurmas()
        {
            return service.ListarTurmas();
        }

        public Turma SelecionarTurma(int turma)
        {
            return service.SelecionarTurma(turma);
        }

        public void ExcluirTurmaSemAluno()
        {
            service.ExcluirTurmaSemAluno();
        }
    }

}

