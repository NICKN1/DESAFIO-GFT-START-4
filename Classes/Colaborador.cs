namespace Teste_GFT.Classes
{
    public abstract class Colaborador
    {
       

        public string nome {get; set;} 
        public int idade {get; set;}
        public double salario {get; set;}
        public int grauInstrucao {get; set;}

        
        public double Bonificacao()
    {
        return this.salario;
    }

    }
}