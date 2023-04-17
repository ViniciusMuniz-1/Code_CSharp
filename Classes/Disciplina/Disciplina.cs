using System;

namespace aleatorio{
    class Disciplina{
        public string nome;
        public int nota1;
        public int nota2;
        public int nota3;
        public int nota4;
        public int provaf;

        public static double calc_mediaparc(int nota1, int nota2, int nota3, int nota4){
            double mediaparc = ((nota1*2) + (nota2*2) + (nota3*3) + (nota4*3))/10;
            return mediaparc;
        }

        public static double calc_mediafinal(double mediaparc, int provaf){
            double mediafinal = (mediaparc+provaf)/2;
            return mediafinal;
        }

        public static void Main(string[] args){
            Disciplina x;
            x = new Disciplina();
            x.nome = "Math";
            Console.WriteLine("Digite a nota 1:");
            x.nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 2:");
            x.nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 3:");
            x.nota3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 4:");
            x.nota4 = int.Parse(Console.ReadLine());

            double mediaparc = calc_mediaparc(x.nota1, x.nota2, x.nota3, x.nota4);

            if(mediaparc >= 60){
                Console.WriteLine("Você foi aprovado!");
                Console.WriteLine($"Média: {mediaparc}");
            }
            else{
                Console.WriteLine("Parece que você foi para recuperação...");
                Console.WriteLine("Digite a nota da prova final:");
                x.provaf = int.Parse(Console.ReadLine());
                double mediaf = calc_mediafinal(mediaparc, x.provaf);
                if(mediaf>= 60){
                    Console.WriteLine("Aprovado!");
                    Console.WriteLine($"Média: {mediaf}");
                }
                else{
                    Console.WriteLine("Reprovado");
                    Console.WriteLine($"Média: {mediaf}");
                }
            }
        }

    }
}