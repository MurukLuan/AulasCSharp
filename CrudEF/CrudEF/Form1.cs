using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudEF.Models;

namespace CrudEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ExibirAlunos();
        }

        private void ExibirAlunos()
        {
            List<Aluno> alunos;
            //listarAlunos.Items.Clear();

            using(var ctx = new ApplicationDataBaseContext())
            {
                alunos = ctx.Alunos.ToList();
            }

            foreach(var aluno in alunos)
            {
                listarAlunos.Items.Add(aluno);
            }
        }

        private void listarAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var alunoSelecionado = (Aluno)listarAlunos.SelectedItem;

            txtId.Text = alunoSelecionado.AlunoId.ToString();
            txtNome.Text = alunoSelecionado.Nome;
            txtEmail.Text = alunoSelecionado.Email;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarAcao())
            {
                var aluno = (Aluno)listarAlunos.SelectedItem;
                Form2 form2 = new Form2(aluno, Acao.Operacao.edit);
                form2.ShowDialog();
                ExibirAlunos();
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ValidarAcao())
            {
                var aluno = (Aluno)listarAlunos.SelectedItem;
                Form2 form2 = new Form2(aluno, Acao.Operacao.del);
                form2.ShowDialog();
                ExibirAlunos();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            var aluno = new Aluno();
            Form2 form2 = new Form2(aluno, Acao.Operacao.add);
            form2.ShowDialog();
            ExibirAlunos();
        }

        public bool ValidarAcao()
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'crudAlunoDataSet.Alunos'. Você pode movê-la ou removê-la conforme necessário.
            this.alunosTableAdapter.Fill(this.crudAlunoDataSet.Alunos);

        }
    }
}
