
namespace IntroducaoInterface.Services
{
    class ImpostoEstacionamento : ITaxas
    {
        public double ImpostoEst(double valor)
        {
            if (valor <= 50.00)
            {
                return valor * 0.05;
            }
            else
            {
                return valor * 0.10;
            }
        }
    }
}
