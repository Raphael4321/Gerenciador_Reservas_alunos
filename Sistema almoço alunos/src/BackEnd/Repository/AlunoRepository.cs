using Sistema_almoço_alunos.src.Entities;
using Sistema_almoço_alunos.src.Utils;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Sistema_almoço_alunos.src.Repository
{
    public class AlunoRepository
    {
        Conexao con = new();
        // Método que salva um novo aluno no banco de dados
        public bool SalvarAluno(Aluno aluno)
        {
            try
            {
                // Conectando ao banco de dados
                con.conectar();

                // Estabelecendo o comando SQL para inserir um novo aluno
                string sql = "INSERT INTO Alunos (Nome, Responsavel, Telefone, Turma) values(@n, @r, @t, @t2)";

                // Criando um novo objeto de comando SQLite com a string SQL e a conexão
                SQLiteCommand parametros = new(con.conect);

                // Definindo os parâmetros da consulta SQL
                parametros.CommandText = sql;
                parametros.Parameters.AddWithValue("@n", aluno.Nome);
                parametros.Parameters.AddWithValue("@r", aluno.Responsavel);
                parametros.Parameters.AddWithValue("@t", aluno.Telefone);
                parametros.Parameters.AddWithValue("@t2", aluno.Turma);

                // Executando a consulta SQL
                parametros.ExecuteNonQuery();

                // Desconectando do banco de dados
                con.desconectar();

                // Retornando true para indicar que a operação foi bem-sucedida
                return true;
            }
            catch (Exception e)
            {
                // Em caso de exceção, exibe uma mensagem de erro e retorna false
                MessageBox.Show("Erro: " + e.Message);
                return false;
            }
        }

        // Método que atualiza um aluno existente no banco de dados
        public bool AtualizarAluno(Aluno aluno)
        {
            try
            {
                // Verificando se o aluno possui um ID válido, indicando que já existe no banco de dados
                if (aluno.Id > 0)
                {
                    // Conectando ao banco de dados
                    con.conectar();

                    // Estabelecendo o comando SQL para atualizar o aluno
                    string sql = "UPDATE Alunos SET Nome = @n, Responsavel = @r, Telefone = @t, Turma = @t2 WHERE Id = @i";

                    // Criando um novo objeto de comando SQLite com a string SQL e a conexão
                    SQLiteCommand parametros = new SQLiteCommand(sql, con.conect);

                    // Definindo os parâmetros da consulta SQL
                    parametros.Parameters.AddWithValue("@i", aluno.Id);
                    parametros.Parameters.AddWithValue("@n", aluno.Nome);
                    parametros.Parameters.AddWithValue("@r", aluno.Responsavel);
                    parametros.Parameters.AddWithValue("@t", aluno.Telefone);
                    parametros.Parameters.AddWithValue("@t2", aluno.Turma);

                    // Executando a consulta SQL
                    int rowsAffected = parametros.ExecuteNonQuery();

                    // Desconectando do banco de dados
                    con.desconectar();

                    // Verificando se a atualização foi bem sucedida (uma linha foi afetada)
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                // Em caso de exceção, exibe uma mensagem de erro e retorna false
                MessageBox.Show("Erro ao atualizar aluno: " + ex.Message);
            }

            return false;
        }

        // Método que lista os alunos com base em um filtro de nome, filtro de pesquisa e status ativo/inativo
        public DataTable ListarAlunos(string nome, string filtro, int ativo)
        {
            try
            {
                // Cria uma nova conexão com o banco de dados
                Conexao conexao = new Conexao();

                // Abre a conexão
                conexao.conectar();

                // Monta a consulta SQL para buscar os dados dos alunos utilizando o filtro de nome e o filtro de ativo/inativo
                string sql = "SELECT * FROM Alunos WHERE " + filtro + " LIKE @nome AND Status = @ativo";

                // Cria um novo adaptador de dados SQLite e passa a consulta e conexão como parâmetros
                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(sql, conexao.conect);

                // Adiciona os parâmetros @nome e @ativo na consulta SQL
                adaptador.SelectCommand.Parameters.AddWithValue("@nome", nome + "%");
                adaptador.SelectCommand.Parameters.AddWithValue("@ativo", ativo);

                // Cria uma nova DataTable para armazenar os dados retornados
                DataTable dtAlunos = new DataTable();

                // Preenche a DataTable com os dados retornados pela consulta
                adaptador.Fill(dtAlunos);

                // Fecha a conexão com o banco de dados
                conexao.desconectar();

                // Retorna a DataTable preenchida com os alunos encontrados
                return dtAlunos;
            }
            catch (Exception ex)
            {
                // Em caso de exceção, exibe uma mensagem de erro e retorna nulo
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        // Método que inativa um aluno no banco de dados
        public bool InativarAluno(Aluno aluno)
        {
            try
            {
                // Conectando ao banco de dados
                con.conectar();

                // Estabelecendo o comando SQL para inativar o aluno
                string sql = "UPDATE Alunos SET Status = 0 WHERE Id = @i";

                // Estabelecendo a conexão do comando com o banco de dados
                SQLiteCommand parametros = new(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;
                parametros.Parameters.AddWithValue("@i", aluno.Id);

                // Efetiva o comando
                parametros.ExecuteNonQuery();

                // Desconectando do banco de dados
                con.desconectar();

                return true;
            }
            catch (Exception ex)
            {
                // Em caso de exceção, exibe uma mensagem de erro e retorna false
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // Método que ativa um aluno no banco de dados
        public bool AtivarAluno(Aluno aluno)
        {
            try
            {
                // Conectando ao banco de dados
                con.conectar();

                // Estabelecendo o comando SQL para inativar o aluno
                string sql = "UPDATE Alunos SET Status = 1 WHERE Id = @i";

                // Estabelecendo a conexão do comando com o banco de dados
                SQLiteCommand parametros = new(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;
                parametros.Parameters.AddWithValue("@i", aluno.Id);

                // Efetiva o comando
                parametros.ExecuteNonQuery();

                // Desconectando do banco de dados
                con.desconectar();

                return true;
            }
            catch (Exception ex)
            {
                // Em caso de exceção, exibe uma mensagem de erro e retorna false
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // Método que deleta um aluno do banco de dados
        public bool DeletarAluno(Aluno aluno)
        {
            try
            {
                // Conectando ao banco de dados
                con.conectar();

                // Estabelecendo o comando SQL para deletar o aluno
                string sql = "DELETE FROM Alunos WHERE Id = @i";

                // Estabelecendo a conexão do comando com o banco de dados
                SQLiteCommand parametros = new(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;
                parametros.Parameters.AddWithValue("@i", aluno.Id);

                // Efetiva o comando
                parametros.ExecuteNonQuery();

                // Desconectando do banco de dados
                con.desconectar();

                return true;
            }
            catch (Exception ex)
            {
                // Em caso de exceção, exibe uma mensagem de erro e retorna false
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
