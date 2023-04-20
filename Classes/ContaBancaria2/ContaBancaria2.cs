using System;

namespace ContaBancaria2
{
    class ContaBancaria2
    {
        private string titular = "sem nome";
        private string numero = "sem número";
        private double saldo;
    
        public void SetTitular(string titular){
            if(!string.IsNullOrEmpty(titular)) this.titular = titular;
        }

        public void SetNumero(string numero){
            if(!string.IsNullOrEmpty(numero)) this.numero = numero;
        }

        public void SetSaldo(double saldo){
            if(n>=0) this.saldo = saldo;
        }

        public string GetTitular(){
            return titular;
        }

        public string GetNumero(){
            return numero;
        }

        public double GetSaldo(){
            return saldo;
        }

        public double Deposito(double valor){
            if(valor>0){
                saldo = saldo + valor;
            }
            else{
                Console.WriteLine("Valor inválido!");
            }
            return saldo;
        }

        public double Saque(double valor){
            if(valor>0 && valor <= saldo){
                saldo = saldo - valor;
            }
            else{
                Console.WriteLine("Valor inválido!");
            }
            return saldo;
        }

        static void Main(string[] args)
        {
            ContaBancaria2 x = new ContaBancaria2();
            Console.WriteLine("Digite o nome do titular:");
            x.SetTitular(Console.ReadLine());
            Console.WriteLine("Digite o número da conta:");
            x.SetNumero(Console.ReadLine());
            Console.WriteLine("Digite o valor da conta:");
            x.SetSaldo(double.Parse(Console.ReadLine()));
            int operacao = 0;
            while (operacao!=4)
            {
                Console.WriteLine("\nDigite qual operação deseja realizar:");
                Console.WriteLine("1-Depósito");
                Console.WriteLine("2-Saque");
                Console.WriteLine("3-Visualizar saldo");
                Console.WriteLine("4-Sair\n");
                operacao = int.Parse(Console.ReadLine());
                if(operacao == 1){
                    Console.WriteLine("\nQuanto você quer depositar?");
                    double deposito = double.Parse(Console.ReadLine());
                    x.Deposito(deposito);
                }
                else if(operacao == 2){
                    Console.WriteLine("\nQuanto você quer sacar?");
                    double saque = double.Parse(Console.ReadLine());
                    x.Saque(saque);
                }
                else if(operacao == 3){
                    double saldo = x.GetSaldo();
                    Console.WriteLine($"Seu saldo é: R${saldo}");
                }
            }
        }
    }
}
