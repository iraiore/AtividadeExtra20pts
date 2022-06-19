using System;
namespace exercicio14{
    public class Program{
        public static void Main (string[] args){
            int anterior=0, atual=1,proximo=0;
            Console.WriteLine("Entre com o numero inteiro para calcular a sequancia de Fibonacci: ");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine("A sequência de Fibonacci de "+num+" termos e: ");
            for(int i=1; i<=num; i++){
                proximo=atual+anterior;
                Console.Write(proximo+" ");
                anterior=atual;
                atual=proximo;
            }
        }
    }
}