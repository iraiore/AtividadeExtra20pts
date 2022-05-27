using System;
namespace exercicio2{
    public class Program{
        public static void Main(string[] args){
            int[] valores=new int[3];
            float soma=0;
            float media=0;
            for (int i=0; i<3; i++){
                Console.WriteLine("Digite um numero: ");
                valores[i]=int.Parse(Console.ReadLine());
            }
            for(int i=0; i<3; i++){
                soma = soma + valores[i];
            }
            Console.Write("Os 3 valores digitados foram: ");
            for(int i=0; i<3; i++){
                Console.Write(valores[i]+" ");
            }
            media = soma/3;
            Console.WriteLine("\nA media dos valores digitados é: "+media);
        }
    }
}