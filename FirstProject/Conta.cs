using System.Globalization;
namespace FirstProject {
    internal class Conta {

        //Atributos
        private string _nome;
        public int CodigoConta { get; private set; }
        public double Saldo { get; private set; }

        //Properties
        public string Nome {
            get { return _nome; }
            set {
                if(value != null && value.Length > 1) {
                    _nome = value; 
                }
            }
        }

        //Construtores
        public Conta(int codigoconta, string nome)  {
            CodigoConta = codigoconta;
            _nome = nome;
        }

        public Conta(int codigoconta, string nome, double valorInicial) : this(codigoconta, nome) { 
            Depositar(valorInicial);
        }

        //Metodos
        public void Depositar( double valor) {
            Saldo += valor;
        }

        public void Saque(double valor) { 
            Saldo = (Saldo - valor) - 5;
        }

        override public string ToString() {
            return "Conta " + CodigoConta + ", Titular: " + Nome + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
