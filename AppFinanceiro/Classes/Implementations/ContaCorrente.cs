using AppFinanceiro.Classes.Abstractions;

namespace AppFinanceiro.Classes.Implementations
{
    public class ContaCorrente : Conta
    {
        public override void Depositar(decimal valorDeposito) => Saldo += valorDeposito;

        public override void Sacar(decimal valorSaque) => Saldo -= valorSaque;
    }
}