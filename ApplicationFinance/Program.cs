using ApplicationFinance.Classes.Abstractions;
using ApplicationFinance.Classes.Implementations;

namespace ApplicationFinance
{
    internal class Program
    {
        static void Main()
        {
            var poupanca = new Poupanca();
            var contaCorretente = new ContaCorrente();
            var investimento = new Investimento();

            //Console.WriteLine($"Valor atual do saldo: {poupanca.ObterSaldo()}");
            //poupanca.Depositar(1000m);
            //Console.WriteLine($"Valor atualizada do saldo: {poupanca.ObterSaldo()}");
            //poupanca.Sacar(300m);
            //Console.WriteLine($"Valor atualizada do saldo: {poupanca.ObterSaldo()}");

            //Console.WriteLine($"Valor atual do saldo: {contaCorretente.ObterSaldo()}");
            //contaCorretente.Depositar(1000m);
            //Console.WriteLine($"Valor atualizada do saldo: {contaCorretente.ObterSaldo()}");
            //contaCorretente.Sacar(300m);
            //Console.WriteLine($"Valor atualizada do saldo: {contaCorretente.ObterSaldo()}");

            //Console.WriteLine($"Valor atual do saldo: {investimento.ObterSaldo()}");
            //investimento.Depositar(1000m);
            //Console.WriteLine($"Valor atualizada do saldo: {investimento.ObterSaldo()}");
            //investimento.Sacar(300m);
            //Console.WriteLine($"Valor atualizada do saldo: {investimento.ObterSaldo()}");

           
            poupanca.Depositar(1000m);

            Console.WriteLine($"Valor atualizada da poupança saldo: {poupanca.ObterSaldo()}");
            Console.WriteLine($"Valor atualizada da conta corrente saldo: {contaCorretente.ObterSaldo()}");

            poupanca.Transfereir(50, poupanca, contaCorretente);

            Console.WriteLine($"Valor atualizada da poupança saldo: {poupanca.ObterSaldo()}");
            Console.WriteLine($"Valor atualizada da conta corrente saldo: {contaCorretente.ObterSaldo()}");
        }
    }
}