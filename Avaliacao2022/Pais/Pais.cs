using System;

namespace Pais
{
    class Pais
    {
        private string nome;
        private int populacao;
        private double area;

        public Pais(string n, int p, double a){
            if(n!="") nome = n;
            else throw new ArgumentOutOfRangeException();
            if(p>0) populacao = p;
            else throw new ArgumentOutOfRangeException();
            if(a>0) area = a;
            else throw new ArgumentOutOfRangeException();
        }

        public void SetNome(string nome){
            if(nome!="") this.nome = nome;
            else throw new ArgumentOutOfRangeException();
        }

        public void SetPopulacao(int populacao){
            if(populacao>0) this.populacao = populacao;
            else throw new ArgumentOutOfRangeException();
        }

        public void SetArea(double area){
            if(area>0) this.area = area;
            else throw new ArgumentOutOfRangeException();
        }

        public string GetNome(){
            return nome;
        }

        public int GetPopulacao(){
            return populacao;
        }

        public double GetArea(){
            return area;
        }

        public double Densidade(){
            double densidade = populacao/area;
            return densidade;
        }

        public override string ToString(){
            return $"Nome = {nome}, População = {populacao}, Area = {area}";
        }

        static void Main(string[] args)
        {
            Pais[] pais = new Pais[10];
            int cont = 0;
            while(cont!=9){
                Console.WriteLine($"Digite o nome do {cont+1}º país:");
                string name = Console.ReadLine();
                Console.WriteLine($"Digite a população do {cont+1}º país:");
                int populacao = int.Parse(Console.ReadLine());
                Console.WriteLine($"Digite a área do {cont+1}º país:");
                double area = double.Parse(Console.ReadLine());

                pais[cont] = new Pais(name, populacao, area);

                cont ++;
            }
            
            int maiord = 0;

            for (int i = 1; i < 10; i++)
            {
                if(a[maiord].Densidade() < a[i].Densidade()){
                    maiord = i;
                }
            }

            Console.WriteLine($"Dados do país com maior densidade: {a[maiord]}");

        }
    }
}
