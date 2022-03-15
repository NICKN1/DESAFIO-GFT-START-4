namespace Teste_GFT.Classes
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }
        public double Rendimento(double saldo)
        {
            saldo = saldo * 0.05;
            saldo = saldo - 0.75;
            return saldo;
            
        }
    }
}