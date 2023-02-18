using System;
using System.Data;
using System.Windows.Forms;
using Sistema_almoço_alunos.src.Services;
using Sistema_almoço_alunos.src.Entities;

namespace Sistema_almoço_alunos.src.Controllers
{
    internal class ControllerStu
    {
        ServiceStu stu = new();

        public DataTable listAlunos(string dado, string filtro)
        {
            DataTable dt;

            // Executar a função que lista alunos
            dt = stu.listAlunos(dado, filtro);

            // Retornar a lista 
            return dt;
        }

        public void SalvarAluno(Aluno aluno)
        {
            try
            {
                // Instanciando a variavel onde o comando é guardado


                //se for encontrado Um Id maior que 0 no aluno, então ele ja existe e se trata de uma edição
                if (aluno.getid() > 0)
                {
                    stu.AtualizarAluno(aluno);
                }
                // Caso contrario, trata-se de um novo aluno que será salvo no banco de dados
                else
                {
                    stu.SalvarAluno(aluno);
                }

            }
            //Se não funcionar, retorna que não funcionou junto com uma janela dizendo o motivo
            catch (Exception e)
            {
                MessageBox.Show("erro: " + e);

            }
        }

        public void DeletarAluno(Aluno aluno)
        {
            // Avisando usuario da exclusão dos dados
            DialogResult confirm = MessageBox.Show("Excluir o aluno também excluirá seus agendamentos. Deseja continuar?", "Excluir Aluno", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            // Prosseguir se usuario permitir
            if (confirm.ToString().ToUpper() == "YES")
            {
                ServiceAge age = new();
                age.DelTodos(aluno.getid());
                stu.DelAluno(aluno);
            }
        }
    }
}
