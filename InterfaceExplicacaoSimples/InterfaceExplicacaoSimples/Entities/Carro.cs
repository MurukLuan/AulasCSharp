using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace InterfaceExplicacaoSimples.Entities
{
    public abstract class Carro
    {
        protected string Tipo { get; set; }
        protected string Marca;
        protected string Modelo;
        protected string som;
        protected string cor;
        protected string roda;
        protected DateTime data = DateTime.Now;

        protected ArrayList opcionais = new ArrayList();

        public string PrepaparParaTransporte()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Preparando o carro: " + Marca + " " + Modelo);
            sb.Append("\nsom: " + som);
            sb.Append("\nroda: " + roda);
            sb.Append("\ncor: " + cor);
            sb.Append("Carro montado: \n");

            foreach (string carroMontado in opcionais)
            {
                sb.Append("\t" + carroMontado + "\n");
            }
            sb.Append(Transportar());
            sb.Append(Entregar());

            //sb.Append(Transportar());

            return sb.ToString();
        }

        public virtual string Transportar()
        {
            
            data.AddDays(7);
            return "O carro esta sendo transportado, data prevista para entrega: " + data;
        }

        public virtual string Entregar()
        {
            data.AddDays(8);
            return "O carro foi entregue no dia: " + data;
        }
    }
}
