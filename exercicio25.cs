using System;
namespace exercicio25{
    public class Program{
        public static void Main(string[] args){
            int aux=0;
            Console.WriteLine("Digite o numero para verificar se é primo: ");
            int num=int.Parse(Console.ReadLine());
            for(int i=num; i>=2; i--){
                if(num%i==0){
                    aux++;
                }
            }
            if(aux>1){
                Console.WriteLine("O número não é primo!");
            }else{
                Console.WriteLine("O número é primo!");
            }
        }
    }
}