namespace Teste_GFT.Classes
{
    public abstract class Conta
    {
        public int numero {get; set;}
        public string titular {get; set;}
        public double saldo {get; set;}

        private double Rendimento(double rendimentoMensal)
        {
            return rendimentoMensal;
            
        }

    }
}