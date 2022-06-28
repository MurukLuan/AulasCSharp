using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace CadastroSimplesJson
{
    public partial class Form1 : Form
    {
        Pessoa p;
        public Form1()
        {
            InitializeComponent();

            p = new Pessoa();
        }

        private void btnCep_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCep.Text))
            {
                using(var ws = new WSCorreios.AtendeClienteClient())
                try
                {
                        var consultar = ws.consultaCEP(txtCep.Text.Trim());
                        txtBairro.Text = consultar.bairro;
                        txtCidade.Text = consultar.cidade;
                        txtEndereco.Text = consultar.end;
                        txtUf.Text = consultar.uf;
                }
                catch (Exception ex)
                {
                        MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Digite um CEP válido!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBairro.Text = string.Empty;
            txtCep.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtdataNascimento.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtUf.Text = string.Empty;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           
            p.Nome = txtNome.Text;
            p.DataNascimento = txtdataNascimento.Value;
            p.Telefone = txtTelefone.Text;
            p.Cpf = txtCpf.Text;
            p.Cep = txtCep.Text;
            p.Endereco = txtEndereco.Text;
            p.Bairro = txtBairro.Text;
            p.Cidade = txtCidade.Text;
            p.Uf = txtUf.Text;

            Listar();
        }

        public void Listar()
        {
            listaCadastrado.Items.Add(p.Nome);
        }

        string arquivo = @"C:\temp\serializado_teste.json";

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            FileStream criaArquivo = File.Create(arquivo);
            JsonSerializer.SerializeAsync(criaArquivo, p);
            criaArquivo.Dispose();
        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            string ler = File.ReadAllText(arquivo);
            p = JsonSerializer.Deserialize<Pessoa>(ler);

            listaArquivo.Items.Add($"Nome: {p.Nome}");
        }
    }
}
