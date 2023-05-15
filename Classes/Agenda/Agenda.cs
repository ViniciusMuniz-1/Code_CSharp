using System;

namespace Agenda
{
    class Agenda
    {
        private Compromisso[] comps;
        private int k;
        
        public int Qtd{
            get{
                
            }
        }

        public void Inserir(Compromisso c){
            comps[k] = c;
            k++;
        }

        public void Excluir(Compromisso c){
            for(int i = 0; i < comps.Length; i++){
                if(comps[i] == c){
                    comps[i] = null;
                    k--;
                }
            }
        }

        public Compromisso[] Listar(){

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
