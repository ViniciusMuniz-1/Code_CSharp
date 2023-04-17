using System;

namespace aleatorio
{
    class BeeCrowd
    {
        public static void Main(string[] args)
        {
            q1247();
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

        static void q1009(){
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine());
            double totalv = double.Parse(Console.ReadLine());
            
            double salariot = salario + (totalv*0.15);
            Console.WriteLine($"TOTAL = R$ {salariot:0.00}");
        }

        static void q1010(){
            string[] pnc1 = Console.ReadLine().Split(' ');
            string[] pnc2 = Console.ReadLine().Split(' ');

            int p1 = int.Parse(pnc1[0]);
            int n1 = int.Parse(pnc1[1]);
            double c1 = double.Parse(pnc1[2]);

            int p2 = int.Parse(pnc2[0]);
            int n2 = int.Parse(pnc2[1]);
            double c2 = double.Parse(pnc2[2]);

            double total = (n1*c1)+(n2*c2);

            Console.WriteLine($"VALOR A PAGAR: R$ {total:0.00}");
        }

        static void q1012(){
            string[] abc = Console.ReadLine().Split(' ');
                
            double pi = 3.14159;
            double a = double.Parse(abc[0]);
            double b = double.Parse(abc[1]);
            double c = double.Parse(abc[2]);

            double areat = (a*c)/2;
            double areac = pi*Math.Pow(c,2);
            double areatrap = ((a+b)*c)/2;
            double areaq = Math.Pow(b,2);
            double arear = a*b;

            Console.WriteLine($"TRIANGULO: {areat:0.000}");
            Console.WriteLine($"CIRCULO: {areac:0.000}");
            Console.WriteLine($"TRAPEZIO: {areatrap:0.000}");
            Console.WriteLine($"QUADRADO: {areaq:0.000}");
            Console.WriteLine($"RETANGULO: {arear:0.000}");
        }

        static void q1013(){
            string[] Maior = Console.ReadLine().Split(' ');

            int a = int.Parse(Maior[0]);
            int b = int.Parse(Maior[1]);
            int c = int.Parse(Maior[2]);

            int maiorab = (a+b+Math.Abs(a-b))/2;
            int maiorabc = (maiorab+c+Math.Abs(maiorab-c))/2;
            Console.WriteLine($"{maiorabc} eh o maior");
        }
        
        static void q1014(){
            int dist = int.Parse(Console.ReadLine());
            double totalc = double.Parse(Console.ReadLine());
            double consumo = (dist/totalc);
            Console.WriteLine($"{consumo:0.000} km/l");
            
        }

        static void q1015(){
            string[] xy1 = Console.ReadLine().Split(' ');
            string[] xy2 = Console.ReadLine().Split(' ');

            double x1 = double.Parse(xy1[0]);
            double y1 = double.Parse(xy1[1]);
            double x2 = double.Parse(xy2[0]);
            double y2 = double.Parse(xy2[1]);

            double dist = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
            Console.WriteLine($"{dist:0.0000}");
        }

        static void q1017(){
            int tempo = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());

            double dist = tempo*velocidade;
            double quantl = dist/12;
            Console.WriteLine($"{quantl:0.000}");
        }

        static void q1018(){
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num}");
            int notas100 = num/100;
            num = num%100;
            int notas50 = num/50;
            num = num%50;
            int notas20 = num/20;
            num = num%20;
            int notas10 = num/10;
            num = num%10;
            int notas5 = num/5;
            num = num%5;
            int notas2 = num/2;
            num = num%2;

