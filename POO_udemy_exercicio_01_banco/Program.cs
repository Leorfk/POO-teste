using System;

namespace POO_udemy_exercicio_01_banco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Será feito um depósito inicial [S/N] ?");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 'S' || resp == 's')
            {
                Console.Write("Digite o valor do depósito: R$");
                double depositoInicial = double.Parse(Console.ReadLine());

                conta = new ContaBancaria(nome, numero, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(nome, numero);
            }
            Console.WriteLine("Informações do cliente:");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Digite um valor para o deposito: R$");
            double deposito = double.Parse(Console.ReadLine());
            conta.Depositar(deposito);
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Digite um valor para saque: R$");
            double saque = double.Parse(Console.ReadLine());
            conta.Sacar(saque);
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}