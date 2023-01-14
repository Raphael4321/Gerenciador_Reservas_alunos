using Sistema_almoço_alunos.src.Utils;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_almoço_alunos.src.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;

namespace Sistema_almoço_alunos.src.Services
{
    internal class ServicePl
    {
        Conexao con = new Conexao();
        public void savePl(Plano plano)
        {
            // Conectando ao banco de dados
            con.conectar();

            // Estabelecendo o comando
            string sql = "INSERT INTO Plano (Nome, Valor) values(@n, @v)";

            //Estabelecendo a conexão do comando com o banco de dados
            SQLiteCommand parametros = new SQLiteCommand(con.conect);

            // Estabelecendo o texto do comando e o que cada @ significa a seguir
            parametros.CommandText = sql;

            parametros.Parameters.AddWithValue("@n", plano.getnome());
            parametros.Parameters.AddWithValue("@v", plano.getvalor());


            //Efetiva o comando o comando
            parametros.ExecuteNonQuery();

            //Descondectando do banco de dados
            con.desconectar();

  
        }

        public DataTable ListaPlanos()
        {
            try
            {
                Conexao con = new Conexao();

                con.conectar();
                string sql = "SELECT * FROM Plano";
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

        public string SelectPlano(string id)
        {
            try
            {
                Conexao con = new Conexao();

                con.conectar();
                string sql = "SELECT Nome FROM Plano WHERE Id = '" + id + "'";
                SQLiteDataAdapter data = new SQLiteDataAdapter(sql, con.conect);
                DataTable dt = new DataTable();

                data.Fill(dt);

                Plano pl = new Plano();

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    pl.setnome(dt.Rows[i]["Nome"].ToString());
                }


                con.desconectar();
                return pl.getnome();
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
                Conexao con = new Conexao();

                con.conectar();
                string sql = "SELECT Valor FROM Plano WHERE Id = '"+id+"'";
                SQLiteDataAdapter data = new SQLiteDataAdapter(sql, con.conect);
                DataTable dt = new DataTable();

                data.Fill(dt);

                Plano pl = new Plano();

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
    }
}
