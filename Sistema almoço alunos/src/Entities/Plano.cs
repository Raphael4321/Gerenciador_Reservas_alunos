using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_almoço_alunos.src.Entities
{
    public class Plano
    {
        private int Id;
        private string Nome;
        private double Valor;

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

        public double getvalor()
        {
            return Valor;
        }

        public void setvalor(double valor)
        {
            this.Valor = valor;
        }


    }
}
