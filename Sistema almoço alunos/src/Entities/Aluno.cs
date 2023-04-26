namespace Sistema_almoço_alunos.src.Entities
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Responsavel { get; set; }
        public string Telefone { get; set; }
        public string Turma { get; set; }
        public bool ativo { get;set; }
    }

}
