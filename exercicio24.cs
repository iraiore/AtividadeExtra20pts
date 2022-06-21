using System;
namespace exercicio24{
    public class Program{
        public static void Main(string[] args){
            double media=0, entrada=0, numerador=0;
            int denominador=0;
            Console.Write("Entre a quantidade de numeros que será calculada a média: \n");
            int num=int.Parse(Console.ReadLine());
            for(int i=1; i<=num; i++){
             Console.Write("Entre com "+i+"º valor: ");
             entrada=double.Parse(Console.ReadLine());
             numerador=numerador+entrada;
             denominador=i;
            }
             media=numerador/denominador;
             Console.Write("A media dos numeros é: "+media);
        }
    }
}