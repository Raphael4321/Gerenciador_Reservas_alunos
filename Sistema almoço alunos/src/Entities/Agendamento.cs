using System;

namespace Sistema_almoço_alunos.src.Entities
{
    internal class Agendamento
    {
        private int id;

        private int idAluno;

        private DateTime data;

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


    }
}
