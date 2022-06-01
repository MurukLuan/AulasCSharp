using System;


namespace InterfaceExplicacaoSimples.Entities
{
    public class CarroSedan : CarroFactoryMethod
    {
        protected override Carro CriarCarro(string tipo)
        {
            switch (tipo)
            {
                case "S":
                    return new CarroSedan(); 
                case "H":
                    return new CarroHatch();
                default:
                    return null;
            }
        }
    }
}
