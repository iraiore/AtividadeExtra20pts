using System;
namespace exercicio26{
    public class Program{
        public static void Main(string[] args){
            double dividendo=0, divisor=0, quociente=0, resto=1;
            Console.WriteLine("Entre como o 1º valor");
            int A=int.Parse(Console.ReadLine());
            Console.WriteLine("Entre como o 2º valor");
            int B=int.Parse(Console.ReadLine());
            if(A>=B){
                dividendo=A;
                divisor=B;
                while(resto!=0){                 
                    resto=dividendo%divisor;
                    dividendo=divisor;
                    divisor=resto;
                   if(resto==0){
                        Console.Write("O MDC entre "+A+","+B+" é: "+dividendo);
                    }
                }
            }else{
                dividendo=A;
                divisor=B;
                while(resto!=0){                 
                    resto=dividendo%divisor;
                    dividendo=divisor;
                    divisor=resto;
                   if(resto==0){
                        Console.Write("O MDC entre "+A+","+B+" é: "+dividendo);
                    }
                }
            }
        }
    }
}