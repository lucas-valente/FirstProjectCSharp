using System;
using System.Globalization;
namespace FirstProject {
    class Program {

        static void Main(string[] args) {

            Conta cc;

            //Entrada de valores
            Console.WriteLine("Entre o numero da conta: ");
            int codigoConta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o nome do titular: ");
            string nome = Console.ReadLine();
           
            //função pra mostrar dados
            void Mostra(string txt) { Console.WriteLine(txt + "\n" + cc); }

            //Deposita?
            Console.WriteLine("Haverá depósito inicial (s/n)? ");
            char Condicional = char.Parse(Console.ReadLine());
           
            //Testa as condições para depositar ou não
            if (Condicional == 's') {

                Console.WriteLine("Informe o valor de deposito inicial: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                cc = new Conta(codigoConta,nome,valor);

            }
            else { 
            
               cc = new Conta(codigoConta, nome); 
            
            }

            Mostra("Dados da Conta:");

            //Insere o valor de entrada do deposito na conta
            Console.WriteLine("\nInforme o valor do deposito: ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cc.Depositar(dep);

            //Imprime o resultado
            Mostra("Dados da Conta Atualizados:");

            //Retira o valor de entrada da conta
            Console.WriteLine("\nInforme o valor do saque:");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cc.Saque(saque);

            //Imprime o resultado
            Mostra("Dados da conta Atualizados");         

        }
    }
}