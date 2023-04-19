using System;

namespace Viagem2
{
    class Viagem2
    {
        private double distancia;
        private double tempo;

        public void SetDistancia(double d){
            if(d>=0) distancia = d;
        }

        public void SetTempo(double t){
            if(t>=0) tempo = t;
        }

        public double GetDistancia(){
            return distancia;
        }

        public double GetTempo(){
            return tempo;
        }

        public double VelocidadeMedia(){
            double vm = distancia/tempo;
            return vm;
        }

        static void Main(string[] args)
        {
            Viagem2 x = new Viagem2();
            Console.WriteLine("Digite a distância da viagem: ");
            x.SetDistancia(double.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o tempo da viagem: ");
            x.SetTempo(double.Parse(Console.ReadLine()));

            Console.WriteLine($"Velocidade média da viagem: {x.VelocidadeMedia()}km/h");
        }
    }
}
