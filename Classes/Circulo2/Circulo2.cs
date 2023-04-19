using System;

namespace Circulo2
{
    class Circulo2
    {
        private double raio;

        public void SetRaio(double v){
            if(v>=0) raio = v;
        }

        public double GetRaio(){
            return raio;
        }

        public double CalcArea(){
            double area = Math.PI * Math.Pow(raio, 2);
            return area;
        }

        public double CalcCircuferencia(){
            double circuferencia = 2*Math.PI*raio;
            return circuferencia;
        }

        static void Main(string[] args)
        {
            Circulo2 x = new Circulo2();
            
            double raio = int.Parse(Console.ReadLine());
            x.SetRaio(raio);

            Console.WriteLine($"Área: {x.CalcArea()}");
            Console.WriteLine($"Circuferência: {x.CalcCircuferencia()}");
        }
    }
}
