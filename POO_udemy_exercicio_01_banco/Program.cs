using System;

namespace POO_udemy_exercicio_01_banco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaShow;

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

                contaShow = new ContaBancaria(nome, numero, depositoInicial);
            }
            else
            {
                contaShow = new ContaBancaria(nome, numero);
            }
            Console.WriteLine("Informações do cliente:");
            Console.WriteLine(contaShow);
            Console.WriteLine();
            Console.Write("Digite um valor para o deposito: R$");
            double deposito = double.Parse(Console.ReadLine());
            contaShow.Depositar(deposito);
            Console.WriteLine(contaShow);
            Console.WriteLine();
            Console.Write("Digite um valor para saque: R$");
            double saque = double.Parse(Console.ReadLine());
            contaShow.Sacar(saque);
            Console.WriteLine("Datos sobre a conta: " + contaShow);
            Console.WriteLine("Deseja fazer um empréstimo ?");
            char r = char.Parse(Console.ReadLine());
            double valor = 0;
            if (r == 'S' || r == 's')
            {
                Console.WriteLine("Qual é o valor do empréstimo ? R$");
                valor = double.Parse(Console.ReadLine());
            }
            contaShow.Emprestimo(valor);
            Console.WriteLine(contaShow);
            Console.ReadLine();
        }
    }
}