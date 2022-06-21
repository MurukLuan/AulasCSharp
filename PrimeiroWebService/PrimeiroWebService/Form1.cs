using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace PrimeiroWebService
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCep.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                    try
                    {
                        Teste salvatemp = new Teste();
                        var consulta = ws.consultaCEP(txtCep.Text.Trim());

                        txtEstado.Text = consulta.uf;
                        txtEstado.Text = consulta.uf;
                        txtRua.Text = consulta.end;
                        txtCidade.Text = consulta.cidade;
                        txtBairro.Text = consulta.bairro;

                        var teste = new Teste
                        {
                            rua = consulta.end,
                            cidade = consulta.cidade,
                            cep = consulta.cep,
                            estado = consulta.uf,
                            bairro = consulta.bairro
                            
                        };
                        /*string jsonString = JsonSerializer.Serialize(teste);
                        MessageBox.Show(jsonString);*/
                        

                        string arquivo = @"C:\temp\teste.json";
                        FileStream criarArquivo = File.Create(arquivo);
                        JsonSerializer.SerializeAsync(criarArquivo, teste);
                        criarArquivo.Dispose();
                        //MessageBox.Show(File.ReadAllText(arquivo));

                        /*lendo*/
                        string arquivo2 = @"C:\temp\novo.json";
                        
                        Teste t2 = new Teste();
                        string lendo = File.ReadAllText(arquivo2);
                        t2 = JsonSerializer.Deserialize<Teste>(lendo);

                        textBox1.Text = $"Bairro: {t2.bairro}";

                        /*criando arquivo com utf-8*/
                        /*string arquivo3 = @"C:\temp\novoutf8.json";
                        FileStream cria2 = File.Create(arquivo3);
                        byte[] jsonUtf8 = JsonSerializer.SerializeToUtf8Bytes(t2);
                        JsonSerializer.SerializeAsync(cria2, jsonUtf8);
                        cria2.Dispose();

                        string ler = File.ReadAllText(arquivo3);
                        Teste des = JsonSerializer.Deserialize<Teste>(ler);
   
                        var utf = new Utf8JsonReader();


                        richTextBox1.Text = t2.bairro;*/

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            }
            else
            {
                MessageBox.Show("Informe um CEP válido!",
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCep.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtRua.Text = string.Empty;
        }

        

    }
}
