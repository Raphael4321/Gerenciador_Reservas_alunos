using Sistema_almoço_alunos.src.Utils;
using System;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using Sistema_almoço_alunos.src.Entities;

namespace Sistema_almoço_alunos.src.Services
{
    internal class ServicePl
    {
        Conexao con = new();

        public void savePl(Plano plano)
        {
            try
            {
                // Conectando ao banco de dados
                con.conectar();

                // Estabelecendo o comando
                string sql = "INSERT INTO Plano (Nome, Valor, Inicio, Fim) values(@n, @v, @i, @f)";

                //Estabelecendo a conexão do comando com o banco de dados
                SQLiteCommand parametros = new(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;

                parametros.Parameters.AddWithValue("@n", plano.getnome());
                parametros.Parameters.AddWithValue("@v", plano.getvalor());
                parametros.Parameters.AddWithValue("@i", plano.getInicio());
                parametros.Parameters.AddWithValue("@f", plano.getFim());


                //Efetiva o comando o comando
                parametros.ExecuteNonQuery();

                //Descondectando do banco de dados
                con.desconectar();
            }
            catch(Exception ex)
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

                parametros.Parameters.AddWithValue("@i", plano.getid());
                parametros.Parameters.AddWithValue("@n", plano.getnome());
                parametros.Parameters.AddWithValue("@v", plano.getvalor());
                parametros.Parameters.AddWithValue("@in", plano.getInicio());
                parametros.Parameters.AddWithValue("@f", plano.getFim());


                //Efetiva o comando o comando
                parametros.ExecuteNonQuery();

                //Descondectando do banco de dados
                con.desconectar();
            }catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }

        }

        public DataTable ListaPlanos()
        {
            try
            {
                con.conectar();
                string sql = "SELECT * FROM Plano";
                SQLiteDataAdapter data = new(sql, con.conect);
                DataTable dt = new();

                data.Fill(dt);

                con.desconectar();
                return dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public Plano SelectPlano(string id)
        {
            try
            {
                Conexao con = new();

                con.conectar();
                string sql = "SELECT * FROM Plano WHERE Id = '" + id + "'";
                SQLiteDataAdapter data = new(sql, con.conect);
                DataTable dt = new();

                data.Fill(dt);

                Plano pl = new();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DateTime hora;

                    pl.setid(Convert.ToInt32(dt.Rows[i]["Id"].ToString()));
                    pl.setnome(dt.Rows[i]["Nome"].ToString());
                    pl.setvalor(Convert.ToDouble(dt.Rows[i]["Valor"].ToString()));
                    hora = Convert.ToDateTime(dt.Rows[i]["Inicio"].ToString());
                    pl.setInicio(Convert.ToString(hora.TimeOfDay));
                    hora = Convert.ToDateTime(dt.Rows[i]["Fim"].ToString());
                    pl.setFim(Convert.ToString(hora.TimeOfDay));

                }


                con.desconectar();
                return pl;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public Double SelecionadoValor(String id)
        {
            try
            {
                Conexao con = new();

                con.conectar();
                string sql = "SELECT Valor FROM Plano WHERE Id = '"+id+"'";
                SQLiteDataAdapter data = new(sql, con.conect);
                DataTable dt = new();

                data.Fill(dt);

                Plano pl = new();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                   
                    pl.setvalor(Convert.ToDouble(dt.Rows[i]["Valor"].ToString()));
                }


                con.desconectar();
                return pl.getvalor();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public void deletarPL(int id, int verificacao)
        {
            try
            {
                // Conectando ao banco de dados
                con.conectar();

                // Estabelecendo o comando
                string sql = "DELETE FROM Plano WHERE Id = @i";

                //Estabelecendo a conexão do comando com o banco de dados
                SQLiteCommand parametros = new(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;

                parametros.Parameters.AddWithValue("@i", id);

                //Efetiva o comando o comando
                parametros.ExecuteNonQuery();

                //Descondectando do banco de dados
                con.desconectar();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
