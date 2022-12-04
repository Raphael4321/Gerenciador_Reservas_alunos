using Sistema_almoço_alunos.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_almoço_alunos.src.Utils.dto
{
    internal class ConvertAluno_Dto
    {
         public AlunoDto converter(Aluno aluno)
        {
            AlunoDto alunoDto = new AlunoDto();

            alunoDto.Id = aluno.getid();
            alunoDto.Nome = aluno.getnome();
            alunoDto.Responsavel = aluno.getresponsavel();
            alunoDto.Telefone = aluno.gettelefone();

            return alunoDto;
        }


    }
}
