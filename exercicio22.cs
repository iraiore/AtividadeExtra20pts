using System;
namespace exercicio22{
    public class Program{
        public static void Main(string[] args){
            int fatorial=1;
            Console.Write("Entre com o número a ser fatorado: \n");
            int num=int.Parse(Console.ReadLine());
            Console.Write(num+"!=");
            for(int i=num; i>1; i--){
                Console.Write(i+"x");
                fatorial=fatorial*i;
                if(i<=2){
                    Console.Write("1=");
                }               
            }
            Console.Write(fatorial);
        }
    }
}