using System;
namespace exercicio16{
    public class Program{
        public static void Main(string[] args){
            int numero_elementos=0,metade_numero_elementos=0;
            double mediana=0, mediana1=0, mediana2=0;
            Console.WriteLine("Entre com o numero inicial da série: ");
            int inicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o numero final da serie: ");
            int final = int.Parse(Console.ReadLine());
            Console.Write("A sequência é: ");
            for(int i=inicial; i<=final; i++){
                numero_elementos=i;
                Console.Write(numero_elementos+" ");
            }
            if (numero_elementos%2!=0){
                metade_numero_elementos=(numero_elementos+1)/2;
                for(int i=inicial; i<=metade_numero_elementos;i++){
                    mediana = i;
                }
                Console.WriteLine("\nA mediana da sequencia é: "+mediana);
            }else{
                metade_numero_elementos=numero_elementos/2;
                for(int i=inicial; i<=metade_numero_elementos+1;i++){
                    mediana1=i-1;
                    mediana2=i;
                }
                mediana=(mediana1+mediana2)/2;
            Console.WriteLine("\nA mediana da sequencia é: "+mediana);
            }
        }
    }
}