using AppFinanceiro.Classes.Abstractions;

namespace AppFinanceiro.Classes.Implementations
{
    public class Poupanca : Conta
    {
        public override void Depositar(decimal valorDeposito) => Saldo += (valorDeposito * 0.5m);

        public override void Sacar(decimal valorSaque) => Saldo -= valorSaque;
    }
}