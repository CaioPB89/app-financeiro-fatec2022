using ApplicationFinance.Classes.Abstractions;

namespace ApplicationFinance.Classes.Implementations
{
    public class Investimento : Conta, IConta
    {
        protected decimal Saldo { get; set; }

        public override void Depositar(decimal valorDeposito) => Saldo += valorDeposito;      

        public override void Sacar(decimal valorSaque) => Saldo -= ((valorSaque - 0.01m) - valorSaque);

        public override decimal ObterSaldo() => Saldo;

       
    }
}