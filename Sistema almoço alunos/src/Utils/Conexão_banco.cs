using System.Data.SQLite;

namespace Sistema_almoço_alunos.src.Utils
{
    internal class Conexao
    {
        public SQLiteConnection conect = new("Data Source = ControleAlunos.sdb");

        public void conectar()
        {
           
            conect.Open();
           
        }

        public void desconectar()
        {
            conect.Close();
        }

    }
}
