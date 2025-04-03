using System.Globalization;

namespace ConsoleApp1

{
    internal class Conta
    {
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get ; private set; }

        public Conta(int numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public Conta(int numeroConta, string nome, double saldo) : this(numeroConta, nome)
        {
            Saldo = saldo;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5.0;
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {Nome}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
