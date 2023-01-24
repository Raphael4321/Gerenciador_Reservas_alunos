using NUnit.Framework.Internal;
using Sistema_almoço_alunos.src.Entities;
using Sistema_almoço_alunos.src.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_almoço_alunos.src.Services
{
    internal class ServiceAge
    {
        Conexao con = new Conexao();

        // salvar Agendamento (incompleto)
        public bool SalvarAgendamento(Agendamento age)
        {
            // Instanciando a variavel onde o comando é guardado
            string sql;

            int ano = Convert.ToInt32(age.getdata().Year);

            //se for encontrado Um Id no aluno, então ele ja existe e se trata de uma edição
            if (age.getid() > 0)
            {
                con.conectar();

                sql = "Update Agendamento SET Data = @d, Ano = @a, Inicio=@in, Fim=@f, Valor=@v WHERE Id=@id";

                SQLiteCommand parametros = new SQLiteCommand(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;

                parametros.Parameters.AddWithValue("@id", age.getid());
                parametros.Parameters.AddWithValue("@i", age.getidAluno());
                parametros.Parameters.AddWithValue("@d", age.getdata());
                parametros.Parameters.AddWithValue("@a", ano);
                parametros.Parameters.AddWithValue("@in", age.getInicio());
                parametros.Parameters.AddWithValue("@f", age.getFim());
                parametros.Parameters.AddWithValue("@v", age.plano.getvalor());

                //Efetiva o comando o comando
                parametros.ExecuteNonQuery();

                //Descondectando do banco de dados
                con.desconectar();
            }
            // Se não encontrar, trata-se de um novo aluno que será salvo no banco de dados
            else
            {
                // Conectando ao banco de dados
                con.conectar();

                // Estabelecendo o comando
                sql = "INSERT INTO Agendamento (IdAluno, IdPlano, Data, Ano, Inicio, Fim, Valor) values(@i, @p, @d, @a, @in, @f, @v)";

                //Estabelecendo a conexão do comando com o banco de dados
                SQLiteCommand parametros = new SQLiteCommand(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;

                parametros.Parameters.AddWithValue("@i", age.getidAluno());
                parametros.Parameters.AddWithValue("@p", age.plano.getid());
                parametros.Parameters.AddWithValue("@d", age.getdata());
                parametros.Parameters.AddWithValue("@a", ano);
                parametros.Parameters.AddWithValue("@in", age.getInicio());
                parametros.Parameters.AddWithValue("@f", age.getFim());
                parametros.Parameters.AddWithValue("@v", age.plano.getvalor());


                //Efetiva o comando o comando
                parametros.ExecuteNonQuery();

                //Descondectando do banco de dados
                con.desconectar();
            }
            //Tenta executar o comando. Se funcionar, retorna o ok
            try
            {
                SQLiteDataAdapter data = new SQLiteDataAdapter(sql, con.conect);
                return true;
            }
            //Se não funcionar, retorna que não funcionou junto com uma janela dizendo o motivo
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
                return false;
            }

        }

        public DataTable listAgendamentos(int id)
        {
            try
            {
                Conexao con = new Conexao();

                con.conectar();
                string sql = "SELECT * FROM Agendamento WHERE IdAluno = '" + id +"'";
                SQLiteDataAdapter data = new SQLiteDataAdapter(sql, con.conect);
                DataTable dt = new DataTable();

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

        public DataTable listAgendamentoEsp(int id, string BuscaData)
        {
            try
            {
                Conexao con = new Conexao();

                con.conectar();

                string sql;

                DateTime convertido = Convert.ToDateTime(BuscaData);


                sql = "SELECT * FROM Agendamento WHERE Data LIKE '" + convertido + "%'";


                SQLiteDataAdapter data = new SQLiteDataAdapter(sql, con.conect);

                DataTable dt = new DataTable();

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

        public Double SomaTotal(DataTable dt)
        {
            double soma = 0;

            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    soma = soma + Convert.ToDouble(dt.Rows[i]["Valor"].ToString());

                }
                return soma;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return soma;
            }
        }

        public void DelAgendamento(Agendamento age)
        {
            try
            {
                con.conectar();

                // Estabelecendo o comando
                string sql = "DELETE FROM Agendamento WHERE Id=@i";

                //Estabelecendo a conexão do comando com o banco de dados
                SQLiteCommand parametros = new SQLiteCommand(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;

                parametros.Parameters.AddWithValue("@i", age.getid());

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

        public void DelTodos(int id)
        {
            try
            {
                con.conectar();

                // Estabelecendo o comando
                string sql = "DELETE FROM Agendamento WHERE IdAluno=@i";

                //Estabelecendo a conexão do comando com o banco de dados
                SQLiteCommand parametros = new SQLiteCommand(con.conect);

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
                MessageBox.Show(ex.Message);

            }
        }
    }
}
