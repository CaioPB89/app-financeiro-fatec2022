using ApplicationFinance.Classes.Abstractions;

namespace ApplicationFinance.Classes.Implementations
{
    public class Poupanca : Conta, IConta
    {
        protected decimal Saldo { get; set; }

        public override void Depositar(decimal valorDeposito) => Saldo += ((valorDeposito * 0.05m) + valorDeposito);

        public override void Sacar(decimal valorSaque) => Saldo -= valorSaque;

        public override decimal ObterSaldo() => Saldo;

        public void Transfereir(decimal valorTransferencia, Conta origem, Conta destino)
        {
            origem.Sacar(valorTransferencia);
            destino.Depositar(valorTransferencia);
        }
    }
}