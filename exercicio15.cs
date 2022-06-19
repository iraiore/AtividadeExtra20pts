using System;
namespace exercicio15{
    public class Program{
        public static void Main(string[] args){
            int d=0, n=0;
            Console.WriteLine("********Explicando o que acontce quando o programa é executado*****************");
            Console.WriteLine("Ao iniciar o programa aparece uma mensangem solicitando um numero para o usuáio.\nCaso o usário digete o número 1 o programa será encerrado, caso nao seja o \nnumero 1 o programa ira executar a expressão de acordo com o numero entrado");
            Console.WriteLine("********************************************************************************");
            do{
                Console.Write("Entre com um numero par para calcular a expressão n = n + 2.\nEntre com um numero ímpar diferente de 1 para calcualr a expressão n = n x 3 + 1\nSe deseja encerrar digite 1\n");
                d=int.Parse(Console.ReadLine());
                if(d!=1){
                    if(d%2==0){
                        n=d+2;
                        Console.WriteLine("O resultado da expressão n = n + 2 é: "+n+"\n");
                    }else {
                        n=d*3+1;
                        Console.WriteLine("O resutlado da expressão n = n x 3 + 1 é: "+n+"\n");
                    }
                }else{
                d=1;
                }
            } while(d!=1);
        }
    }
}