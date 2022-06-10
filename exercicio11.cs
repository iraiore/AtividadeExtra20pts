using System;
namespace exercicio11{
    public class Program{
        public static void Main(string[] args){
            double altura_pedro=1.5, altura_lucas=1.1;
            int ano=2022;
            do{
                altura_pedro=altura_pedro+0.02;
                altura_lucas=altura_lucas+0.03;
                ano++;
            }while(altura_pedro>=altura_lucas);
            ano = ano-1;
            Console.WriteLine("No ano "+ano+"Pedro e Lucas Terão a mesma idade!");
            ano = ano+1;
            Console.WriteLine("No ano "+ano+"Lucas terá o tamanho maior do que Pedro!");  
            Console.ReadLine();
        }
    }
}