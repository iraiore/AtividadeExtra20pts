using System;
namespace exercicio10{
    public class Program{
        public static void Main(string[] args){
            double valor_da_compra=0,valor_parcelado=0;
            int numero_parcela=0;
            Console.WriteLine("Digite o valor da compra:");
            valor_da_compra=double.Parse(Console.ReadLine());
            Console.WriteLine("Em quantas vezes será divida a compra, 3x, 5x ou 10x?\nDigite o numero que deseja dividir a compra. Se a compra for a vista, não entre com valor zero!");
            numero_parcela=int.Parse(Console.ReadLine());
            if(numero_parcela==3){
                valor_parcelado=valor_da_compra/numero_parcela;
                Console.WriteLine("O valor total da compra é de: R$"+valor_da_compra+"\nO valor da parcela é de: R$"+valor_parcelado);
            }else if(numero_parcela==5){
                valor_parcelado=valor_da_compra*1.02;
                Console.WriteLine("O valor da compra é de: R$"+valor_parcelado);
                valor_parcelado=valor_parcelado/numero_parcela;
                Console.WriteLine("O valor da parcela é de: R$"+valor_parcelado);
            }else if(numero_parcela==10){
                valor_parcelado=valor_da_compra*1.08;
                Console.WriteLine("O valor da compra é de: R$"+valor_parcelado);
                valor_parcelado=valor_parcelado/numero_parcela;
                Console.WriteLine("O valor da parcela é de: R$"+valor_parcelado);
            }else{
                valor_da_compra=valor_da_compra*0.95;
                Console.WriteLine("O valor da compra é de: R$"+valor_da_compra);
            }
            Console.ReadLine();
        }
    }
}
