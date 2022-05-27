using System;
namespace exercicio3{
    public class Program{
        public static void Main(string[] args){
            string produto = "", codigo_produto = "";
            float preco_unitario=0, valor_venda=0;
            int numero_itens=0;
            Console.Write("Entre com nome do produto: ");
            produto = Console.ReadLine();
            Console.Write("\nDigite o codigo do produto: ");
            codigo_produto = Console.ReadLine();
            Console.Write("\nDigite o numero de "+produto+" que deseja comprar: ");
            numero_itens = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o preço unitário do produto: ");
            preco_unitario = float.Parse(Console.ReadLine());
            valor_venda = numero_itens*preco_unitario;
            Console.WriteLine("\n\n*****************DESCRIÇÃO DA VENDA*****************");
            Console.Write("\nItem Vendido: "+produto+"\nCodigo: "+codigo_produto+"\nPreço Unitário: R$ "+preco_unitario+"\nNumero de itens vendidos: "+numero_itens+" unidades"+"\nValor total da venda: R$ "+valor_venda);
        }
    }

}