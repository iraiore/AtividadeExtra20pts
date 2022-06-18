using System;
namespace exercicio13{
    public class Program{
        public static void Main(string[] args){
            int inicial=0, final=0, numeros_pares=0, numeros_impares=0, numeros_impares_3e7=0, SomaPar=0, SomaImpar=0, SomaImpar_3e7=0, SomaPositivo=0, numeros_positivos=0;
            double media=0;
            Console.WriteLine("Entre com o numero inicial: ");
            inicial=int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o numero final: ");
            final=int.Parse(Console.ReadLine());
            Console.Write("A sequência de número é: ");
            for(int i=inicial;i<=final;i++){
                Console.Write(i+" ");
                if(i>=0){
                    SomaPositivo=SomaPositivo+i;
                    numeros_positivos=numeros_positivos+1;
                }
                if(i%2==0){
                    SomaPar=SomaPar+i;
                    numeros_pares=numeros_pares+1;
                }else if(i%2!=0){
                    SomaImpar=SomaImpar+i;
                    numeros_impares=numeros_impares+1;
                }
                if(i%2!=0 && i%3==0 && i%7==0){   
                    SomaImpar_3e7=SomaImpar_3e7+i;
                    numeros_impares_3e7=numeros_impares_3e7+1;
                }
            }
            media=SomaPositivo/(double)numeros_positivos;
            Console.Write("\n\nA media dos numeros inteiros positivos é: "+media);
            media=SomaPar/(double)numeros_pares;
            Console.Write("\nA media dos numeros pares é: "+media);
            media=SomaImpar/(double)numeros_impares;
            Console.Write("\nA media dos numeros impares é: "+media);
            media=SomaImpar_3e7/(double)numeros_impares_3e7;
            Console.Write("soma impar - "+ SomaImpar_3e7+" numeros impares - "+numeros_impares_3e7);
            Console.Write("\nA media dos numeros impares divisiveis por 3 e 7 é: "+media);
        }
    }
}