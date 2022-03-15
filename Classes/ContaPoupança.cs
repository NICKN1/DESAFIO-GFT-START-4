namespace Teste_GFT.Classes
{
    public class ContaPoupança : Conta
    {

        public ContaPoupança(int numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }
        public double Rendimento(double saldo)
        {
            saldo = saldo * 0.07;
            return saldo;
            
        }
    }
}