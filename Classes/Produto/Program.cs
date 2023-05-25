using System;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Produto : IComparable{
        public string Descricao { get; set; }
        public double Preco { get; set}
        public int CompareTo(object obj){
            return 0;
        }
        
        public override string  ToString(){
            return $"{Descricao} - {Preco}";
        }
    }
}
