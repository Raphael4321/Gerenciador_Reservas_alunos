using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_almoço_alunos.src.Entities
{
    internal class Agendamento
    {
        private int id;

        private int idAluno;

        private DateTime data;

        private string Inicio;

        private string Fim;

        public Plano plano;

        public int getid()
        {
            return id;
        }

        public void setid(int id)
        {
            this.id = id;
        }

        public int getidAluno()
        {
            return idAluno;
        }

        public void setidAluno(int id)
        {
            this.idAluno = id;
        }

        public DateTime getdata()
        {
            return data;
        }

        public void setdata(DateTime data)
        {
            this.data = data;
        }

        public string getInicio()
        {
            return Inicio;
        }

        public void setInicio(string inicio)
        {
            this.Inicio = inicio;
        }

        public string getFim()
        {
            return Fim;
        }

        public void setFim(string fim)
        {
            this.Fim = fim;
        }


    }
}
