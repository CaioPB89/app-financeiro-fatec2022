namespace ApplicationFinance.Classes.Abstractions
{
    public interface IConta
    {
         void Transfereir (decimal valorTransferencia, Conta origem, Conta destino);
    }
}
