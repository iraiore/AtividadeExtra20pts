using System;
namespace exercicio12{
    public class Program{
        public static void Main(string [] args){
                int entrada = 0, result=0;
                Console.WriteLine("Entre com o numero para calcular a tabuada: ");
                entrada=int.Parse(Console.ReadLine());
                for(int i=0;i<=entrada;i++){
                    Console.WriteLine("TABUADA DO "+i);
                    for(int j=0;j<=10;j++){
                        result=i*j;
                        Console.WriteLine(i+"x"+j+"="+result);
                    }
                }
        }
    }
}