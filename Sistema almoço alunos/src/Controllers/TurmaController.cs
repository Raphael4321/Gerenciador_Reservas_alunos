using Sistema_almoço_alunos.src.Entities;
using Sistema_almoço_alunos.src.Services;
using System.Data;
using System.Windows.Forms;

namespace Sistema_almoço_alunos.src.Controllers
{
    internal class TurmaController
    {
        // Cria uma instância da classe TurmaService
        TurmaService service = new TurmaService();

        // Chama o método da classe TurmaService para salvar uma turma
        public void SalvarTurma(Turma turma)
        {
            service.SalvarTurma(turma);
        }

        // Chama o método da classe TurmaService para excluir uma turma
        public void ExcluirTurma(Turma turma)
        {
            service.ExcluirTurma(turma);
        }

        // Chama o método da classe TurmaService para listar todas as turmas
        public DataTable ListarTurmas()
        {
            return service.ListarTurmas();
        }
    }

}

