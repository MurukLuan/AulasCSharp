using AtividadeEnumsCorrigida.Entities.Enums;

namespace AtividadeEnumsCorrigida.Entities
{
    class Carro
    {/*cor, tipo do cambio, tipo de combustível, ano, modelo e marca;*/
        public string Cor { get; set; }
        public Cambio TipoCambio { get; set; }
        public Combustivel TipoCombustivel { get; set; }
        public int Ano { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }

        public Carro()
        {
        }

        public Carro(string cor, Cambio tipoCambio, Combustivel tipoCombustivel, int ano, string modelo, string marca)
        {
            Cor = cor;
            TipoCambio = tipoCambio;
            TipoCombustivel = tipoCombustivel;
            Ano = ano;
            Modelo = modelo;
            Marca = marca;
        }

        public void TipoComb(int comb)
        {
            if (comb <= 3 && comb >= 0) { 
                TipoCombustivel = (Combustivel)comb;
            }
            else
            {
                System.Console.WriteLine("Tipo de combustivel invalido!");
            }

        }
        public void TipoCamb(int camb)
        {
            if (camb <= 3 && camb >= 0)
            {
                TipoCambio = (Cambio)camb;
            }
            else
            {
                System.Console.WriteLine("Tipo de cambio invalido!");
            }
                

        }

        public override string ToString()
        {
            return "Modelo: " + Modelo
                + "\nMarca: " + Marca
                + "\nAno: " + Ano
                + "\nTipo combustivel: " + TipoCombustivel
                + "\nCambio: " + TipoCambio;
        }
    }
}
