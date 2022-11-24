namespace AppFinanceiro.Classes.Abstractions
{
    public abstract class Conta
    {
        public decimal Saldo { get; protected set; }

        public abstract void Sacar(decimal valorSaque);

        public abstract void Depositar(decimal valorDeposito);
    }
}