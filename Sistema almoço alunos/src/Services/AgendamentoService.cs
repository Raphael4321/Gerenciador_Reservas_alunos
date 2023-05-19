using Sistema_almoço_alunos.src.Entities;
using Sistema_almoço_alunos.src.Repository;
using Sistema_almoço_alunos.src.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_almoço_alunos.src.Services
{
    internal class AgendamentoService
    {
        AgendamentoRepository rep = new();
        Utilidades util = new();

        // Salva ou atualiza um agendamento
        public void SalvarAgendamento(Agendamento age)
        {
            // Verifica se o Id do agendamento é maior que 0, o que indica que já existe no banco de dados
            if (age.Id > 0)
            {
                // Chama o método de atualização do agendamento no repositório
                rep.AtualizarAgendamento(age);
            }
            else
            {
                // Caso contrário, chama o método de salvar um novo agendamento no repositório
                rep.SalvarAgendamento(age);
            }
        }

        // Lista os agendamentos de um aluno em um determinado mês e ano
        public DataTable ListarAgendamentos(int id, string mes, string ano, int status)
        {
            // Chama o método de listar agendamentos do repositório, passando os parâmetros recebidos
            return rep.ListarAgendamentos (id, mes, ano, status);
        }

        // Calcula a soma total dos valores de um DataTable
        public double CalcularSomaTotal(DataTable dt)
        {
            // Chama o método de soma total do utilitário passando o DataTable
            return util.SomaTotal(dt);
        }

        // Altera o status de um agendamento para 0
        public void CancelarAgendamento(Agendamento age)
        {
            try
            {
                // Chama o método de atualização do agendamento no repositório
                rep.CancelarAgendamento(age);
            }
            catch (Exception ex)
            {
                // Em caso de exceção, exibe uma mensagem de erro com a mensagem da exceção
                MessageBox.Show(ex.Message);
            }
        }


        // Verifica se um plano está sendo usado em algum agendamento
        public bool VerificarPlanoEmUso(int idPlano)
        {
            // Chama o método de verificação de uso do plano no repositório
            return rep.ProcurarAgeUsaPl(idPlano);
        }

    }
}
