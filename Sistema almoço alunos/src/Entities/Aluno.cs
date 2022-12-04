using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_almoço_alunos.src.Entities
{
    public class Aluno
    {

        private int Id;
        private string Nome;
        private string Responsavel;
        private string Telefone;

        public int getid()
        {
            return Id;
        }

        public void setid(int id)
        {
            this.Id = id;
        }

        public string getnome()
        {
            return Nome;
        }

        public void setnome(string nome)
        {
            this.Nome = nome;
        }

        public string getresponsavel()
        {
            return Responsavel;
        }

        public void setresponsavel(string responsavel)
        {
            this.Responsavel = responsavel;
        }

        public string gettelefone()
        {
            return Telefone;
        }

        public void settelefone(string telefone)
        {
            this.Telefone = telefone;
        }

       
        public string AlunoSerializar(Aluno aluno)
        {
            return JsonConvert.SerializeObject(aluno);
        }

        public static Aluno AlunoDesserializar(string path)
        {
            string str = OpenFileAluno(path);
            if (str.Substring(0, 5) != "Falha")
            {
                return JsonConvert.DeserializeObject<Aluno>(str);
            }
            else
            {
               Aluno aluno = new Aluno();
                aluno.Nome = str;
                return aluno;
            }
        }

        public static List<Aluno> AlunoDesserializarLista(string path)
        {
            string str = OpenFileAluno(path);
            if (str.Substring(0,5) != "Falha")
            {
                return JsonConvert.DeserializeObject<List<Aluno>>(str);
            }
            else
            {
                List<Aluno> lista = new List<Aluno>();
                Aluno aluno = new Aluno();
                aluno.Nome = str;
                lista.Add(aluno);
                aluno.Nome = str;
                return lista;
            }
        }



        public bool SalvarLista(List<Aluno> alunos, string path)
        {
            var strjson = JsonConvert.SerializeObject(alunos, Formatting.Indented);
            return SaveFile(strjson, path);
        }

        public static Aluno AlunoDeserializar(string Json)
        {
            return JsonConvert.DeserializeObject<Aluno>(Json);
        }

        public bool SaveFile(string strjson, string path)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(strjson);
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("erro: "+ ex);
                return false;
            }
        }

        private static string OpenFileAluno(string path)
        {
            try
            {
                string str = "";

                using (StreamReader sr = new StreamReader(path))
                {
                    str = sr.ReadToEnd();
                }

                return str;

            }
            catch (Exception ex)
            {
                return "falha: " +ex.Message;
            }
        }


    }
}
