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
        Conexao con = new();

        // Atualiza um agendamento no banco de dados
        public void AtualizarAgendamento(Agendamento age)
        {
            try
            {
                // Conecta ao banco de dados
                con.conectar();

                // Obtém o ano do agendamento
                int ano = Convert.ToInt32(age.Data.Year);

                // Define o comando SQL para atualizar o agendamento
                string sql = "UPDATE Agendamento SET Data = @d, Ano = @a, IdPlano = @p WHERE Id = @id";

                // Cria um objeto SQLiteCommand com o comando SQL e a conexão do banco de dados
                SQLiteCommand cmd = new(sql, con.conect);

                // Define os parâmetros do comando SQL
                cmd.Parameters.AddWithValue("@id", age.Id);
                cmd.Parameters.AddWithValue("@p", age.Plano.Id);
                cmd.Parameters.AddWithValue("@d", age.Data);
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
        public void SalvarAgendamento(Agendamento age)
        {
            try
            {
                // Conecta ao bando de dados
                con.conectar();

                // Obtém o ano do agendamento
                int ano = Convert.ToInt32(age.Data.Year);

                // Comando para inserir um novo agendamento na tabela Agendamento
                string sql = "INSERT INTO Agendamento (IdAluno, IdPlano, Data, Ano) values(@i, @p, @d, @a)";

                // Cria um objeto SQLiteCommand com o comando SQL e a conexão do banco de dados
                SQLiteCommand parametros = new(con.conect);

                // Define o texto do comando SQL e os parâmetros que serão usados na consulta
                parametros.CommandText = sql;
                parametros.Parameters.AddWithValue("@i", age.IdAluno);
                parametros.Parameters.AddWithValue("@p", age.Plano.Id);
                parametros.Parameters.AddWithValue("@d", age.Data);
                parametros.Parameters.AddWithValue("@a", ano);

                // Executa o comando SQL para inserir o novo agendamento na tabela Agendamento
                parametros.ExecuteNonQuery();

                // Fecha a conexão com o banco de dados
                con.desconectar();
            }
            catch (Exception e)
            {
                // Exibe uma mensagem de erro caso ocorra alguma exceção
                MessageBox.Show("erro: " + e);
            }
        }

        // Lista os agendamentos no banco de dados
        public DataTable ListarAgendamentos(int idAluno, string mes, string ano, int status)
        {
            try
            {
                // Cria uma nova instância da classe Conexao
                Conexao con = new();

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
                SQLiteCommand cmd = new(sql, con.conect);

                // Adiciona os parâmetros à query SQL
                cmd.Parameters.AddWithValue("@IdAluno", idAluno);
                cmd.Parameters.AddWithValue("@Ano", ano + "%");
                cmd.Parameters.AddWithValue("@Mes", mes + "%");
                cmd.Parameters.AddWithValue("@Status", status);

                // Cria um objeto SQLiteDataAdapter com o comando SQL e a conexão
                SQLiteDataAdapter data = new(cmd);

                // Cria um objeto DataTable para armazenar os dados retornados pela consulta SQL
                DataTable dt = new();

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
                MessageBox.Show(ex.Message);

                // Retorna null para indicar que ocorreu um erro
                return null;
            }
        }


        // Altera o status de um agendamento para 0 no banco de dados
        public void CancelarAgendamento(Agendamento age)
        {
            try
            {
                con.conectar();

                // Estabelecendo o comando
                string sql = "UPDATE Agendamento SET Status = 0 WHERE Id=@i";

                //Estabelecendo a conexão do comando com o banco de dados
                SQLiteCommand parametros = new(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;

                parametros.Parameters.AddWithValue("@i", age.Data);

                //Efetiva o comando o comando
                parametros.ExecuteNonQuery();

                //Descondectando do banco de dados
                con.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Verifica se existem agendamentos utilizando um determinado plano
        public bool ProcurarAgeUsaPl(int idPlano)
        {
            try
            {
                // Cria uma nova instância da classe Conexao
                Conexao con = new();

                // Conecta ao banco de dados
                con.conectar();

                // Monta a query SQL para selecionar os agendamentos com o id do plano especificado
                string sql = "SELECT * FROM Agendamento WHERE IdPlano = @IdPlano";

                // Cria um objeto SQLiteCommand com a query SQL e a conexão do banco de dados
                using SQLiteCommand cmd = new(sql, con.conect);

                // Adiciona o parâmetro à query SQL
                cmd.Parameters.AddWithValue("@IdPlano", idPlano);

                // Cria um objeto DataTable para armazenar os dados retornados pela consulta SQL
                using DataTable dt = new();

                // Cria um objeto SQLiteDataAdapter com o comando SQL e a conexão
                // do banco de dados
                using SQLiteDataAdapter data = new(cmd);

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
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}

