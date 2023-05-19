using Sistema_almoço_alunos.src.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace Sistema_almoço_alunos.src.Utils
{
    internal class Utilidades
    {
        // Retorna uma lista de números de 1 a 9
        public List<string> ListaSerie()
        {
            // Cria uma nova lista de strings
            List<string> numeros = new List<string>();
            // Cria um objeto de formatação de número na cultura "pt-BR"
            NumberFormatInfo format = new CultureInfo("pt-BR").NumberFormat;
            // Adiciona os números ordinais de 1º a 9º à lista
            for (int i = 1; i <= 9; i++)
            {
                string ordinal = i.ToString(format) + "º";
                numeros.Add(ordinal);
            }
            // Retorna a lista de números ordinais
            return numeros;
        }


        // Retorna uma lista de turnos (Manhã, Tarde, Noite)
        public List<string> ListaTurnos()
        {
            // Cria uma nova lista de strings
            List<string> turnos = new List<string>();
            // Adiciona as opções de turno "Manhã", "Tarde" e "Noite" à lista
            turnos.Add("Manhã");
            turnos.Add("Tarde");
            turnos.Add("Noite");
            // Retorna a lista de turnos
            return turnos;
        }

        // Retorna uma lista de gêneros (Feminino, Masculino)
        public List<string> ListaEnsino()
        {
            // Cria uma nova lista de strings
            List<string> escolaridades = new List<string>();
            // Adiciona as opções de Ensino Fundamental e Médio à lista
            escolaridades.Add("Fundamental");
            escolaridades.Add("Médio");
            // Retorna a lista de escolaridade
            return escolaridades;
        }

        // Retorna uma lista de caracteres do alfabeto (de A a Z)
        public List<char> ListaAlfabeto()
        {
            // Cria uma nova lista de caracteres
            List<char> alfabeto = new List<char>();
            // Adiciona as letras de A a Z à lista
            for (char c = 'A'; c <= 'Z'; c++)
            {
                alfabeto.Add(c);
            }
            // Retorna a lista de caracteres do alfabeto
            return alfabeto;
        }

        public List<string> ListaFiltro()
        {
            List<string> filtro = new();

            string dado = "Nome";
            filtro.Add(dado);
            dado = "Turma";
            filtro.Add(dado);

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
            DataTable dtAluno = controllerStu.ListarAlunos(nome, "Nome", 1);

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

        // Aplica criptografia à senha do usuario
        public string CriptografarSenha(string senha)
        {
            // Utilize aqui o algoritmo de criptografia de sua preferência
            // Este exemplo utiliza o SHA256
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        public void GerarPDF(DataTable dt)
        {
            // Verifica se há dados na tabela
            if (dt != null && dt.Rows.Count > 0)
            {
                // Cria um novo objeto Document
                Document doc = new Document();

                try
                {
                    // Define o caminho onde o arquivo será salvo
                    string caminhoArquivo = "C:\\Users\\Teste\\Documents";

                    // Cria um objeto PdfWriter para escrever no arquivo
                    PdfWriter.GetInstance(doc, new FileStream(caminhoArquivo, FileMode.Create));

                    // Abre o documento para edição
                    doc.Open();

                    // Cria um objeto PdfPTable com o mesmo número de colunas da tabela
                    PdfPTable table = new PdfPTable(dt.Columns.Count);

                    // Adiciona o cabeçalho da tabela
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        table.AddCell(new Phrase(dt.Columns[i].ColumnName));
                    }

                    // Adiciona as linhas da tabela
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            table.AddCell(new Phrase(dt.Rows[i][j].ToString()));
                        }
                    }

                    // Adiciona a tabela ao documento
                    doc.Add(table);

                    // Fecha o documento
                    doc.Close();

                    // Abre a pasta onde o arquivo foi salvo
                    Process.Start("explorer.exe", "/select, " + caminhoArquivo);

                    // Exibe uma mensagem informando que o arquivo foi gerado com sucesso e onde ele foi salvo
                    MessageBox.Show($"O arquivo PDF foi gerado com sucesso em {caminhoArquivo}.");
                }
                catch (Exception ex)
                {
                    // Exibe uma mensagem de erro em caso de exceção
                    MessageBox.Show($"Ocorreu um erro ao gerar o arquivo PDF: {ex.Message}");
                }
            }
            else
            {
                // Exibe uma mensagem informando que não há dados para gerar o PDF
                MessageBox.Show("Não há dados para gerar o arquivo PDF.");
            }
        }


    }
}

