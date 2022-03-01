using ExTratamentoExcecoes.Entities.Exceptions;

namespace ExTratamentoExcecoes.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }
        public Account()
        {
        }
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }
        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new DomainExecpions("Seu saldo é insuficiente para o valor do saque");
            }
            else if (Balance == 0 || Balance < amount)
            {
                throw new DomainExecpions("Valor do saque superior ao limite do saque da conta");
            }
            Balance -= amount;
        }
    }
}
