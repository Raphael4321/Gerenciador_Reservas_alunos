using Sistema_almoço_alunos.src.Entities;
using Sistema_almoço_alunos.src.Utils;
using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_almoço_alunos.src.Repository
{
    internal class TurmaRepository
    {
        // Instancia um objeto de conexão com o banco de dados SQLite
        Conexao con = new();

        // Adiciona uma nova turma no banco de dados SQLite
        public void IncluirTurma(Turma turma)
        {
            try
            {
                // Abre a conexão com o banco de dados
                con.conectar();

                // Cria a string SQL para inserir a turma no banco de dados
                string sql = "INSERT INTO Turmas (Nome, Ano, Nivel, Turno) VALUES (@nome, @ano, @nivel, @turno)";

                // Cria um objeto de comando SQLite e passa a string SQL e a conexão como parâmetros
                SQLiteCommand cmd = new SQLiteCommand(sql, con.conect);

                // Define os parâmetros da consulta
                cmd.Parameters.AddWithValue("@nome", turma.Nome);
                cmd.Parameters.AddWithValue("@ano", turma.Ano);
                cmd.Parameters.AddWithValue("@nivel", turma.Nivel);
                cmd.Parameters.AddWithValue("@turno", turma.Turno);

                // Executa a consulta SQL
                cmd.ExecuteNonQuery();

                // Fecha a conexão com o banco de dados
                con.desconectar();
            }
            catch (Exception ex)
            {
                // Em caso de exceção, exibe uma mensagem de erro
                MessageBox.Show(ex.Message);
            }
        }


        public bool EditarTurma(Turma turma)
        {
            try
            {
                // Abre a conexão com o banco de dados
                con.conectar();

                // Cria uma string SQL para atualizar a turma
                string sql = "UPDATE Turmas SET Nome = @Nome, Ano = @Ano, Nivel = @Nivel, Turno = @Turno WHERE Id = @Id";

                // Cria um novo objeto de comando SQLite com a string SQL e a conexão
                SQLiteCommand cmd = new SQLiteCommand(sql, con.conect);

                // Define os parâmetros da consulta SQL
                cmd.Parameters.AddWithValue("@Nome", turma.Nome);
                cmd.Parameters.AddWithValue("@Ano", turma.Ano);
                cmd.Parameters.AddWithValue("@Nivel", turma.Nivel);
                cmd.Parameters.AddWithValue("@Turno", turma.Turno);
                cmd.Parameters.AddWithValue("@Id", turma.Id);

                // Executa a consulta SQL e armazena o número de linhas afetadas
                int linhasAfetadas = cmd.ExecuteNonQuery();

                // Fecha a conexão com o banco de dados
                con.desconectar();

                // Retorna true se a turma foi atualizada com sucesso, ou false caso contrário
                return linhasAfetadas > 0;
            }
            catch (Exception ex)
            {
                // Em caso de exceção, exibe uma mensagem de erro e retorna false
                MessageBox.Show("Erro ao editar turma: " + ex.Message);
                return false;
            }
        }

        // Exclui uma turma do banco de dados SQLite
        public void ExcluirTurma(Turma turma)
        {
            try
            {
                // Conecta ao banco de dados
                con.conectar();

                // Cria uma string SQL para excluir a turma
                string sql = "DELETE FROM Turma WHERE Id = @i";

                // Cria um novo objeto de comando SQLite com a string SQL e a conexão
                SQLiteCommand parametros = new(con.conect);

                // Define os parâmetros da consulta SQL
                parametros.CommandText = sql;
                parametros.Parameters.AddWithValue("@i", turma.Id);

                // Executa a consulta SQL
                parametros.ExecuteNonQuery();

                // Desconecta do banco de dados
                con.desconectar();
            }
            catch (Exception ex)
            {
                // Em caso de exceção, exibe uma mensagem de erro
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        // Lista os planos do banco de dados SQLite em um DataTable
        public DataTable ListaTurmas()
        {
            try
            {
                // Conecta ao banco de dados
                con.conectar();

                // Cria a string SQL para listar os planos
                string sql = "SELECT * FROM Turmas";

                // Cria um novo objeto SQLiteDataAdapter, passando a consulta SQL e a conexão
                SQLiteDataAdapter data = new(sql, con.conect);

                // Cria um novo objeto DataTable
                DataTable dt = new();

                // Preenche o DataTable com os dados retornados pela consulta SQL
                data.Fill(dt);

                // Fecha a conexão com o banco de dados
                con.desconectar();

                // Retorna o DataTable preenchido
                return dt;

            }

            catch (Exception ex)
            {
                // Em caso de exceção, exibe uma mensagem de erro
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}

