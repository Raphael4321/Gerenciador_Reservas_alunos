using Sistema_almoço_alunos.src.Entities;
using Sistema_almoço_alunos.src.Repository;
using Sistema_almoço_alunos.src.Utils;
using System;
using System.Data;

namespace Sistema_almoço_alunos.src.Services
{
    internal class AgendamentoService
    {
        AgendamentoRepository rep = new();
        Utilidades util = new();

        // salvar Agendamento (incompleto)
        public void SalvarAgendamento(Agendamento age)
        {
            if (age.Id > 0)
            {
                rep.AtualizarAgendamento(age);
            }
            else
            {
                rep.SalvarAgendamento(age);
            }
            

        }

        public DataTable listAgendamentos(int id, string mes, string ano)
        {          
                return rep.listAgendamentos(id, mes, ano);
            
        }

        public Double SomaTotal(DataTable dt)
        {
            return util.SomaTotal(dt);
        }

        public void DelAgendamento(Agendamento age)
        {
            rep.DelAgendamento(age);
        }

        public void DelTodosAgendamentos(int id)
        {
            rep.DelTodos(id);
        }

        public bool ProcurarAgeUsaPl(int idPlano)
        {
            return rep.ProcurarAgeUsaPl(idPlano);
        }
    }
}
