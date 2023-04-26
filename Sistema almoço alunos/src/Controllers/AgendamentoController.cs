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
        public DataTable ListarAgendamentos(int id, string mes, string ano)
        {
            // Verifica se os parâmetros são válidos
            if (id <= 0 || string.IsNullOrEmpty(mes) || string.IsNullOrEmpty(ano))
                throw new ArgumentException("Parâmetros inválidos");

            // Chama o método da classe AgendamentoService para obter a tabela com os agendamentos
            return AgeServico.listAgendamentos(id, mes, ano);
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
        public bool VerificarAgendamentosPorPlano(int id)
        {
            // Verifica se o parâmetro é válido
            if (id <= 0)
                throw new ArgumentException("Parâmetro inválido");

            // Chama o método da classe AgendamentoService para verificar a quantidade de agendamentos que utilizam um determinado plano
            return AgeServico.ProcurarAgeUsaPl(id);
        }

        // Deleta um agendamento
        public void DeletarAgendamento(Agendamento agendamento)
        {
            // Verifica se o agendamento é válido
            if (agendamento == null)
                throw new ArgumentNullException(nameof(agendamento), "Agendamento inválido");

            // Pergunta ao usuário se ele realmente deseja excluir o agendamento
            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja continuar?", "Excluir Agendamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            // Se o usuário confirmar a exclusão, chama o método da classe AgendamentoService para excluir o agendamento
            if (confirmacao == DialogResult.Yes)
                AgeServico.DelAgendamento(agendamento);
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
