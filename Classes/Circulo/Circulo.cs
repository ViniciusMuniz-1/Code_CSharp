using System;

namespace aleatorio
{
    class Circulo
    {
        public int raio;
        
        public static double calc_area(int raio){
            double area = Math.Pow(Math.PI * raio, 2);
            return area;
        }

        public static double calc_circ(int raio){
            double circuferencia = 2*Math.PI*raio;
            return circuferencia;
        }

        public static void Main(string[] args){
            Circulo x;
            x = new Circulo();
            x.raio = int.Parse(Console.ReadLine());

            Console.WriteLine($"Área: {calc_area(x.raio)}");
            Console.WriteLine($"Circuferência: {calc_circ(x.raio)}");
        }
    }
}