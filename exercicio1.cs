using System;
namespace exercicio1{
    public class Program{
        public static void Main(string[] args){
            int[] valores=new int[4];
            int soma=0;
            for(int i=0; i<4; i++){
                Console.WriteLine("Digite o numero: ");
                valores[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0; i<4; i++){
                soma = soma + valores[i];
            }
            Console.Write("Os 4 numeros digitados foram: ");
            for(int i=0; i<4; i++){
                Console.Write(+valores[i]+" ");
            }
            Console.WriteLine("\nA soma dos 4 itens digitados: "+soma);
        }
    }
}
