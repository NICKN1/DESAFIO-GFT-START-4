namespace Teste_GFT.Classes
{
    public class Supervisor : Colaborador
    {
        public Supervisor (string nome, int idade, double salario, int grauInstrucao)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;
            this.grauInstrucao = grauInstrucao;
        }

        public double Bonificacao(double salario, int grauInstrucao)
        {
            
            salario = (salario + 500.00) * grauInstrucao * 3;
            return salario;
        }
    }
}