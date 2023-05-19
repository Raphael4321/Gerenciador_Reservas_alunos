using System;

namespace Sistema_almoço_alunos.src.Entities
{
    public class Agendamento
    {
        public int Id { get; set; }

        public int IdAluno { get; set; }

        public DateTime Data { get; set; }

        public Plano Plano { get; set; }

        public int Status { get; set; }
    }

}
