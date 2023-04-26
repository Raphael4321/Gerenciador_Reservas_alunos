using Sistema_almoço_alunos.src.Controllers;
using Sistema_almoço_alunos.src.Entities;
using Sistema_almoço_alunos.src.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_almoço_alunos.src.Services
{
    internal class TurmaService
    {
        TurmaRepository rep = new TurmaRepository();
        public void SalvarTurma(Turma turma)
        {
            if (turma.Id > 0)
            {
                rep.EditarTurma(turma);
            }
            else
            {
                rep.IncluirTurma(turma);
            }
        }

        public DataTable ListarTurmas()
        {
            return rep.ListaTurmas();
        }

        public void ExcluirTurma(Turma turma)
        {
            rep.ExcluirTurma(turma);
        }
    }
}
