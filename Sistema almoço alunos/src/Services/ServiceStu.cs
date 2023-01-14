using Sistema_almoço_alunos.src.Entities;
using Sistema_almoço_alunos.src.Utils;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Sistema_almoço_alunos.src.Utils.dto;
using System.Net.NetworkInformation;
using static System.Net.Mime.MediaTypeNames;

namespace Sistema_almoço_alunos.src.Services
{
    internal class ServiceStu
    {
        Conexao con = new Conexao();
        public Aluno buscarPorId(int id)
        {
            Aluno aluno = new Aluno();

            DataTable dt = new DataTable();

            con.conectar();

            string sql = "SELECT * FROM Aluno WHERE Id = '" + id + "'";

            SQLiteDataAdapter data = new SQLiteDataAdapter(sql, con.conect);

            con.desconectar();

            data.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                int novoid = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
                string nome = dt.Rows[0].ItemArray[1].ToString();
                string respo = dt.Rows[0].ItemArray[2].ToString();
                string telefone = dt.Rows[0].ItemArray[3].ToString();

                aluno.setid(novoid);
                aluno.setnome(dt.Rows[0].ItemArray[1].ToString());
                aluno.setresponsavel(dt.Rows[0].ItemArray[2].ToString());
                aluno.settelefone(dt.Rows[0].ItemArray[3].ToString());

            }

            return aluno;
        }


        // salvar aluno
        public bool SalvarAluno(Aluno aluno)
        {
            // Instanciando a variavel onde o comando é guardado
            string sql;

            //se for encontrado Um Id no aluno, então ele ja existe e se trata de uma edição
            if (aluno.getid() > 0)
            {
                con.conectar();

                sql = "Update Alunos SET Nome = @n, Responsavel = @r, Telefone = @t, Turma = @t2 WHERE Id=@i";

                SQLiteCommand parametros = new SQLiteCommand(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;

                parametros.Parameters.AddWithValue("@i", aluno.getid());
                parametros.Parameters.AddWithValue("@n", aluno.getnome());
                parametros.Parameters.AddWithValue("@r", aluno.getresponsavel());
                parametros.Parameters.AddWithValue("@t", aluno.gettelefone());
                parametros.Parameters.AddWithValue("@t2", aluno.getTurma());

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
                sql = "INSERT INTO Alunos (Nome, Responsavel, Telefone, Turma) values(@n, @r, @t, @t2)";

                //Estabelecendo a conexão do comando com o banco de dados
                SQLiteCommand parametros = new SQLiteCommand(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;

                parametros.Parameters.AddWithValue("@n", aluno.getnome());
                parametros.Parameters.AddWithValue("@r", aluno.getresponsavel());
                parametros.Parameters.AddWithValue("@t", aluno.gettelefone());
                parametros.Parameters.AddWithValue("@t2", aluno.getTurma());

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

        public DataTable listAlunos()
        {
            try
            {
                Conexao con = new Conexao();

                con.conectar();
                string sql = "SELECT * FROM Alunos";
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

        public DataTable listAlunosEsp(string text, string filtro)
        {
            try
            {
                Conexao con = new Conexao();

                con.conectar();

                string sql = "SELECT * FROM Alunos WHERE "+filtro+" LIKE '"+text+"%'";

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

        public void DelAluno(Aluno aluno)
        {
            try
            {
                con.conectar();

                // Estabelecendo o comando
                string sql = "DELETE FROM Alunos WHERE Id=@i";

                //Estabelecendo a conexão do comando com o banco de dados
                SQLiteCommand parametros = new SQLiteCommand(con.conect);

                // Estabelecendo o texto do comando e o que cada @ significa a seguir
                parametros.CommandText = sql;

                parametros.Parameters.AddWithValue("@i", aluno.getid());

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

        public List<string> listFiltro()
        {
            List<string> filtro = new List<string>();

            string dado = "Nome";
            filtro.Add(dado);
            dado = "Turma";
            filtro.Add(dado);
            dado = "Telefone";
            filtro.Add(dado);
            dado = "Responsavel";
            filtro.Add(dado);

            return filtro;
        }
    }
}
