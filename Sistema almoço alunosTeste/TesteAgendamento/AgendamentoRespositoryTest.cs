using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_almoço_alunos.src.Entities;
using Sistema_almoço_alunos.src.Repository;
using System.Data;

namespace Sistema_almoço_alunosTeste.TesteAgendamento
{
    [TestClass]
    public class AgendamentoRepositoryTest
    {
        [TestMethod]
        public void TestAtualizarAgendamento()
        {
            // Crie um objeto Agendamento com dados para atualizar
            Agendamento age = new Agendamento();
            age.Id = 1;
            age.Plano = new Plano(); // Inicializa a propriedade Plano
            age.Plano.Id = 1;
            age.Data = DateTime.Now;

            // Crie um objeto AgendamentoRepository para testar o método AtualizarAgendamento
            AgendamentoRepository repo = new AgendamentoRepository();

            try
            {
                // Tente atualizar o agendamento
                repo.AtualizarAgendamento(age);

                // Verifique se o agendamento foi atualizado corretamente
                DataTable agendamentoAtualizado = repo.listAgendamentos(age.Id, "", "");
                Assert.AreEqual(age.Plano.Id, agendamentoAtualizado.Rows[0]["IdPlano"]);
                Assert.AreEqual(age.Data.ToString(), agendamentoAtualizado.Rows[0]["Data"].ToString());
            }
            catch (Exception e)
            {
                // Se ocorrer uma exceção, o teste falhou
                Assert.Fail("Falha ao atualizar agendamento: " + e.Message);
            }
        }


        [TestMethod]
        public void TestSalvarAgendamento()
        {
            // Crie um objeto Agendamento com dados para salvar
            Agendamento age = new Agendamento();
            age.IdAluno = 1;
            age.Plano.Id = 1;
            age.Data = DateTime.Now;

            // Crie um objeto AgendamentoRepository para testar o método SalvarAgendamento
            AgendamentoRepository repo = new AgendamentoRepository();

            try
            {
                // Tente salvar o agendamento
                repo.SalvarAgendamento(age);

                // Verifique se o agendamento foi salvo corretamente
                DataTable dt = repo.listAgendamentos(age.IdAluno, "", "");
                DataRow agendamentoSalvo = dt.Rows[0];
                Assert.AreEqual(age.IdAluno, Convert.ToInt32(agendamentoSalvo["IdAluno"]));
                Assert.AreEqual(age.Plano.Id, Convert.ToInt32(agendamentoSalvo["IdPlano"]));
                Assert.AreEqual(age.Data.Date, Convert.ToDateTime(agendamentoSalvo["Data"]).Date);
            }
            catch (Exception e)
            {
                // Se ocorrer uma exceção, o teste falhou
                Assert.Fail("Falha ao salvar agendamento: " + e.Message);
            }
        }

        [TestMethod]
        public void TestDelAgendamento()
        {
            // Crie um objeto Agendamento com dados para salvar
            Agendamento age = new Agendamento();
            age.IdAluno = 1;
            age.Plano.Id = 1;
            age.Data = DateTime.Now;

            // Crie um objeto AgendamentoRepository para testar o método DelAgendamento
            AgendamentoRepository repo = new AgendamentoRepository();

            try
            {
                // Tente excluir o agendamento
                repo.DelAgendamento(age);

                // Verifique se o agendamento foi excluído corretamente
                DataTable dt = repo.listAgendamentos(age.IdAluno, "", "");
                DataRow agendamentoExcluido = dt.Rows[0];
                Assert.IsNull(agendamentoExcluido);
            }
            catch (Exception e)
            {
                // Se ocorrer uma exceção, o teste falhou
                Assert.Fail("Falha ao excluir agendamento: " + e.Message);
            }
        }

        [TestMethod]
        public void TestProcurarAgeUsaPl()
        {
            // Crie um objeto AgendamentoRepository para testar o método ProcurarAgeUsaPl
            AgendamentoRepository repo = new AgendamentoRepository();

            try
            {
                // Procure um agendamento que utilize um plano existente
                bool encontrado = repo.ProcurarAgeUsaPl(1);

                // Verifique se o agendamento foi encontrado corretamente
                Assert.IsTrue(encontrado);
            }
            catch (Exception e)
            {
                // Se ocorrer uma exceção, o teste falhou
                Assert.Fail("Falha ao procurar agendamento que utilize o plano: " + e.Message);
            }
        }

    }
}
