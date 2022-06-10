using System;
namespace exercicio9{
    public class Program{
        public static void Main(string[] args){
            double n1=0, n2=0, n3=0, media=0, exame=0;
            string continuar="s";
            while(continuar=="s"){
                Console.Write("Digite a 1º nota: ");
                n1=double.Parse(Console.ReadLine());
                Console.Write("Digite a 2º nota: ");
                n2=double.Parse(Console.ReadLine());
                Console.Write("Digite a º nota: ");
                n3=double.Parse(Console.ReadLine());
                media=(n1+n2+n3)/3;
                if(media>=7){
                    Console.WriteLine("\nO aluno está aprovado");
                }else{
                    exame=10-media;
                    Console.WriteLine("\nO aluno está de exame.\nSua nota no exame para ser aprovada precisa ser: "+exame);
                }
                Console.WriteLine("\nDeseja calcular uma nova media?\nDigite s para continuar ou n para encerrar.");
                continuar=Console.ReadLine();
            }
        }
    }
}