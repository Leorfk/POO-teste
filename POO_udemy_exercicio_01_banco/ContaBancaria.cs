using System;
using System.Collections.Generic;
using System.Text;

namespace POO_udemy_exercicio_01_banco
{
    class ContaBancaria
    {
        public string Nome { get; set; }
        public int NumeroDaConta { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string nome, int numeroDaConta)
        {
            Nome = nome;
            NumeroDaConta = numeroDaConta;
        }
        public ContaBancaria(string nome, int numeroDaConta, double saldo) : this(nome, numeroDaConta)
        {//esse 'this' serve para tirarmos a redundância de escrever as atribuições mais vezes
            //Saldo = saldo;
            Depositar(saldo);//é melhor usar o método para facilitar a manutenção
        }

        public void Depositar(double deposito)
        {
            Saldo += deposito;
        }

        public void Sacar(double saque)
        {
            Saldo = Saldo - (saque + 2.00);
        }

        public override string ToString()
        {
            return "Cliente: " + Nome + "\nNúmero da conta: " + NumeroDaConta + "\nSaldo: R$" + Saldo;
        }
    }
}