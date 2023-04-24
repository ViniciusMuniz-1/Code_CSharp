using System;

namespace Cinema
{
    class Cinema
    {
        private string dia;
        private string horario;

        public void SetDia(string dia){
            if(!string.IsNullOrEmpty(dia)) this.dia = dia;
            else throw new ArgumentOutOfRangeException();
        }

        public void SetHorario(string horario){
            if(!string.IsNullOrEmpty(horario)) this.horario = horario;
            else throw new ArgumentOutOfRangeException();
        }
        
        public string GetDia(){
            return dia;
        }

        public string GetHorario(){
            return horario;
        }

        public double CalculoEntrada(bool meia){
            double valorentrada = 0;
            string[] tempo = horario.Split(":");
            int horas = int.Parse(tempo[0]);
            int min = int.Parse(tempo[1]);
            double tempot = horas + (min/60);

            if(dia == "Segunda" || dia == "Terça" || dia == "Quinta"){
                double valorbase = 16;
                if(meia == true){
                    if(tempot >= 17){
                        valorentrada = (valorbase + ((valorbase+50)/100))/2;
                    }
                    else{
                        valorentrada = valorbase/2;
                    }
                }
                else{
                    if(tempot >= 17){
                        valorentrada = (valorbase + ((valorbase+50)/100));
                    }
                    else{
                        valorentrada = valorbase;
                    }
                }
            }
            else if(dia == "Sexta" || dia == "Sábado" || dia == "Domingo"){
                double valorbase = 20;
                if(meia == true){
                    if(tempot >= 17){
                        valorentrada = (valorbase + ((valorbase+50)/100))/2;
                    }
                    else{
                        valorentrada = valorbase/2;
                    }
                }
                else{
                    if(tempot >= 17){
                        valorentrada = (valorbase + ((valorbase+50)/100));
                    }
                    else{
                        valorentrada = valorbase;
                    }
                }
            }
            else{
                valorentrada = 8;
            }
            return valorentrada;
        }

        static void Main(string[] args)
        {
            Cinema x = new Cinema();
            Console.WriteLine("Digite o dia:");
            x.SetDia(Console.ReadLine());
            Console.WriteLine("Digite o horário:");
            x.SetHorario(Console.ReadLine());

            Console.WriteLine("Você paga meia? (S=SIM/N=NÃO)");
            string resposta = Console.ReadLine();
            bool meia;
            if(resposta == "S"){
                meia = true;
            }else{
                meia = false;
            }
            Console.WriteLine($"Valor da entrada: R${x.CalculoEntrada(meia)}");
        }
    }
}
