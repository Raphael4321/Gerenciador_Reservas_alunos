using Sistema_almoço_alunos.src.Entities;
using Sistema_almoço_alunos.src.Utils;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Sistema_almoço_alunos.src.Services
{
    internal class ServiceAge
    {
        Conexao con = new();

        public void AtualizarAgendamento(Agendamento age)
        {
            try
            {
                // Conecta ao bando de dados
                con.conectar();

                int ano = Convert.ToInt32(age.getdata().Year);

                // Comando para atualizar dados do agendamento
                string sql = "Update Agendamento SET Data = @d, Ano = @a, IdPlano = @p WHERE Id=@id";

                SQLiteCommand parametros = new(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;

                parametros.Parameters.AddWithValue("@id", age.getid());
                parametros.Parameters.AddWithValue("@p", age.plano.getid());
                parametros.Parameters.AddWithValue("@d", age.getdata());
                parametros.Parameters.AddWithValue("@a", ano);

                //Efetiva o comando o comando
                parametros.ExecuteNonQuery();

                //Descondectando do banco de dados
                con.desconectar();
                SQLiteDataAdapter data = new(sql, con.conect);

            }
            catch(Exception e)
            {
                MessageBox.Show("erro: " + e);
            }
        }

        // salvar Agendamento (incompleto)
        public void SalvarAgendamento(Agendamento age)
        {
            try
            {
                // Instanciando a variavel onde o comando é guardado
                string sql;

                int ano = Convert.ToInt32(age.getdata().Year);

                // Conectando ao banco de dados
                con.conectar();

                // Estabelecendo o comando
                sql = "INSERT INTO Agendamento (IdAluno, IdPlano, Data, Ano) values(@i, @p, @d, @a)";

                //Estabelecendo a conexão do comando com o banco de dados
                SQLiteCommand parametros = new(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;

                parametros.Parameters.AddWithValue("@i", age.getidAluno());
                parametros.Parameters.AddWithValue("@p", age.plano.getid());
                parametros.Parameters.AddWithValue("@d", age.getdata());
                parametros.Parameters.AddWithValue("@a", ano);

                //Efetiva o comando o comando
                parametros.ExecuteNonQuery();

                //Descondectando do banco de dados
                con.desconectar();
            
                //Tenta executar o comando. Se funcionar, retorna o ok
            
                SQLiteDataAdapter data = new(sql, con.conect);
                
            }
            //Se não funcionar, retorna que não funcionou junto com uma janela dizendo o motivo
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);
            }

        }

        public DataTable listAgendamentos(int id, string mes, string ano)
        {
            try
            {
                Conexao con = new();

                con.conectar();

                // Comando para selecionar todos os agendamentos com os dados dos planose relacionados a eles, tudo baseado no aluno
                string sql = "SELECT * FROM Agendamento AS a INNER JOIN Plano AS p ON a.IdAluno = '" + id + "' AND a.Ano LIKE '" + ano + "%' AND  strftime('%m', a.Data) LIKE '" + mes + "%' AND p.Id = a.IdPlano";

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

        public DataTable listGeralAgendamentos(string mes, string ano)
        {
            try
            {
                Conexao con = new();

                con.conectar();

                string sql = "SELECT * FROM Agendamento AS a INNER JOIN Plano AS p ON a.Ano LIKE '" + ano + "%' AND  strftime('%m', a.Data) LIKE '" + mes + "%' AND p.Id = a.IdPlano";

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

        public Double SomaTotal(DataTable dt)
        {
            double soma = 0;

            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    double valor = Convert.ToDouble(dt.Rows[i]["Valor"].ToString());
                    if(valor !=0)
                    soma = soma + valor;
                }
                return Math.Round(soma, 2);
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
                SQLiteCommand parametros = new(con.conect);

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
                MessageBox.Show(ex.Message);

            }
        }

        public int ProcurarAgeUsaPl(int idPlano)
        {
            try
            {
                Conexao con = new();

                con.conectar();
                string sql = "SELECT * FROM Agendamento WHERE IdPlano = '" + idPlano + "'";
                SQLiteDataAdapter data = new(sql, con.conect);
                DataTable dt = new();

                data.Fill(dt);

                con.desconectar();

                if(dt.Rows.Count > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 2;
            }
        }
    }
}
