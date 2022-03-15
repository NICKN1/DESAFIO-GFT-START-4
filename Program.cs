using System;
using Teste_GFT.Classes;

namespace Teste_GFT
{
    class Program
    {
        static void Desafio1()
        {
            Gerente gerente = new Gerente("José", 24, 200.00, 5);
            Supervisor supervisor = new Supervisor("Paula", 18, 100.00, 3);
            Vendedor vendedor = new Vendedor("Pedro", 35, 50.00, 1);
            
            Console.WriteLine("==GERENTE==");
            Console.WriteLine($"Nome: {gerente.nome}, Idade: {gerente.idade}, Salario {gerente.salario}, Grau de Instrução: {gerente.grauInstrucao}");
            Console.WriteLine("Bonificação Gerente: "+ gerente.Bonificacao(gerente.salario, gerente.grauInstrucao));
            Console.WriteLine(" ");
            
            Console.WriteLine("==Supervisor==");
            Console.WriteLine($"Nome: {supervisor.nome}, Idade: {supervisor.idade}, Salario {supervisor.salario}, Grau de Instrução: {supervisor.grauInstrucao}");
            Console.WriteLine("Bonificação Supervisor: " + supervisor.Bonificacao(supervisor.salario, supervisor.grauInstrucao));
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("==Vendedor==");
            Console.WriteLine($"Nome: {vendedor.nome}, Idade: {vendedor.idade}, Salario {vendedor.salario}, Grau de Instrução: {vendedor.grauInstrucao}");
            Console.WriteLine("Bonificação Vendedor: " + vendedor.Bonificacao(vendedor.salario, vendedor.grauInstrucao));
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }
        
        static void Desafio3()
        {
            ContaPoupança poupanca = new ContaPoupança(56, "Pedro", 5000.00);
            ContaCorrente corrente = new ContaCorrente(68, "Maria", 5000.00);

            Console.WriteLine("== Conta Poupança ==");
            Console.WriteLine($"Titular: {poupanca.titular}, Saldo: {poupanca.saldo} Rendimento: {poupanca.Rendimento(poupanca.saldo).ToString("F2")}");
            Console.WriteLine(" ");

            Console.WriteLine("== Conta Corrente ==");
            Console.WriteLine($"Titular: {corrente.titular}, Saldo: {corrente.saldo} Rendimento: {corrente.Rendimento(corrente.saldo).ToString("F2")}");
            Console.WriteLine(" ");
        }
        static void Desafio4()
        {
            double altura;
            double peso;
            string nome;
            double imc = 0;

            Console.WriteLine("Digite sua altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Digite Seu nome; ");
            nome = Console.ReadLine();

            altura = Math.Pow(altura, 2);
            imc = peso / altura;

            if(imc <= 18.5)
            {
                Console.WriteLine($"Nome: {nome}, Peso: {peso}, Altura: {altura}. Seu IMC: {imc.ToString("F1")}.");
                Console.WriteLine("Sua faixa está Abaixo do Peso.");
                
            }
            if(imc > 18.5 && imc <= 24.9)
            {
                Console.WriteLine($"Nome: {nome}, Peso: {peso}, Altura: {altura}. Seu IMC: {imc.ToString("F1")}.");
                Console.WriteLine("Sua faixa está no Peso Normal.");
            }
            if(imc > 24.9 && imc <= 29.9)
            {
                Console.WriteLine($"Nome: {nome}, Peso: {peso}, Altura: {altura}. Seu IMC: {imc.ToString("F1")}.");
                Console.WriteLine("Sua faixa está Sobrepeso.");
            }
            if(imc > 29.9 && imc <= 34.9)
            {
                Console.WriteLine($"Nome: {nome}, Peso: {peso}, Altura: {altura}. Seu IMC: {imc.ToString("F1")}.");
                Console.WriteLine("Sua faixa está Obesidade Grau I.");
            }
            if(imc > 35.0 && imc <= 39.9)
            {
                Console.WriteLine($"Nome: {nome}, Peso: {peso}, Altura: {altura}. Seu IMC: {imc.ToString("F1")}.");
                Console.WriteLine("Sua faixa está Obesidade Grau II.");
            }
            if(imc > 40.0)
            {
                Console.WriteLine($"Nome: {nome}, Peso: {peso}, Altura: {altura}. Seu IMC: {imc.ToString("F1")}.");
                Console.WriteLine("Sua faixa está Obesidade Grau III.");
            }
        }
        
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            
        }
    }
}
