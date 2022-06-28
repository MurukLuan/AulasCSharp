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

namespace JsonTeste
{

    public partial class Form1 : Form
    {
        Pessoa p;
        public Form1()
        {
            InitializeComponent();
            p = new Pessoa();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCep.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                    try
                    {
                        var consulta = ws.consultaCEP(txtCep.Text.Trim());
                        txtUF.Text = consulta.uf;
                        txtEndereco.Text = consulta.end;
                        txtCidade.Text = consulta.cidade;
                        txtBairro.Text = consulta.bairro;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            }
            else
            {
                MessageBox.Show("informe um cep valido");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBairro.Text = string.Empty;
            txtCep.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtDataNascimento.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtUF.Text = string.Empty;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            p.Nome = txtNome.Text;
            p.DataNascimento = txtDataNascimento.Value;
            p.Telefone = txtTelefone.Text;
            p.Cep = txtCep.Text;
            p.Endereco = txtEndereco.Text;
            p.Cidade = txtCidade.Text;
            p.Bairro = txtBairro.Text;
            p.Uf = txtUF.Text;

            Listar();
        }

        private void Listar()
        {
            cadastrado.Text = p.Nome;

        }

        string arquivo = @"C:\temp\serializado.json";
        private void btnSerializar_Click(object sender, EventArgs e)
        {

            
            FileStream criarArquivo = File.Create(arquivo);
            JsonSerializer.SerializeAsync(criarArquivo, p);
            criarArquivo.Dispose();
        }

        private void btnDeserializar_Click(object sender, EventArgs e)
        {
            
            string ler = File.ReadAllText(arquivo);
            p = JsonSerializer.Deserialize<Pessoa>(ler);

            convertido.Text = $"Nome: {p.Nome}";
        }
    }
}
