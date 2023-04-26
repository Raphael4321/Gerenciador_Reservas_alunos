using Sistema_almoço_alunos.src.Controllers;
using System;
using System.Collections.Generic;
using System.Data;

namespace Sistema_almoço_alunos.src.Utils
{
    internal class Utilidades
    {

            // Retorna uma lista de strings contendo os filtros possíveis para a busca de alunos
            public List<string> listFiltro()
            {
                List<string> filtro = new List<string>();
                filtro.Add("Nome");
                filtro.Add("Turma");
                return filtro;
            }

            // Calcula e retorna a soma total dos valores em uma tabela de dados
            public double SomaTotal(DataTable dt)
            {
                double soma = 0;

                // Percorre cada linha da tabela
                foreach (DataRow row in dt.Rows)
                {
                    double valor = Convert.ToDouble(row["Valor"]);

                    // Se o valor for diferente de zero, adiciona à soma
                    if (valor != 0)
                        soma += valor;
                }

                // Retorna a soma total arredondada em duas casas decimais
                return Math.Round(soma, 2);
            }

            // Gera e retorna uma tabela de relatório com o nome dos alunos e o valor total de agendamentos para o mês e ano especificados
            public DataTable Relatorio(string nome, string mes, string ano)
            {
                // Cria uma instância do ControllerStu
                AlunoController controllerStu = new AlunoController();

                // Cria uma DataTable vazia para armazenar os resultados
                DataTable dt = CriarTabela();

                // Obtém os alunos do ControllerStu
                DataTable dtAluno = controllerStu.ListarAlunos(nome, "Nome");

                // Para cada aluno, calcula o valor total de agendamentos e adiciona uma nova linha na DataTable com o nome do aluno e o valor total
                foreach (DataRow drAluno in dtAluno.Rows)
                {
                    int idAluno = Convert.ToInt32(drAluno["Id"]);
                    string nomeAluno = Convert.ToString(drAluno["Nome"]);

                    // Obtém os agendamentos do aluno do ControllerAge
                    DataTable dtAgendamento = GetAgendamentosAluno(idAluno, mes, ano);

                    // Calcula o valor total dos agendamentos do aluno
                    double valorTotal = CalcularValorTotal(dtAgendamento);

                    // Se o valor total for maior que zero, adiciona uma nova linha na DataTable com o nome do aluno e o valor total
                    if (valorTotal > 0)
                    {
                        AdicionarLinha(dt, nomeAluno, valorTotal);
                    }
                }

                // Retorna a tabela de relatório
                return dt;
            }

            // Cria e retorna uma nova tabela de dados com as colunas "Nome do aluno" e "Valor total"
            private DataTable CriarTabela()
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Nome do aluno", typeof(string));
                dt.Columns.Add("Valor total", typeof(double));
                return dt;
            }

            // Obtém e retorna os agendamentos do aluno com o ID especificado para o mês e ano especificados
            private DataTable GetAgendamentosAluno(int idAluno, string mes, string ano)
            {
                AgendamentoController controllerAge = new AgendamentoController();
                return controllerAge.ListarAgendamentos(idAluno, mes, ano);
            }

            // Calcula e retorna o valor total dos agendamentos na tabela
            private double CalcularValorTotal(DataTable dtAgendamento)
            {
                AgendamentoController controllerAge = new AgendamentoController();
                return controllerAge.SomaTotal(dtAgendamento);
            }

            // Adiciona uma nova linha à tabela com o nome do aluno e o valor total
            private void AdicionarLinha(DataTable dt, string nomeAluno, double valorTotal)
            {
                DataRow dr = dt.NewRow();
                dr["Nome do aluno"] = nomeAluno;
                dr["Valor total"] = Math.Round(valorTotal, 2);
                dt.Rows.Add(dr);
            }

        }
    }

