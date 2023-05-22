using System;

namespace Questao1
{
    class Program
    {
        public static void Main(){
            Console.WriteLine("Digite o país da equipe:");
            string pais = Console.ReadLine();
            Equipe equipe = new Equipe(pais);

            int op = Menu();
            while (op != 0)
            {
                switch (op)
                {
                  case 1: Inserir(); break;
                  case 2: Excluir(); break;
                  case 3: Listar(); break;
                  case 4: Artilheiros(); break;
                  case 5: Camisas(); break;
                }               
               op = Menu();    
            }
        }

        public static int Menu(){
            Console.WriteLine("0-Fim, 1-Inserir, 2-Excluir, 3-Listar, 4-Artilheiros, 5-Camisas: ");
            return int.Parse(Console.ReadLine());
        }

        public static void Inserir(){
            Console.WriteLine("Inserir novo jogador");
            Console.WriteLine("Informe o nome do jogador:");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o número da camisa dele:");
            int camisa = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número de gols desse jogador:");
            int gols = int.Parse(Console.ReadLine);

            Jogador jogador = new Jogador(nome, camisa, gols);

            Console.WriteLine("Jogador inserido com sucesso");
        }

        public static void Listar(){
            foreach (Jogador j in equipe.Listar())
            {
                Console.WriteLine(j);
            }
        }
    }

    class Equipe{
        private string pais;
        private Jogador[] jogs;

        public void Inserir(Jogador j){
            
        }

        public Jogador[] Listar(){

        }

        public Jogador[] Artilheiros(){

        }

        public Jogador[] Camisas(){

        }

        public void ToString(){

        }
    }
    
    class Jogador{
        private string nome;
        private int camisa;
        private int numGols;

        public Jogador(string nome, int camisa, int numGols){
            this.nome = nome;
            this.camisa = camisa;
            this.numGols = numGols;
        }

        public void ToString(){
            Console.WriteLine($"Nome: {nome} - Camisa: {camisa} - Número de gols: {numGols}");
        }
    }
}
