using System;

namespace Frete
{
    class Frete
    {
        private double distancia;
        private double peso;

        public double Frete(double d, double p){
            if(d > 0) distancia = d;
            else throw new ArgumentOutOfRangeException();
            if(p > 0) peso = p;
            else throw new ArgumentOutOfRangeException();
        }

        public void SetPeso(double p){
            if(p > 0) peso = p;
            else throw new ArgumentOutOfRangeException();
        }

        public void SetDistancia(double d){
            if(d > 0) distancia = d;
            else throw new ArgumentOutOfRangeException();
        }

        public double GetDistancia(){
            return distancia;
        }

        public double GetPeso(){
            return peso;
        }

        public double CalcFrete(){
            return peso/distancia;
        }

        public override string ToString(){
            return $"Peso = {peso}, Distância = {distancia}";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
