using Sistema_almoço_alunos.src.Entities;
using Sistema_almoço_alunos.src.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_almoço_alunos.src.Controllers
{
    internal class ControllerAge
    {
        ServiceAge serviceAge = new ServiceAge();

        public DataTable ListarAgendamentos(int id, string mes, string ano)
        {
            DataTable consulta = new();
            if (id > 0)
            {
                consulta = serviceAge.listAgendamentos(id, mes, ano);
            }
            else
            {
                consulta = serviceAge.listGeralAgendamentos(mes, ano);
            }


            return consulta;
        }

        public void salvarAgendamento(Agendamento age)
        {
            if (age.getid() > 0)
            {
                serviceAge.AtualizarAgendamento(age);
            }
            else
            {
                serviceAge.SalvarAgendamento(age);
            }
        }

        public int Verificar_Agendamentos_por_plano(int id)
        {
            int verificacao = serviceAge.ProcurarAgeUsaPl(id);

            return verificacao;
        }

        public void DeletarAgendamento(Agendamento agendamento)
        {
            // Avisando usuario da exclusão dos dados
            DialogResult confirm = MessageBox.Show("Tem certeza que deseja continuar?", "Excluir Agendamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            //prosseguir se usuario permitir
            if (confirm.ToString().ToUpper() == "YES")
            {
                serviceAge.DelAgendamento(agendamento);

            }
        }

        public double SomaTotal(DataTable dt)
        {
            double total = serviceAge.SomaTotal(dt);

            return total;
        }
        public DataTable relatorio(string nome, string mes, string ano)
        {
            ControllerStu controllerStu = new();

            DataTable dt = new();

            dt.Columns.Add("Nome do aluno", typeof(string));
            dt.Columns.Add("Valor total", typeof(double));

            // Selecionar todos os alunos
            DataTable dtAluno = controllerStu.listAlunos(nome, "Nome");

            dt = listagem(dtAluno, mes, ano);

            return dt;
        }

        public DataTable listagem(DataTable dtAluno, string mes, string ano)
        {

            DataTable dt = new();

            dt.Columns.Add("Nome do aluno", typeof(string));
            dt.Columns.Add("Valor total", typeof(double));
            // Para cada aluno, selecionar todos os agendamentos
            for (int i = 0; i < dtAluno.Rows.Count; i++)
            {
                // Pegar o ID do aluno
                Aluno student = new Aluno();
                student.setid(Convert.ToInt32(dtAluno.Rows[i]["Id"]));
                student.setnome(Convert.ToString(dtAluno.Rows[i]["Nome"]));

                // Consultar os agendamentos do aluno
                DataTable dtAgendamento = ListarAgendamentos(student.getid(), mes, ano); ;

                // Fazer soma total dos agendamentos
                Double somatotal = SomaTotal(dtAgendamento);
                // Acrescentar a tabela
                if (somatotal > 0)
                    dt.Rows.Add(student.getnome(), Math.Round(somatotal, 2));
            }

            return dt;

        }
    }
}
