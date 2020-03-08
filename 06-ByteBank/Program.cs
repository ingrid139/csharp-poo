using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//atualizar namespace
namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Guilherme";
            cliente.CPF = "434.564.879-20";
            cliente.Profissao = "Desenvolvedor";
             
            //saldo nao pode ser negativo, porém o campo está public e em qualquer lugar do código pode ser modificado com facilidade
            //conta.saldo = -10;
            
            //conta.SetSaldo(-10);
            //conta.GetSaldo(-10);
            conta.Saldo = -10;
            conta.Titular = cliente;
             
            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);
             
            Console.ReadLine(); 
        }
    }
}
