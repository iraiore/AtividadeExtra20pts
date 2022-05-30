using System;
namespace exerccio4{
    public class Program{
        public static void Main(string[] args){
            string funcionario="", continuar="";
            double salario=0, salario_reajustado=0;
            do{
                Console.Write("Digite o nome do funcionário: ");
                funcionario=Console.ReadLine();
                Console.Write("\nDigite o salario atual do colaborador: ");
                salario=double.Parse(Console.ReadLine());
                salario_reajustado=salario*1.0875;
                Console.Write("\n**************SALÁRIO REAJUSTADO**************");
                Console.Write("\n\nFucnionário: "+funcionario+"\nSalario atual: R$ "+salario+"\nSalario Reajustado: R$"+salario_reajustado);
                Console.WriteLine("\n\nDeseja fazer o calculo de reajuste para outro funcionário.\nDigite s para sim ou n para sair: ");
                continuar=Console.ReadLine();
            }while(continuar=="s");
        }
    }
}