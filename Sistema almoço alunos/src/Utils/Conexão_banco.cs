using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Sistema_almoço_alunos.src.Utils
{
    internal class Conexao
    {
        public SQLiteConnection conect= new SQLiteConnection("Data Source = ControleAlunos.sdb");

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
