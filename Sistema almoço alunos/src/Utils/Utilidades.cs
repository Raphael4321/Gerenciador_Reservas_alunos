using System.Collections.Generic;

namespace Sistema_almoço_alunos.src.Utils
{
    internal class Utilidades
    {
        
        public List<string> listFiltro()
        {
            List<string> filtro = new();

            string dado = "Nome";
            filtro.Add(dado);
            dado = "Turma";
            filtro.Add(dado);
            dado = "Telefone";
            filtro.Add(dado);
            dado = "Responsavel";
            filtro.Add(dado);

            return filtro;
        }

    }
}
