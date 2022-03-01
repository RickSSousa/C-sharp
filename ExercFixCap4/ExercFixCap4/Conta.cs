using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercFixCap4
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero,string nome)
        {
            Numero = numero;
            Nome = nome;
        }
        public Conta(int numero, string nome, double depositoInicial) : this(numero, nome)
        {
            Deposito(depositoInicial); //chamando o metodo deposito(), se em algum momento a regra para um deposito inicial mudar, o registro da conta do usuário já respeitará essa regra, sem precisar alterar uma logica do deposito e do construtor individualmente, fácil de dar manutenção
        }

        public override string ToString()
        {
            return "Conta: " + Numero + ", Titular: " + Nome + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
            /*Saldo -= 5.0;  pode ser dessa forma também, retirando o +5.0 da operação acima*/
        }
    }
}
