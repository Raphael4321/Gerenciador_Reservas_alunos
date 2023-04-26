using Sistema_almoço_alunos.src.Entities;
using Sistema_almoço_alunos.src.Utils;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Sistema_almoço_alunos.src.Repository
{
    internal class AlunoRepository
    {
        Conexao con = new();
        public bool SalvarAluno(Aluno aluno)
        {
            try
            {
                // Instanciando a variavel onde o comando é guardado
                string sql;

                // Conectando ao banco de dados
                con.conectar();

                // Estabelecendo o comando
                sql = "INSERT INTO Alunos (Nome, Responsavel, Telefone, Turma) values(@n, @r, @t, @t2)";

                //Estabelecendo a conexão do comando com o banco de dados
                SQLiteCommand parametros = new(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;

                parametros.Parameters.AddWithValue("@n", aluno.Nome);
                parametros.Parameters.AddWithValue("@r", aluno.Responsavel);
                parametros.Parameters.AddWithValue("@t", aluno.Telefone);
                parametros.Parameters.AddWithValue("@t2", aluno.Turma);

                //Efetiva o comando o comando
                parametros.ExecuteNonQuery();

                //Desconectando do banco de dados
                con.desconectar();

                //Retornando true para indicar que a operação foi bem-sucedida
                return true;

            }
            //Se não funcionar, retorna false e mostra uma janela de erro com a mensagem de exceção
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
                return false;
            }
        }


        public bool AtualizarAluno(Aluno aluno)
        {
            try
            {
                // se for encontrado um Id no aluno, então ele já existe e se trata de uma edição
                if (aluno.Id > 0)
                {
                    // conectando ao banco de dados
                    con.conectar();

                    // estabelecendo o comando SQL para atualizar o aluno
                    string sql = "UPDATE Alunos SET Nome = @n, Responsavel = @r, Telefone = @t, Turma = @t2 WHERE Id = @i";

                    // criando um novo objeto de comando SQLite com a string SQL e a conexão
                    SQLiteCommand parametros = new SQLiteCommand(sql, con.conect);

                    // definindo os parâmetros da consulta SQL
                    parametros.Parameters.AddWithValue("@i", aluno.Id);
                    parametros.Parameters.AddWithValue("@n", aluno.Nome);
                    parametros.Parameters.AddWithValue("@r", aluno.Responsavel);
                    parametros.Parameters.AddWithValue("@t", aluno.Telefone);
                    parametros.Parameters.AddWithValue("@t2", aluno.Turma);

                    // executando a consulta SQL
                    int rowsAffected = parametros.ExecuteNonQuery();

                    // desconectando do banco de dados
                    con.desconectar();

                    // verificando se a atualização foi bem sucedida (uma linha foi afetada)
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                // em caso de exceção, exibe uma mensagem de erro e retorna false
                MessageBox.Show("Erro ao atualizar aluno: " + ex.Message);
            }

            return false;
        }


        // Função que retorna uma DataTable com os dados dos alunos filtrados por um determinado texto e filtro
        public DataTable listAlunos(string text, string filtro)
        {
            try
            {
                // Cria uma nova conexão com o banco de dados
                Conexao con = new Conexao();

                // Abre a conexão
                con.conectar();

                // Monta a consulta SQL para buscar os dados dos alunos utilizando o filtro
                string sql = "SELECT * FROM Alunos WHERE " + filtro + " LIKE @text";

                // Cria um novo adaptador de dados SQLite e passa a consulta e conexão como parâmetros
                SQLiteDataAdapter data = new SQLiteDataAdapter(sql, con.conect);

                // Adiciona o parâmetro @text na consulta SQL
                data.SelectCommand.Parameters.AddWithValue("@text", text + "%");

                // Cria uma nova DataTable para armazenar os dados retornados
                DataTable dt = new DataTable();

                // Preenche a DataTable com os dados retornados pela consulta
                data.Fill(dt);

                // Fecha a conexão com o banco de dados
                con.desconectar();

                // Retorna a DataTable preenchida
                return dt;
            }
            catch (Exception ex)
            {
                // Em caso de exceção, exibe uma mensagem de erro e retorna nulo
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void DelAluno(Aluno aluno)
        {
            try
            {
                con.conectar();

                // Estabelecendo o comando
                string sql = "DELETE FROM Alunos WHERE Id=@i";

                //Estabelecendo a conexão do comando com o banco de dados
                SQLiteCommand parametros = new(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;

                parametros.Parameters.AddWithValue("@i", aluno.Id);

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

        public void InativarAluno(Aluno aluno)
        {
            try
            {
                con.conectar();

                // Estabelecendo o comando
                string sql = "UPDATE Alunos SET Ativo = 0 WHERE Id = @i";

                // Estabelecendo a conexão do comando com o banco de dados
                SQLiteCommand parametros = new(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;

                parametros.Parameters.AddWithValue("@i", aluno.Id);

                // Efetiva o comando o comando
                parametros.ExecuteNonQuery();

                // Desconectando do banco de dados
                con.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
