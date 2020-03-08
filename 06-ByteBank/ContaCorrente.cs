// using _05_ByteBank;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        //quando não há regra
        public Cliente Titular { get; set; }

        //private Cliente _titular;
        //public Cliente Titular 
        //{
        //    get
        //    {
        //        return _titular;
        //    }

        //    set
        //    {
        //        _titular = value;
        //    }
        //}


        //public int agencia;
        public int Agencia { get; set; }
        //public int numero;
        public int Numero { get; set; }

        //encapsulamento - privado, modificado através de métodos
        //private double saldo = 100;
        private double _saldo = 100;

        //propriedade - letra maiuscula
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }
        //public void DefinirSaldo()
        //Existem nomes mais apropriados = Set.
        //public void SetSaldo()
        //{
        //    if (saldo < 0)
        //    {
        //        return;
        //    }
        //    //this usado quando há conflito de variáveis
        //    this.saldo = saldo;
        //}
        //public double ObterSaldo()
        //Existem nomes mais apropriados = Get.
        //public double GetSaldo()
        //{
        //    return saldo;
        //}

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
