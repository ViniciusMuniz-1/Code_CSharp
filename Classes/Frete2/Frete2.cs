using System;

namespace Frete2
{
    class Frete2
    {
        private double distancia;
        private double peso;
        public double Distancia{
            get{
                return this.distancia;
            }
            set{
                if(value >= 0){
                    this.distancia = value;
                }
            }
        }

        public double Peso{
            get{
                return this.peso;
            }
            set{
                if(value > 0){
                    this.peso = value;
                }
            }
        }

        public double ValorFrete{
            get{
                return 0.01 * this.peso * this.distancia;
            }
        }

        public override string ToString(){
            return $"Peso: {Peso}; Distância: {Distancia}; Valor Frete: {ValorFrete}";
        }

        static void Main(string[] args)
        {
            Frete2 a = new Frete2 { Peso = 20, Distancia = 10};
            Console.WriteLine(a.ValorFrete);
            Console.WriteLine(a);
        }
    }
}
