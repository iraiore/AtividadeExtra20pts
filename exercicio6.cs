using System;
namespace exercicio6{
    public class Program{
        Public static void Main(string[] args){
            int num=0;
            char continuar="";
            do{
                Console.WriteLine("Digite um número inteiro: ");
                num=int.Parse(Console.ReadLine);
                if(num%2==0){
                    Console.WriteLine("O numero "+num+"é par!");
                }else{
                    Console.WriteLine("O numero é impar: ");
                }
                Console.WriteLine("Deseja verificar se outro numero é par.\n\nDigite s para continuar o n para sair!");
                Continuar=Console.ReadLine();
            }while(continuar=="s");
        }
    }
}