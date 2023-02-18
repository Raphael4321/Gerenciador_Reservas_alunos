namespace Sistema_almoço_alunos.src.Entities
{
    public class Plano
    {
        private int Id;
        private string Nome;
        private double Valor;
        private string Inicio;
        private string Fim;
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
