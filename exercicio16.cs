using System;
namespace exercicio16{
    public class Program{
        public static void Main(string[] args){
            int numero_total=0;
            double mediana=0;
            Console.WriteLine("Entre com o numero inicial da série: ");
            int inicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o numero final da serie: ");
            int final = int.Parse(Console.ReadLine());
            for(int i=inicial; i<=final; i++){
                numero_total=numero_total+i;
            }
            if (numero_total%2!=0){
                numero_total=(numero_total-1)/2;
                for(int i=1; i<=numero_total;i++){
                    mediana = mediana+(double)i;
                }
                Console.WriteLine("A mediana da sequencia é: "+mediana);
            }
        }
    }
}