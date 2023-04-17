using System;

namespace Viagem
{
    class Viagem
    {
        public int distancia;
        public string[] tempo;

        public static double calc_vmedia(int distancia, string[] tempo){
            int horas = int.Parse(tempo[0]);
            int min = int.Parse(tempo[1]);

            int tempot = horas + (min/60);

            double vmedia = distancia/tempot;
            return vmedia;
        }

        public static void Main(string[] args)
        {
            Viagem x;
            x = new Viagem();
            Console.WriteLine("Digite a distância da viagem:");
            x.distancia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tempo da viagem:");
            x.tempo = Console.ReadLine().Split(":");
            
            Console.Write($"Velocidade média: {calc_vmedia(x.distancia, x.tempo)}km/h");
        }
    }
}
