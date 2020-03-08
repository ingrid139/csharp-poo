using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //int idade;
            //Console.WriteLine(idade);

            //instancia - criar um objeto a partir de uma classe 
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";
            Console.WriteLine("Saldo: " + conta.saldo);

            conta.saldo = 200;

            Console.WriteLine(conta.titular);
            Console.WriteLine("Agência: " + conta.agencia);
            Console.WriteLine("Saldo: " + conta.saldo);

            Console.ReadLine();
        }
    }
}
