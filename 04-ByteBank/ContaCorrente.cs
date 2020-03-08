﻿


public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    //novo comportamento = função - convenção: função: primeira letra maiúscula - verbo no infinitivo
    public bool Sacar(double valor)
    {
        //saldo desse objeto instanciado
        if(this.saldo < valor)
        {
            //devolve o valor pra quem chamou a função
            return false;
        }
        
        this.saldo -= valor;
        return true;
    }

    //método - não retorna valor
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }


    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if(this.saldo < valor)
        {
            return false;
        }
        
        this.saldo -= valor;
        contaDestino.Depositar(valor);
        return true;
    }
}


