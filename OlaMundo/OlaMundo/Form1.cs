using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
        

        private void btnResposta_Click(object sender, EventArgs e)
        {
            StartQ();
            btnIniciar.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ChecarAsRespostas())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("Você conseguiu, está tudo certo!",
                                "Parabens!");
                btnIniciar.Enabled = true;
            }
            else if (tempoRestante > 0)
            {
                // If CheckTheAnswer() returns false, keep counting
                // down. Decrease the time left by one second and 
                // display the new time left by updating the 
                // Time Left label.
                tempoRestante = tempoRestante - 1;
                tempo.Text = tempoRestante + " segundos";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                tempo.Text = "Seu tempo acabou!";
                MessageBox.Show("Você não conseguiu a tempo.", "Desculpe!");
                resSomar.Value = somar1 + somar2;
                resSub.Value = subtrair1 - subtrair2;
                resMult.Value = mult1 * mult2;
                resDiv.Value = dividir1 / dividir2;
                btnIniciar.Enabled = true;
            }
        }
    }
}
