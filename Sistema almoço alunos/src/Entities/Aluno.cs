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
        private string Turma;

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

        public void setTurma(string turma)
        {
            this.Turma = turma;
        }

        public string getTurma()
        {
            return Turma;
        }

        public string gettelefone()
        {
            return Telefone;
        }

        public void settelefone(string telefone)
        {
            this.Telefone = telefone;
        }



       

      


    }
}
