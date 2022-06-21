<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClienteSemCrud
{
    public partial class Form1 : Form
    {        
        List<Cliente> clientes;
        public Form1()
        {
            InitializeComponent();

            clientes = new List<Cliente>();

            estadoCivil.Items.Add("Casado");
            estadoCivil.Items.Add("Solteiro");
            estadoCivil.Items.Add("Viuvo");

            estadoCivil.SelectedIndex = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioM.Checked = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
       
            int index = -1;

            foreach (Cliente cliente in clientes)
            {
                if(cliente.Nome == txtNome.Text)
                {
                    index = clientes.IndexOf(cliente);
                }
            }

            if(txtNome.Text == "")
            {
                MessageBox.Show("O campo nome precisa ser preenchido!");
            }
            if(txtEndereco.Text == "")
            {
                MessageBox.Show("O campo Endereço precisa ser preenchido!");
            }
            if(txtTelefone.Text == "(  )     -")
            {
                MessageBox.Show("o campo telefone precisa ser preenchido!");
            }

            char sexo;

            if (radioM.Checked)
            {
                sexo = 'M';
            }else if (radioF.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }

            Cliente cl = new Cliente();
            cl.Nome = txtNome.Text;
            cl.DataNascimento = dateTimePicker1.Value;
            cl.Telefone = txtTelefone.Text;
            cl.Sexo = sexo;

            if (index < 0)
            {
                clientes.Add(cl);
            }
            else
            {
                clientes[index] = cl;
            }

            btnLimpar_Click(btnLimpar, EventArgs.Empty);

            Listar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            dateTimePicker1.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";

            radioM.Checked = true;
            radioF.Checked = false;
            radioO.Checked = false;

            txtNome.Focus();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {           
            int indice = lista.SelectedIndex;

            clientes.RemoveAt(indice);           
            
            Listar();
        }

        private void Listar()
        {            
            lista.Items.Clear();  
            
            foreach(Cliente c in clientes)
            {
                lista.Items.Add(c.Nome);
            }            
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClienteSemCrud
{
    public partial class Form1 : Form
    {        
        List<Cliente> clientes;
        public Form1()
        {
            InitializeComponent();

            clientes = new List<Cliente>();

            estadoCivil.Items.Add("Casado");
            estadoCivil.Items.Add("Solteiro");
            estadoCivil.Items.Add("Viuvo");

            estadoCivil.SelectedIndex = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioM.Checked = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
       
            int index = -1;

            foreach (Cliente cliente in clientes)
            {
                if(cliente.Nome == txtNome.Text)
                {
                    index = clientes.IndexOf(cliente);
                }
            }

            if(txtNome.Text == "")
            {
                MessageBox.Show("O campo nome precisa ser preenchido!");
            }
            if(txtEndereco.Text == "")
            {
                MessageBox.Show("O campo Endereço precisa ser preenchido!");
            }
            if(txtTelefone.Text == "(  )     -")
            {
                MessageBox.Show("o campo telefone precisa ser preenchido!");
            }

            char sexo;

            if (radioM.Checked)
            {
                sexo = 'M';
            }else if (radioF.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }

            Cliente cl = new Cliente();
            cl.Nome = txtNome.Text;
            cl.DataNascimento = dateTimePicker1.Value;
            cl.Telefone = txtTelefone.Text;
            cl.Sexo = sexo;

            if (index < 0)
            {
                clientes.Add(cl);
            }
            else
            {
                clientes[index] = cl;
            }

            btnLimpar_Click(btnLimpar, EventArgs.Empty);

            Listar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            dateTimePicker1.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";

            radioM.Checked = true;
            radioF.Checked = false;
            radioO.Checked = false;

            txtNome.Focus();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {           
            int indice = lista.SelectedIndex;

            clientes.RemoveAt(indice);           
            
            Listar();
        }

        private void Listar()
        {            
            lista.Items.Clear();  
            
            foreach(Cliente c in clientes)
            {
                lista.Items.Add(c.Nome);
            }            
        }
    }
}
>>>>>>> 64b6159dd6f7bbe03106492c82cefb0e774ba4f8
