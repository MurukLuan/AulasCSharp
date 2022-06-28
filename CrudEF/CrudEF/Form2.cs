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
    public partial class Form2 : Form
    {
        Acao.Operacao _valor;
        public Form2(Aluno aluno, Acao.Operacao valor)
        {
            _valor = valor;

            InitializeComponent();

            ExibirAlunos(aluno);
        }

        private void ExibirAlunos(Aluno aluno)
        {
            txtId.Text = aluno.AlunoId.ToString();
            txtNome.Text = aluno.Nome;
            txtEmail.Text = aluno.Email;

            txtNome.Focus();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var codigo = Convert.ToInt32(txtId.Text);

            if (_valor == Acao.Operacao.edit)
            {
                using (var ctx = new ApplicationDataBaseContext())
                {
                    var aluno = ctx.Alunos.First(a => a.AlunoId == codigo);
                    aluno.Nome = txtNome.Text;
                    aluno.Email = txtEmail.Text;
                    ctx.SaveChanges();
                }
            }
            else if (_valor == Acao.Operacao.del)
            {
                using (var ctx = new ApplicationDataBaseContext())
                {
                    var aluno = ctx.Alunos.First(a => a.AlunoId == codigo);
                    ctx.Remove(aluno);
                    ctx.SaveChanges();
                }
            }
            else if (_valor == Acao.Operacao.add)
            {
                using (var ctx = new ApplicationDataBaseContext())
                {
                    var aluno = new Aluno();
                    aluno.Nome = txtNome.Text;
                    aluno.Email = txtEmail.Text;
                    ctx.Add(aluno);
                    ctx.SaveChanges();
                }
            }
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
