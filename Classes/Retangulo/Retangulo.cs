using System;

namespace Retangulo
{
    class Retangulo
    {
        private double b;
        private double h;

        public Retangulo(double vb, double vh){
            if(vb > 0) b = vb;
            else throw new ArgumentOutOfRangeException();
            if(vh > 0) h = vh;
            else throw new ArgumentOutOfRangeException();
        }

        public void SetBase(double vb){
            if(vb > 0) b = vb;
            else throw new ArgumentOutOfRangeException();
        }

        public void SetAltura(double vh){
            if(vh > 0) h = vh;
            else throw new ArgumentOutOfRangeException();
        }

        public double GetBase(){
            return b;
        }

        public double GetAltura(){
            return h;
        }

        public double CalcArea(){
            return b*h;
        }

        public double CalcDiagonal(){
            return Math.Sqrt((b*b) + (h*h));
        }

        public override string ToString(){
            return $"Base = {b}, Altura = {h}";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite a base do retângulo:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do retângulo:");
            double altura = double.Parse(Console.ReadLine());

            Retangulo x = new Retangulo(b, altura);

            Console.WriteLine(x);
            Console.WriteLine($"\nÁrea: {x.CalcArea()}");
            Console.WriteLine($"\nDiagonal: {x.CalcDiagonal()}");
        }
    }
}
