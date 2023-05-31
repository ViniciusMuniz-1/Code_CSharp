using System;

namespace Pilha
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pilha<string> x = new Pilha<string>();
            x.Push("C#");
            x.Push("C++");
            x.Push("Java");
            Console.WriteLine(x.Peek());
            while(x.Count > 0){
                Console.WriteLine(x.Pop());
            }
        }
    }

    class Pilha<T>{
        private T[] objs = new T[10];
        private int cont=0;
        
        public int Count{
            get { return cont; }
        }

        public int Clear(){
            cont = 0;
        }

        public T Peek(){
            if(cont == 0){throw new InvalidOperationException();}
            return objs[cont];
        }

        public void Push(T obj){
            if(cont == objs.Length){
                Array.Resize(ref objs, 2 * objs.Length);
            }
            objs[cont] = obj;
            cont++;
        }

        public T Pop(){
            if(cont == 0){
                throw new InvalidOperationException();
            }
            cont--;
            return objs[cont];
        }        
    }
}
