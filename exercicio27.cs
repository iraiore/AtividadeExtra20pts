using System;
namespace exercicio27{
    public class Program{
        public static void Main(string[] args){ 
            int resto=1, soma_divisor=0;
            Console.Write("Entre com o valor inicial: ");
            int inicial=int.Parse(Console.ReadLine());
            Console.Write("Entre com o valor final: ");
            int final=int.Parse(Console.ReadLine());
            for(int i=inicial; i<=final; i++){
                    for(int j=1; j<i; j++){
                        if(i%j==0){
                            soma_divisor=soma_divisor+j;
                        }                                             
                    }
                    if(soma_divisor==i){
                        Console.Write("\no numero "+i+" é um número perfeito!");   
                    }                    
                soma_divisor=0;           
            }
        }
    }
}