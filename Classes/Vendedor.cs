namespace Teste_GFT.Classes
{
    public class Vendedor : Colaborador
    {
        public Vendedor(string nome, int idade, double salario, int grauInstrucao)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;
            this.grauInstrucao = grauInstrucao;
        }

        public double Bonificacao(double salario, int grauInstrucao)
        {
            salario = (salario + 300.00) * grauInstrucao * 4;
            return salario;
        }
    }
}