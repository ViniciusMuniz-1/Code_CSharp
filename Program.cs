using System;

namespace aleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.q1();
            Program.q2();
            Program.q3();
            Program.q4();
            Program.q5();
        }

        static void q1(){
            Console.WriteLine("Digite seu nome:");
            string name = Console.ReadLine();
            Console.WriteLine($"Bem-vindo ao C#, {name}");   
        }

        static void q2(){
            Console.WriteLine("Digite seu nome completo:");
            string fullname = Console.ReadLine();
            string[] firstname = fullname.Split(' ');
            Console.WriteLine($"Bem-vindo ao C#, {firstname[0]}");
        }

        static void q3(){
            Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
            int nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
            int nota2 = int.Parse(Console.ReadLine());
            int media = ((50*2)+(70*3))/5;
            Console.WriteLine(media);
        }

        static void q4(){
            Console.WriteLine("Digite a base e altura do retângulo");
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = b*h;
            double perimetro = (b*2)+(h*2);
            double diag = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));
            Console.WriteLine($"Área: {area:0.00} - Perímetro: {perimetro:0.00} - Diagonal: {diag:0.00}");
        }

        static void q5(){
            Console.WriteLine("Digite o intervalo de tempo no formato HH:MM:SS");
            string tempos = Console.ReadLine();
            string[] tempoform = tempos.Split(':');
            double tempod = (double.Parse(tempoform[0])*3600) + (double.Parse(tempoform[1])*60) + (double.Parse(tempoform[2]));
            double v = 300000;
            double distancia = v*tempod;
            Console.WriteLine($"{distancia}");
        }
    }
}
