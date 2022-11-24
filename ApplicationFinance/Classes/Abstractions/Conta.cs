namespace ApplicationFinance.Classes.Abstractions
{
    public abstract class Conta
    {       
        public abstract void Sacar(decimal valorSaque);

        public abstract void Depositar(decimal valorDeposito);

        public abstract decimal ObterSaldo();      
    }
}