using Sistema_almoço_alunos.src.Entities;
using Sistema_almoço_alunos.src.Utils;
using System;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace Sistema_almoço_alunos.src.Repository
{
    public class AgendamentoRepository
    {
        private Conexao con;

        // Atualiza um agendamento no banco de dados
        public void AtualizarAgendamento(Agendamento agendamento)
        {
            try
            {
                // Conecta ao banco de dados
                con.conectar();

                // Obtém o ano do agendamento
                int ano = agendamento.Data.Year;

                // Define o comando SQL para atualizar o agendamento
                string sql = "UPDATE Agendamento SET Data = @d, Ano = @a, IdPlano = @p WHERE Id = @id";

                // Cria um objeto SQLiteCommand com o comando SQL e a conexão do banco de dados
                using SQLiteCommand cmd = new SQLiteCommand(sql, con.conect);

                // Define os parâmetros do comando SQL
                cmd.Parameters.AddWithValue("@id", agendamento.Id);
                cmd.Parameters.AddWithValue("@p", agendamento.Plano.Id);
                cmd.Parameters.AddWithValue("@d", agendamento.Data);
                cmd.Parameters.AddWithValue("@a", ano);

                // Executa o comando SQL
                cmd.ExecuteNonQuery();

                // Desconecta do banco de dados
                con.desconectar();
            }
            catch (Exception e)
            {
                // Em caso de exceção, exibe uma mensagem de erro com a mensagem da exceção
                MessageBox.Show("Erro: " + e.Message);
            }
        }

        // Salva um novo agendamento no banco de dados
        public void SalvarAgendamento(Agendamento agendamento)
        {
            try
            {
                // Conecta ao bando de dados
                con.conectar();

                // Obtém o ano do agendamento
                int ano = agendamento.Data.Year;

                // Comando para inserir um novo agendamento na tabela Agendamento
                string sql = "INSERT INTO Agendamento (IdAluno, IdPlano, Data, Ano) values(@i, @p, @d, @a)";

                // Cria um objeto SQLiteCommand com o comando SQL e a conexão do banco de dados
                using SQLiteCommand cmd = new SQLiteCommand(sql, con.conect);

                // Define os parâmetros do comando SQL
                cmd.Parameters.AddWithValue("@i", agendamento.IdAluno);
                cmd.Parameters.AddWithValue("@p", agendamento.Plano.Id);
                cmd.Parameters.AddWithValue("@d", agendamento.Data);
                cmd.Parameters.AddWithValue("@a", ano);

                // Executa o comando SQL para inserir o novo agendamento na tabela Agendamento
                cmd.ExecuteNonQuery();

                // Fecha a conexão com o banco de dados
                con.desconectar();
            }
            catch (Exception e)
            {
                // Exibe uma mensagem de erro caso ocorra alguma exceção
                MessageBox.Show("Erro: " + e.Message);
            }
        }

        // Lista os agendamentos no banco de dados
        public DataTable ListarAgendamentos(int idAluno, string mes, string ano, int status)
        {
            try
            {
                // Cria uma nova instância da classe Conexao
                Conexao con = new Conexao();

                // Conecta ao banco de dados
                con.conectar();

                // Monta a query SQL para selecionar os agendamentos do aluno com o id especificado no mês e ano também especificados, 
                // juntamente com os dados do plano relacionado a cada agendamento
                string sql = @"SELECT * 
                               FROM Agendamento AS a 
                               INNER JOIN Plano AS p ON a.IdAluno = @IdAluno AND 
                                                        a.Ano LIKE @Ano AND 
                                                        strftime('%m', a.Data) LIKE @Mes AND 
                                                        p.Id = a.IdPlano AND 
                                                        a.Status = @Status";

                // Cria um objeto SQLiteCommand com a query SQL e a conexão do banco de dados
                using SQLiteCommand cmd = new SQLiteCommand(sql, con.conect);

                // Adiciona os parâmetros à query SQL
                cmd.Parameters.AddWithValue("@IdAluno", idAluno);
                cmd.Parameters.AddWithValue("@Ano", ano + "%");
                cmd.Parameters.AddWithValue("@Mes", mes + "%");
                cmd.Parameters.AddWithValue("@Status", status);

                // Cria um objeto SQLiteDataAdapter com o comando SQL e a conexão
                using SQLiteDataAdapter data = new SQLiteDataAdapter(cmd);

                // Cria um objeto DataTable para armazenar os dados retornados pela consulta SQL
                DataTable dt = new DataTable();

                // Preenche o DataTable com os dados retornados pela consulta SQL
                data.Fill(dt);

                // Desconecta do banco de dados
                con.desconectar();

                // Retorna o DataTable preenchido com os dados da consulta SQL
                return dt;
            }
            catch (Exception ex)
            {
                // Em caso de exceção, exibe uma mensagem de erro com a mensagem da exceção
                MessageBox.Show("Erro: " + ex.Message);

                // Retorna null para indicar que ocorreu um erro
                return null;
            }
        }

        // Verifica se existem agendamentos utilizando um determinado plano
        public bool ProcurarAgeUsaPl(int idPlano)
        {
            try
            {
                // Cria uma nova instância da classe Conexao
                Conexao con = new Conexao();

                // Conecta ao banco de dados
                con.conectar();

                // Monta a query SQL para selecionar os agendamentos com o id do plano especificado
                string sql = "SELECT * FROM Agendamento WHERE IdPlano = @IdPlano";

                // Cria um objeto SQLiteCommand com a query SQL e a conexão do banco de dados
                using SQLiteCommand cmd = new SQLiteCommand(sql, con.conect);

                // Adiciona o parâmetro à query SQL
                cmd.Parameters.AddWithValue("@IdPlano", idPlano);

                // Cria um objeto DataTable para armazenar os dados retornados pela consulta SQL
                using DataTable dt = new DataTable();

                // Cria um objeto SQLiteDataAdapter com o comando SQL e a conexão do banco de dados
                using SQLiteDataAdapter data = new SQLiteDataAdapter(cmd);

                // Preenche o DataTable com os dados retornados pela consulta SQL
                data.Fill(dt);

                // Desconecta do banco de dados
                con.desconectar();

                // Retorna true se houver pelo menos um registro encontrado, false caso contrário
                return (dt.Rows.Count > 0);
            }
            catch (Exception ex)
            {
                // Em caso de exceção, relança a exceção para ser tratada em um nível superior
                MessageBox.Show("Erro: " + ex.Message);
                return false;
            }
        }

        // Deleta todos os agendamentos de um aluno no banco de dados
        public void DeletarAgendamentosPorAluno(int idAluno)
        {
            try
            {
                con.conectar();

                // Estabelecendo o comando SQL para deletar os agendamentos do aluno
                string sql = "DELETE FROM Agendamento WHERE IdAluno = @IdAluno";

                // Estabelecendo a conexão do comando com o banco de dados
                using SQLiteCommand parametros = new SQLiteCommand(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;
                parametros.Parameters.AddWithValue("@IdAluno", idAluno);

                // Executa o comando
                parametros.ExecuteNonQuery();

                // Desconectando do banco de dados
                con.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        // Deleta um único agendamento do banco de dados
        public void DeletarAgendamento(int idAgendamento)
        {
            try
            {
                con.conectar();

                // Estabelecendo o comando SQL para deletar o agendamento
                string sql = "DELETE FROM Agendamento WHERE Id = @IdAgendamento";

                // Estabelecendo a conexão do comando com o banco de dados
                using SQLiteCommand parametros = new SQLiteCommand(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;
                parametros.Parameters.AddWithValue("@IdAgendamento", idAgendamento);

                // Executa o comando
                parametros.ExecuteNonQuery();

                // Desconectando do banco de dados
                con.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
