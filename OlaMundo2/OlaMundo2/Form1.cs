using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlaMundo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCliqueAqui_Click(object sender, EventArgs e)
        {
            lblTextoBoaVinda.Text = "Olá mundo!";
            this.btnCliqueAqui.Text = "foi clicado!";
        }

        private void btnCliqueAqui_MouseEnter(object sender, EventArgs e)
        {
            btnCliqueAqui.Text = "o mouse dentro";
        }

        private void btnCliqueAqui_MouseLeave(object sender, EventArgs e)
        {
            btnCliqueAqui.Text = "clique aqui";
            btnCliqueAqui.BackColor = Color.FromArgb(255, 255, 0);
        }
    }
}
