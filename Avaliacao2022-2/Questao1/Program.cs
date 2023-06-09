﻿using System;
using System.Collections;

namespace Questao1
{
    class Program
    {
        private static Equipe equipe = new Equipe();
        public static void Main(){
            Console.WriteLine("Digite o país da equipe:");
            string pais = Console.ReadLine();
            equipe.SetPais(pais);

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
            int gols = int.Parse(Console.ReadLine());

            Jogador jogador = new Jogador(nome, camisa, gols);
            equipe.Inserir(jogador);
            Console.WriteLine("Jogador inserido com sucesso");
        }

        public static void Listar(){
            foreach (Jogador j in equipe.Listar())
            {
                Console.WriteLine(j);
            }
        }

        public static void Excluir(){
            
        }

        public static void Artilheiros(){
            foreach (Jogador j in equipe.Artilheiros())
            {
                Console.WriteLine(j);
            }
        }

        public static void Camisas(){
            foreach (Jogador j in equipe.Camisas())
            {
                Console.WriteLine(j);
            }
        }
    }

    class Equipe{
        private string pais;
        private Jogador[] jogs = new Jogador[26];
        private int k;

        public int Qtd{
            get => k;
        }

        public void SetPais(string pais){
            this.pais = pais;
        }

        public void Inserir(Jogador j){
            jogs[k] = j;
            Console.WriteLine(jogs[k]);
            k++;
            
        }

        public Jogador[] Listar(){
            Jogador[] aux = new Jogador[k];
            Array.Copy(jogs, aux, k);
            return aux;
        }

        public Jogador[] Artilheiros(){
            Jogador[] aux = new Jogador[k];
            Array.Copy(jogs, aux, k);
            Array.Sort(aux, new GolComparer());
            return aux;
        }

        public Jogador[] Camisas(){
            Jogador[] aux = new Jogador[k];
            Array.Copy(jogs, aux, k);
            Array.Sort(aux, new CamisaComparer());
            return aux;
        }

        public override string ToString(){
            return null;
        }
    }

    class CamisaComparer : IComparer {
        public int Compare(object obj1, object obj2)
        {
            Jogador jog1 = obj1 as Jogador;
            Jogador jog2 = obj2 as Jogador;
            return jog1.Camisa.CompareTo(jog2.Camisa);
        }
    }

    class GolComparer : IComparer {
        public int Compare(object obj1, object obj2)
        {
            Jogador jog1 = obj1 as Jogador;
            Jogador jog2 = obj2 as Jogador;
            return -jog1.NumGols.CompareTo(jog2.NumGols);
        }
    }
    
    class Jogador : IComparable{
        private string nome = "";
        private int camisa = 0;
        private int numGols = 0;
        
        public string Nome{
            set {if(value != "") this.nome = value;}
            get { return nome; }
        }
        public int Camisa{
            set {if (value > 0 && value<1000) this.camisa = value;}
            get { return camisa; }
        }
        public int NumGols{
            set {if(numGols>=0) this.numGols = value;}
            get { return numGols; }
        }


        public Jogador(string nome, int camisa, int numGols){
            Nome = nome;
            Camisa = camisa;
            NumGols = numGols;
        }

        public override string ToString(){
            return $"Nome: {nome} - Camisa: {camisa} - Número de gols: {numGols}";
        }

        public int CompareTo(object obj){
            Jogador x = obj as Jogador;
            return nome.CompareTo(x.nome);
        }
    }
}
