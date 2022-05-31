using System;
namespace exercicio8{
    public class Program{
        public static void Main(string[] args){
            int num=0, divisao=0, resto=0;
            string continuar="s";
            while(continuar=="s"){
                Console.Write("Digite um numero: ");
                num=int.Parse(Console.ReadLine());
                if(num%3==0){
                    Console.WriteLine("\nO numero digitado é multiplo de 3, pois o resto da divisao de "+num+" por 3 é zero.\nSegue a memoria de calculo");
                    Console.Write("\nDivisao: "+num+"/3 = ");
                    divisao=num/3;
                    resto=num%3;
                    Console.WriteLine(divisao);
                    Console.WriteLine("Resto da divisão: "+resto);
                }else if(num%7==0){
                    Console.WriteLine("\nO numero digitado é multiplo de 7, pois o resto da divisao de "+num+" por 7 é zero.\nSegue a memoria de calculo");
                    Console.Write("\nDivisao: "+num+"/7 = ");
                    divisao=num/7;
                    resto=num%7;
                    Console.WriteLine(divisao);
                    Console.WriteLine("Resto da divisão: "+resto);
                }else{
                    Console.WriteLine("\nO numero digitado não é multiplo de 3 ou 7, pois o resto da divisao de "+num+" por 3 ou 7 é diferennte de zero.\nSegue a memoria de calculo");
                    Console.WriteLine("\n************DIVISÃO POR  7************");
                    Console.Write("\nDivisao: "+num+"/7 = ");
                    divisao=num/7;
                    resto=num%7;
                    Console.WriteLine(divisao);
                    Console.WriteLine("Resto da divisão: "+resto);
                    Console.WriteLine("\n************DIVISÃO POR  3************");
                    Console.Write("\nDivisao: "+num+"/3 = ");
                    divisao=num/3;
                    resto=num%3;
                    Console.WriteLine(divisao);
                    Console.WriteLine("Resto da divisão: "+resto);
                    Console.WriteLine("\nDeseja verificar outro numero. \nDigite s para sim ou n para sair: ");
                    continuar=Console.ReadLine();
                }
            }
        }
    }
}