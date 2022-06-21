using System;
namespace exercicio20{
    public class Program{
        public static void Main(string[] args){
           int intervalo_1=0, intervalo_2=0, intervalo_3=0, intervalo_4=0;
           double num=0;
           while(num>=0){
                Console.WriteLine("Entre com sequencia de números. Para encerrrar digite um número negativo.");
                num=double.Parse(Console.ReadLine());
                if(num>=0 && num<=25.9){
                    intervalo_1=intervalo_1+1;
                }else if(num>=26 && num<=50.9){
                    intervalo_2=intervalo_2+1;
                }else if(num>=51 && num<=75.9){
                    intervalo_3=intervalo_3+1;
                }else if(num>=76 && num<=100){
                    intervalo_4=intervalo_4+1;
                }
            }
            Console.Write("\nA quantidade de números no intervalo de [0 a 25.9] é: "+intervalo_1);
            Console.Write("\nA quantidade de números no intervalo de [26 a 50.9] é: "+intervalo_2);
            Console.Write("\nA quantidade de números no intervalo de [51 a 75.9] é: "+intervalo_3);
            Console.Write("\nA quantidade de números no intervalo de [76 a 100] é: "+intervalo_4);
        }
    }
}