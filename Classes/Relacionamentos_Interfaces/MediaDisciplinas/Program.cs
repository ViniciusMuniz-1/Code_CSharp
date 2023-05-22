using System;

namespace MediaDisciplinas
{
    class Program
    {
        static void Main(string[] args)
        {
            IDisciplina a = new DisciplinaAnual("Matemática", 80, 67, 70, 59, 60);
            IDisciplina b = new DisciplinaAnual("Portuguese", 50, 67, 40, 59, 60);
            IDisciplina c = new DisciplinaSemestral("Sociologia", 80, 67, 30);
            IDisciplina d = new DisciplinaSemestral("Arte", 90, 100, 30);

            Console.WriteLine(a.GetNome());
            Console.WriteLine(a.CalcMediaParcial());
            Console.WriteLine(a.CalcMediaFinal());
            Console.WriteLine(b.GetNome());
            Console.WriteLine(b.CalcMediaParcial());
            Console.WriteLine(b.CalcMediaFinal());
            Console.WriteLine(c.GetNome());
            Console.WriteLine(c.CalcMediaParcial());
            Console.WriteLine(c.CalcMediaFinal());
            Console.WriteLine(d.GetNome());
            Console.WriteLine(d.CalcMediaParcial());
            Console.WriteLine(d.CalcMediaFinal());
        }
    }
    interface IDisciplina{
        string GetNome();
        int CalcMediaParcial();
        int CalcMediaFinal();
    }

    class DisciplinaAnual : IDisciplina{
        private string nome;
        private int nota1;
        private int nota2;
        private int nota3;
        private int nota4;
        private int notaFinal;

        public DisciplinaAnual(string nome, int nota1, int nota2, int nota3, int nota4, int notaFinal){
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
            this.nota4 = nota4;
            this.notaFinal = notaFinal;
        }

        public string GetNome(){
            return this.nome;
        }

        public int CalcMediaParcial(){
            return ((nota1*2)+(nota2*2)+(nota3*3)+(nota4*3))/10;
        }

        public int CalcMediaFinal(){
            return (this.CalcMediaParcial()+notaFinal)/2;
        }
    }

    class DisciplinaSemestral : IDisciplina{
        private string nome;
        private int nota1;
        private int nota2;
        private int notaFinal;

        public DisciplinaSemestral(string nome, int nota1, int nota2, int notaFinal){
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.notaFinal = notaFinal;
        }

        public string GetNome(){
            return this.nome;
        }

        public int CalcMediaParcial(){
            return ((nota1*2)+(nota2*3))/5;
        }

        public int CalcMediaFinal(){
            return (this.CalcMediaParcial()+notaFinal)/2;
        }
    }
}
