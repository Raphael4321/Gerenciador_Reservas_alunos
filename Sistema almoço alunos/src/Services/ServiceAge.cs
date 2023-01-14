using NUnit.Framework.Internal;
using Sistema_almoço_alunos.src.Entities;
using Sistema_almoço_alunos.src.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            //se for encontrado Um Id no aluno, então ele ja existe e se trata de uma edição
            if (age.getid() > 0)
            {
                con.conectar();

                sql = "Update Agendamento SET Data = @d, Inicio=@in, Fim=@f, Valor=@v WHERE Id=@id";

                SQLiteCommand parametros = new SQLiteCommand(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;

                parametros.Parameters.AddWithValue("@id", age.getid());
                parametros.Parameters.AddWithValue("@i", age.getidAluno());
                parametros.Parameters.AddWithValue("@d", age.getdata());
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
                sql = "INSERT INTO Agendamento (IdAluno, IdPlano, Data, Inicio, Fim, Valor) values(@i, @p, @d, @in, @f, @v)";

                //Estabelecendo a conexão do comando com o banco de dados
                SQLiteCommand parametros = new SQLiteCommand(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;

                parametros.Parameters.AddWithValue("@i", age.getidAluno());
                parametros.Parameters.AddWithValue("@p", age.plano.getid());
                parametros.Parameters.AddWithValue("@d", age.getdata());
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

        public DataTable SomaTotal(string Mes, string Ano)
        {
            try
            {
                Conexao con = new Conexao();

                con.conectar();
                string sql = "SELECT SUM(Valor) as soma FROM Agendamentos WHERE MONTH = '"+Mes+"' AND YEAR = '"+Ano+"'";
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

        public DataTable listAgendamentoEsp(int id, string mes, string ano)
        {
            try
            {
                Conexao con = new Conexao();

                con.conectar();

                string sql;

                if(mes == "")
                {
                    sql = "SELECT * FROM Agendamento AS a WHERE strftime('%y', a.Data)" +
                        " = '" + ano + "' AND IdAluno = '" + id + "'";
                }if(ano == "")
                {
                    sql = "SELECT * FROM Agendamento AS a WHERE strftime('%m', a.Data) " +
                        " = '" + mes + "' AND IdAluno = '" + id + "'";
                }
                else
                {
                    sql = "SELECT * FROM Agendamento AS a WHERE strftime('%m', a.Data) = '" + mes + "' AND strftime('%y', Data) = '" + ano + "' AND IdAluno = '" + id + "'";
                }


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
