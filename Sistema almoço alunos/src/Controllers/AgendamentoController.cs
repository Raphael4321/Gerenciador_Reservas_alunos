using Org.BouncyCastle.Ocsp;
using Sistema_almoço_alunos.src.Entities;
using Sistema_almoço_alunos.src.Services;
using Sistema_almoço_alunos.src.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_almoço_alunos.src.Controllers
{
    // Controlador responsável por gerenciar as funcionalidades relacionadas a agendamentos
    internal class AgendamentoController
    {
        AgendamentoService AgeServico = new();

        // Lista os agendamentos de um determinado mês e ano, de acordo com o ID do paciente
        public DataTable ListarAgendamentos(int id, string mes, string ano, int status)
        {
            // Chama o método da classe AgendamentoService para obter a tabela com os agendamentos
            return AgeServico.ListarAgendamentos(id, mes, ano, status);
        }

        // Salva um agendamento
        public void SalvarAgendamento(Agendamento agendamento)
        {
            // Verifica se o agendamento é válido
            if (agendamento == null)
                throw new ArgumentNullException(nameof(agendamento), "Agendamento inválido");

            // Chama o método da classe AgendamentoService para salvar o agendamento
            AgeServico.SalvarAgendamento(agendamento);
        }

        // Verifica se há agendamentos que utilizam um determinado plano
        public bool VerificarPlanoEmUso(int id)
        {
            // Verifica se o parâmetro é válido
            if (id <= 0)
                throw new ArgumentException("Parâmetro inválido");

            // Chama o método da classe AgendamentoService para verificar a quantidade de agendamentos que utilizam um determinado plano
            return AgeServico.VerificarPlanoEmUso(id);
        }

        // Atualiza o status do agendamento para 0
        public void CancelarAgendamento(Agendamento agendamento)
        {
            // Verifica se o agendamento é válido
            if (agendamento == null)
                throw new ArgumentNullException(nameof(agendamento), "Agendamento inválido");

            // Chama o método de atualização do agendamento no repositório
            AgeServico.CancelarAgendamento(agendamento);
        }
 


        // Calcula a soma total do valor dos agendamentos
        public double SomaTotal(DataTable dt)
        {
            // Verifica se a tabela é válida
            if (dt == null || dt.Rows.Count == 0)
                throw new ArgumentNullException(nameof(dt), "Tabela inválida");

            // Soma o valor total dos agendamentos usando o método da classe Utilidades
            return new Utilidades().SomaTotal(dt);
        }


    }
}
