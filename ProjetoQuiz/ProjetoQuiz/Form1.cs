using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoQuiz
{
    public partial class AtividadeQuiz : Form
    {
        public AtividadeQuiz()
        {
            InitializeComponent();
        }

        private void btnStartTeste_Click(object sender, EventArgs e)
        {
            StartQ();
            btnStartTeste.Enabled = false;
            //desativa o botão após o clique
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ChecarRespostas())
            {
                timer1.Stop();//quando acabar o tempo e as respostas
                //estiverem corretas, mostra o Messagebox abaixo
                MessageBox.Show("Você conseguiu, está tudo ceto!," +
                    "Parabéns!");
                btnStartTeste.Enabled = true; //ativa o botão novamente
            }else if(tempoRestante > 0)
            {
                //diminiu o tempo em 1 segundo, utilizando os ticks
                tempoRestante = tempoRestante - 1;
                tempo.Text = tempoRestante + " segundos";
                //mostra a mensagem no label "tempo"
            }
            else
            {
                timer1.Stop();
                tempo.Text = "Seu tempo acabou!";
                MessageBox.Show("Você não conseguiu a tempo", "Desculpe");
                //aplica o resultado nos campos de resultado
                resSoma.Value = somar1 + somar2;
                resSub.Value = sub1 - sub2;
                resMult.Value = mult1 * mult2;
                resDiv.Value = div1 / div2;
                btnStartTeste.Enabled = true;
            }

        }
    }
}
