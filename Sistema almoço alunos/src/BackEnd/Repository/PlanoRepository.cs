using Sistema_almoço_alunos.src.Entities;
using Sistema_almoço_alunos.src.Utils;
using System;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace Sistema_almoço_alunos.src.Repository
{
    public class PlanoRepository
    {
        Conexao con = new();

        public void savePl(Plano plano)
        {
            try
            {
                // Conectando ao banco de dados
                con.conectar();

                // Inserindo o comando
                string sql = "INSERT INTO Plano (Nome, Valor, Inicio, Fim) values(@n, @v, @i, @f)";

                //Estabelecendo a conexão do comando com o banco de dados
                SQLiteCommand parametros = new(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;

                parametros.Parameters.AddWithValue("@n", plano.Nome);
                parametros.Parameters.AddWithValue("@v", plano.Valor);
                parametros.Parameters.AddWithValue("@i", plano.Inicio);
                parametros.Parameters.AddWithValue("@f", plano.Fim);

                //Efetiva o comando o comando
                parametros.ExecuteNonQuery();

                //Desconectando do banco de dados
                con.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public void updatePL(Plano plano)
        {
            try
            {
                con.conectar();

                string sql = "Update Plano SET Nome = @n, Valor = @v, Inicio = @in, Fim = @f WHERE Id=@i";

                SQLiteCommand parametros = new(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;

                parametros.Parameters.AddWithValue("@i", plano.Id);
                parametros.Parameters.AddWithValue("@n", plano.Nome);
                parametros.Parameters.AddWithValue("@v", plano.Valor);
                parametros.Parameters.AddWithValue("@in", plano.Inicio);
                parametros.Parameters.AddWithValue("@f", plano.Fim);

                //Efetiva o comando o comando
                parametros.ExecuteNonQuery();

                //Desconectando do banco de dados
                con.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        // Método que lista os planos com base em um filtro de texto
        public DataTable ListarPlanos(string text)
        {
            try
            {
                // Cria uma nova conexão com o banco de dados
                Conexao con = new Conexao();

                // Abre a conexão
                con.conectar();

                // Monta a consulta SQL para buscar os dados dos planos utilizando o filtro
                string sql = "SELECT * FROM Plano WHERE Nome LIKE @text";

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

        // Método que seleciona um plano com base no seu ID
        public Plano SelectPlano(string id)
        {
            try
            {
                // Inicia conexão com o banco de dados
                Conexao con = new Conexao();
                con.conectar();

                // Seleciona o registro da tabela Plano com o id especificado
                string sql = "SELECT * FROM Plano WHERE Id = '" + id + "'";
                SQLiteDataAdapter data = new SQLiteDataAdapter(sql, con.conect);

                // Cria um objeto DataTable e preenche com os dados da consulta
                DataTable dt = new DataTable();
                data.Fill(dt);

                // Cria um objeto Plano e preenche com os dados do registro selecionado
                Plano pl = new Plano();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    pl.Id = Convert.ToInt32(dt.Rows[i]["Id"].ToString());
                    pl.Nome = dt.Rows[i]["Nome"].ToString();
                    pl.Valor = Convert.ToDouble(dt.Rows[i]["Valor"].ToString());
                    DateTime hora = Convert.ToDateTime(dt.Rows[i]["Inicio"].ToString());
                    pl.Inicio = Convert.ToString(hora.TimeOfDay);
                    hora = Convert.ToDateTime(dt.Rows[i]["Fim"].ToString());
                    pl.Fim = Convert.ToString(hora.TimeOfDay);
                }

                // Encerra conexão com o banco de dados e retorna o objeto Plano
                con.desconectar();
                return pl;
            }
            catch (Exception ex)
            {
                // Em caso de erro, mostra a mensagem na tela e retorna null
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        // Método que retorna o valor de um plano com base no seu ID
        public Double SelecionadoValor(String id)
        {
            try
            {
                // Inicia conexão com o banco de dados
                Conexao con = new Conexao();
                con.conectar();

                // Seleciona o valor do registro da tabela Plano com o id especificado
                string sql = "SELECT Valor FROM Plano WHERE Id = '" + id + "'";
                SQLiteDataAdapter data = new SQLiteDataAdapter(sql, con.conect);

                // Cria um objeto DataTable e preenche com os dados da consulta
                DataTable dt = new DataTable();
                data.Fill(dt);

                // Cria um objeto Plano e preenche com o valor do registro selecionado
                Plano pl = new Plano();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    pl.Valor = Convert.ToDouble(dt.Rows[i]["Valor"].ToString());
                }

                // Encerra conexão com o banco de dados e retorna o valor do objeto Plano
                con.desconectar();
                return pl.Valor;
            }
            catch (Exception ex)
            {
                // Em caso de erro, mostra a mensagem na tela e retorna 0
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        // Deleta um plano do banco de dados baseado em seu ID
        public void deletarPL(int id)
        {
            try
            {
                // Conectando ao banco de dados
                con.conectar();

                // Estabelecendo o comando
                string sql = "DELETE FROM Plano WHERE Id = @i";

                //Estabelecendo a conexão do comando com o banco de dados
                SQLiteCommand parametros = new SQLiteCommand(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;

                parametros.Parameters.AddWithValue("@i", id);

                //Efetiva o comando o comando
                parametros.ExecuteNonQuery();

                //Desconectando do banco de dados
                con.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

    }
}

