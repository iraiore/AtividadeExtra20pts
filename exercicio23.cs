using System;
namespace exercicio23{
    public class Program{
        public static void Main(string[] args){
            int contador = 0, Resultado=1;
            Console.Write("Entre com a base do numero para calular a potencia: \n");
            int Base = int.Parse(Console.ReadLine());
            Console.Write("Entre com a potência que a base será elevada: \n");
            int potencia = int.Parse(Console.ReadLine());
            Console.Write("O calculo da potenciação será: "+Base+"^"+potencia+"=");
            do{
                Resultado=Resultado*Base;
                Console.Write(Base);
                contador++;
                if(contador==potencia){
                    Console.Write("=");
                }else{
                    Console.Write("x");
                }
            }while(contador!=potencia);
            Console.Write(Resultado);
        }
    }
}