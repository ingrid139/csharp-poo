using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente conta = new ContaCorrente();

            //conta.Agencia = 2919;
            //conta.Numero = 0980;
            //conta.Numero = -10;
            //Console.WriteLine(conta.Numero);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            
            ContaCorrente conta = new ContaCorrente(867, 86712540);
            //caracteristica do objeto ou da classe? quand a caracteristica pe compartilhada por todos é da classe
            //conta.TotalDeContasCriadas ++;

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            //conta.TotalDeContasCriadas = 1000;


            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 86745820);
            //conta.TotalDeContasCriadas = 2;

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);



            Console.ReadLine();
        }
    }
}
