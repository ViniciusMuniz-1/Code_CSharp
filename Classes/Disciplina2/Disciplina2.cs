using System;

namespace Disciplina2
{
    class Disciplina2
    {
        private string nome;
        private int nota1;
        private int nota2;
        private int nota3;
        private int nota4;
        private int notaFinal;

        public void SetNome(string s){
            if(!string.IsNullOrEmpty(s)) nome = s;
        }

        public void SetNota1(int n){
            if(n>=0) nota1=n;
        }

        public void SetNota2(int n){
            if(n>=0) nota2=n;
        }

        public void SetNota3(int n){
            if(n>=0) nota3=n;
        }

        public void SetNota4(int n){
            if(n>=0) nota4=n;
        }

        public void SetNotaFinal(int n){
            if(n>=0) notaFinal=n;
        }

        public string GetNome(){
            return nome;
        }

        public int GetNota1(){
            return nota1;
        }

        public int GetNota2(){
            return nota2;
        }

        public int GetNota3(){
            return nota3;
        }

        public int GetNota4(){
            return nota4;
        }

        public int GetNotaFinal(){
            return notaFinal;
        }

        public int CalcMediaParcial(){
            int mediaparc = ((nota1*2) + (nota2*2) + (nota3*3) + (nota4*3))/10;
            return mediaparc;
        }

        public int CalcMediaFinal(){
            int mediafinal = (CalcMediaParcial()+notaFinal)/2;
            return mediafinal;
        }

        static void Main(string[] args)
        {
            Disciplina2 x = new Disciplina2();
            Console.WriteLine("Digite o nome da matéria:");
            x.SetNome(Console.ReadLine());
            Console.WriteLine("Digite a nota 1:");
            x.SetNota1(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite a nota 2:");
            x.SetNota2(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite a nota 3:");
            x.SetNota3(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite a nota 4:");
            x.SetNota4(int.Parse(Console.ReadLine()));

            double mediaparc = x.CalcMediaParcial();
            
            if(mediaparc >= 60){
                Console.WriteLine("Você foi aprovado!");
                Console.WriteLine($"Média: {mediaparc}");
            }
            else{
                Console.WriteLine("Foi de recuperação!");
                Console.WriteLine("Digite a nota final:");
                x.SetNotaFinal(int.Parse(Console.ReadLine()));
                double mediaf = x.CalcMediaFinal();

                if(mediaf>=60){
                    Console.WriteLine("Você foi aprovado!");
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
