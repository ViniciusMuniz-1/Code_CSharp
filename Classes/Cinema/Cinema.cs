using System;

namespace Cinema
{
    class Cinema
    {
        private string dia;
        private string horario;

        public void SetDia(int dia){
            if(!string.IsNullOrEmpty(dia)) this.dia = dia;
            else throw new ArgumentOutOfRangeException();
        }

        public void SetHorario(string horario){
            if(!string.IsNullOrEmpty(horario)) this.horario = horario;
            else throw new ArgumentOutOfRangeException();
        }
        
        public string GetDia(){
            return dia;
        

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
                if(tempot >= 17){
                    valorentrada = valorbase + ((valor+50)/100);
                }
                else{
                    valorentrada = valorbase;
                }
            }
            else if(dia == "Sexta" || dia == "Sábado" || dia == "Domingo"){
                double valorbase = 20;
                if(tempot >= 17){
                    valorentrada = valorbase + ((valor+50)/100);
                }
                else{
                    valorentrada = valorbase;
                }
            }
            else{
                valorentrada = 8;
            }
            return valorentrada;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
