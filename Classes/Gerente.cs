namespace Teste_GFT.Classes
{
    public class Gerente : Colaborador
    {
        public Gerente(string nome, int idade, double salario, int grauInstrucao)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;
            this.grauInstrucao = grauInstrucao;
        }

        public double Bonificacao(double salario, int grauInstrucao)
      {
          salario = (salario + 1000.00) * grauInstrucao * 2;
          return salario;
      }  
    }
}