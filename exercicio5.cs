using System;
namespace exercicio5{
    public class Program{
        public static void Main(string[] args){
            string produto="",continuar="s";
            double preco=0, preco_desconto=0;
            while(continuar=="s"){
            Console.WriteLine("Digite o nome do produto:");
            produto=Console.ReadLine();
            Console.WriteLine("Digite o preço do produto");
            preco=double.Parse(Console.ReadLine());
            preco_desconto=preco*0.9;
            Console.WriteLine("\n************* DESCONTO DE 10% *************");
            Console.WriteLine("Produto: "+produto+"\nPreço atual: "+preco+"\nPreço c/ desconto: "+preco_desconto);
            Console.WriteLine("\nDeseja calcular o desconto de outro produto.\nDigite s para continuar ou n para sair");
            continuar=Console.ReadLine();
            }
        }
    }
}