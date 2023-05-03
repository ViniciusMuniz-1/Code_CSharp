using System;

namespace Baralho
{
    class Baralho
    {
        private string numero; //2 até 10, e A K Q J
        private string naipe; //PAUS, COPAS, ESPADAS OU OUROS

        public Baralho(string numero, string naipe){
            if(numero != "") this.numero = numero;      
            else throw new ArgumentOutOfRangeException();
            if(naipe != "") this.naipe = naipe;
            else throw new ArgumentOutOfRangeException();
        }

        public void SetNumero(string numero){
            if(numero!="") this.numero = numero;
            else throw new ArgumentOutOfRangeException();
        }

        public void SetNaipe(string naipe){
            if(naipe!="") this.naipe = naipe;
            else throw new ArgumentOutOfRangeException();
        }

        public string GetNumero(){
            return numero;
        }
        
        public string GetNaipe(){
            return naipe;
        }

        public override string ToString(){
            return $"Número da carta: {numero}; Naipe da carta: {naipe}";
        }

        public bool Combinar(Baralho carta){
            if(this.numero == carta.GetNumero || this.naipe == carta.GetNaipe){
                return true;
            }
            else{
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da carta:");
            string numero = Console.ReadLine();
            Console.WriteLine("Digite o naipe da carta:");
            string naipe = Console.ReadLine();
            Baralho carta1 = new Baralho(numero, naipe);

            Console.WriteLine("Digite o valor da 2º carta:");
            numero = Console.ReadLine();
            Console.WriteLine("Digite o naipe da 2º carta");
            naipe = Console.ReadLine();
            Baralho carta2 = new Baralho(numero, naipe);

            if(carta1.Combinar(carta2)==true){
                Console.WriteLine("Cartas combináveis");
            }
            else{
                Console.WriteLine("Cartas não combináveis");
            }
        }
    }
}