            Console.WriteLine($"{notas100} nota(s) de R$ 100,00");
            Console.WriteLine($"{notas50} nota(s) de R$ 50,00");
            Console.WriteLine($"{notas20} nota(s) de R$ 20,00");
            Console.WriteLine($"{notas10} nota(s) de R$ 10,00");
            Console.WriteLine($"{notas5} nota(s) de R$ 5,00");
            Console.WriteLine($"{notas2} nota(s) de R$ 2,00");
            Console.WriteLine($"{num} nota(s) de R$ 1,00");
        }

        static void q1035(){
            string[] abcd = Console.ReadLine().Split(' ');

            int a = int.Parse(abcd[0]);
            int b = int.Parse(abcd[1]);
            int c = int.Parse(abcd[2]);
            int d = int.Parse(abcd[3]);
            
            if(b>c && d>a && c+d>a+b && c>0 && d>0 && a%2==0){
                Console.WriteLine("Valores aceitos");
            }
            else{
                Console.WriteLine("Valores nao aceitos");
            }
        }

        static void q1037(){
            double num = double.Parse(Console.ReadLine());

            if(num >= 0 && num<=25){
                Console.WriteLine("Intervalo [0,25]");
            }
            else if(num>25 && num<=50){
                Console.WriteLine("Intervalo (25,50]");
            }
            else if(num>50 && num<=75){
                Console.WriteLine("Intervalo (50,75]");
            }
            else if(num>75 && num<=100){
                Console.WriteLine("Intervalo (75,100]");
            }
            else{
                Console.WriteLine("Fora de intervalo");
            }
        }

        static void q1042(){
            string[] abc = Console.ReadLine().Split(' ');

            int a = int.Parse(abc[0]);
            int b = int.Parse(abc[1]);
            int c = int.Parse(abc[2]);

            int maior = a;
            int meio, last;

            if(maior < b && b > c){
                maior = b;
                if(a>c){
                    meio = a;
                    last = c;
                }
                else{
                    meio = c;
                    last = a;
                }
            }
            else if(maior < c){
                maior = c;
                if(a>b){
                    meio = a;
                    last = b;
                }
                else{
                    meio = b;
                    last = a;
                }
            }
            else{
                if(b>c){
                    meio = b;
                    last = c;
                }
                else{
                    meio = c;
                    last = b;
                }
            }

            Console.WriteLine($"{last}\n{meio}\n{maior}");
            Console.WriteLine($"\n{a}\n{b}\n{c}");
        }

        static void q1117(){
            double[] notasvalidas = new double[2];
            int notas = 0;
            while(notas!=2){
                double nota = double.Parse(Console.ReadLine());

                if(nota>=0 && nota<=10){
                    notasvalidas[notas] = nota;
                    notas++;
                }
                else{
                    Console.WriteLine("nota invalida");
                }
            }
            double media = (notasvalidas[0]+notasvalidas[1])/2;
            Console.WriteLine($"media = {media}");
        }

        static void q1140(){
            string frase = Console.ReadLine();
            while(frase!="*"){
                string[] palavras = frase.Split(' ');
                char fistletter = Char.ToLower(palavras[0][0]);
                bool istatutogram = true;
                foreach(string palavra in palavras){
                    if(Char.ToLower(palavra[0]) != fistletter){
                        istatutogram = false;
                        break;

                    }
                }
                Console.WriteLine(istatutogram ? "Y" : "N");
                frase = Console.ReadLine(); 
            }
        }

        static void q1151(){
            int num = int.Parse(Console.ReadLine());
            int[] soma = new int[50];
            soma[0] = 0;
            soma[1] = 1;

            for(int i = 2; i<num; i++){
                soma[i] = soma[i-1]+soma[i-2];
            }

            for(int i=0; i<num; i++){
                if(i+1==num){
                    Console.Write(soma[i]);
                }
                else{
                    Console.Write(soma[i]+" ");
                }
            }
            
            Console.WriteLine();
        }

        static void q1221(){
            int quant = int.Parse(Console.ReadLine());
            int cont = 1;
            while(quant!=0){
                int num = int.Parse(Console.ReadLine());
                for(int j = 1; j<=Math.Sqrt(num); j++){
                    if(num%j==0){
                        cont++;
                        if(cont>2) break;
                    }
                }   
                if(cont==2) Console.WriteLine("Prime");
                else Console.WriteLine("Not Prime");
                cont = 1;
                quant--;
            }
        }

        static void q1247(){
            string[] dvfvg = Console.ReadLine().Split(' ');
            while(dvfvg[0]!="EOF"){               
                int d = int.Parse(dvfvg[0]);
                int vf = int.Parse(dvfvg[1]);
                int vg = int.Parse(dvfvg[2]);

                int totalL = d*vf;
                int totalG = d*vg;
                if(totalL>=totalG){
                    Console.WriteLine("N");
                }
                else{
                    Console.WriteLine("S");
                }
                dvfvg = Console.ReadLine().Split(' ');
            }
        }

        static void q2377(){
            string[] ld = Console.ReadLine().Split(' ');
            string[] kp = Console.ReadLine().Split(' ');

            int l = int.Parse(ld[0]);
            int d = int.Parse(ld[1]);
            int k = int.Parse(kp[0]);
            int p = int.Parse(kp[1]);

            int custo = ((l/d)*p)+(l*k);
            Console.WriteLine($"{custo}");
        }

        static void q2456(){
            string[] abcde = Console.ReadLine().Split(' ');

            int a = int.Parse(abcde[0]);
            int b = int.Parse(abcde[1]);
            int c = int.Parse(abcde[2]);
            int d = int.Parse(abcde[3]);
            int e = int.Parse(abcde[4]);

            if(a<b){
                if(b<c){
                    if(c<d){
                        if(d<e){
                            Console.WriteLine("C");
                        }
                        else{
                            Console.WriteLine("N");
                        }
                    }
                    else{
                        Console.WriteLine("N");
                    }
                }
                else{
                    Console.WriteLine("N");
                }
            }
            else if(a>b){
                if(b>c){
                    if(c>d){
                        if(d>e){
                            Console.WriteLine("D");
                        }
                        else{
                            Console.WriteLine("N");
                        }
                    }
                    else{
                        Console.WriteLine("N");
                    }
                }
                else{
                    Console.WriteLine("N");
                }
                
            }
        }

        static void q2473(){
            string[] abcde = Console.ReadLine().Split(' ');
            string[] efghi = Console.ReadLine().Split(' ');
            
            int contador = 0;

            for (int i = 0; i<6; i++){
                for(int j = 0; j<6; j++){
                    if(int.Parse(abcde[i]) == int.Parse(efghi[j])){
                        contador++;
                    }
                }     
            }
            if(contador<3){
                Console.WriteLine("azar");
            }
            else if(contador==3){
                Console.WriteLine("terno");
            }
            else if(contador==4){
                Console.WriteLine("quadra");
            }
            else if(contador==5){
                Console.WriteLine("quina");
            }
            else{
                Console.WriteLine("sena");
            }
        }
    }
}
