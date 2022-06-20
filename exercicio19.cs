using System;
namespace exercicio19{
    public class Program{
        public static void Main(string[] args){
            double salario_bruto=0, salario_liquido=0, desconto_INSS=0, desconto_IRPF=0;
            Console.WriteLine("Entre com o valor do salario fornecido pela empresa: ");
            salario_bruto=double.Parse(Console.ReadLine());
            Console.WriteLine("\n**********  DESCRIÇÃO DA FOHA DE PAGAMENTO  **********\n");
            if(salario_bruto<=1556.94){//soemnte desconto de inss de 8%
                salario_liquido=salario_bruto*0.92;
                desconto_INSS=salario_bruto*0.08;
                Console.Write("|SALARIO BRUTO: R$ "+salario_bruto+"\n");
                Console.Write("|SALARIO LIQUÍDO: R$ "+salario_liquido+"\n");
                Console.Write("|CONTRIBUIÇÃO INSS - ALIQUOTA 8%: R$ "+desconto_INSS+"\n");
                Console.Write("|CONTRIBUIÇÃO IRPF - 'NÃO HÁ DESCONTO PARA ESTA FAIXA SALARIAL\n");
            }else if(salario_bruto>1556.94 && salario_bruto<1903.99){//somente desconto de inss de 9%
                salario_liquido=salario_bruto*0.91;
                desconto_INSS=salario_bruto*0.09;
                Console.Write("|SALARIO BRUTO: R$ "+salario_bruto+"\n");
                Console.Write("|SALARIO LIQUÍDO: R$ "+salario_liquido+"\n");
                Console.Write("|CONTRIBUIÇÃO INSS - ALIQUOTA 9%: R$ "+desconto_INSS+"\n");
                Console.Write("|CONTRIBUIÇÃO IRPF - 'NÃO HÁ DESCONTO PARA ESTA FAIXA SALARIAL\n");  
            }else if(salario_bruto>1903.98 && salario_bruto<2594.93){//desconte inss de 9% e irpf de 7.5%
                 salario_liquido=salario_bruto*0.91-142.8;
                desconto_INSS=salario_bruto*0.09;
                Console.Write("|SALARIO BRUTO: R$ "+salario_bruto+"\n");
                Console.Write("|SALARIO LIQUÍDO: R$ "+salario_liquido+"\n");
                Console.Write("|CONTRIBUIÇÃO INSS - ALIQUOTA 9%: R$ "+desconto_INSS+"\n");
                Console.Write("|CONTRIBUIÇÃO IRPF - PARCELA A DEDUZIR: R$ 142,80\n");
            }else if(salario_bruto>2594.92 && salario_bruto<2826.66){//desconte inss de 11% e irpf de 7.5%
                salario_liquido=salario_bruto*0.89-142.8;
                desconto_INSS=salario_bruto*0.11;
                Console.Write("|SALARIO BRUTO: R$ "+salario_bruto+"\n");
                Console.Write("|SALARIO LIQUÍDO: R$ "+salario_liquido+"\n");
                Console.Write("|CONTRIBUIÇÃO INSS - ALIQUOTA 9%: R$ "+desconto_INSS+"\n");
                Console.Write("|CONTRIBUIÇÃO IRPF - PARCELA A DEDUZIR: R$ 142,80\n");
            }else if(salario_bruto>2826.65 && salario_bruto<3751.06){//desconte inss de 11% e irpf de 15%
                salario_liquido=salario_bruto*0.89-354.8;
                desconto_INSS=salario_bruto*0.11;
                Console.Write("|SALARIO BRUTO: R$ "+salario_bruto+"\n");
                Console.Write("|SALARIO LIQUÍDO: R$ "+salario_liquido+"\n");
                Console.Write("|CONTRIBUIÇÃO INSS - ALIQUOTA 9%: R$ "+desconto_INSS+"\n");
                Console.Write("|CONTRIBUIÇÃO IRPF - PARCELA A DEDUZIR: R$ 354,8\n");
            }else if(salario_bruto>3751.05 && salario_bruto<4664.69){//desconte inss de 11% e irpf de 22.5%
                salario_liquido=salario_bruto*0.89-636.13;
                desconto_INSS=salario_bruto*0.11;
                Console.Write("|SALARIO BRUTO: R$ "+salario_bruto+"\n");
                Console.Write("|SALARIO LIQUÍDO: R$ "+salario_liquido+"\n");
                Console.Write("|CONTRIBUIÇÃO INSS - ALIQUOTA 9%: R$ "+desconto_INSS+"\n");
                Console.Write("|CONTRIBUIÇÃO IRPF - PARCELA A DEDUZIR: R$ 636.13\n");
            }else if(salario_bruto>4664.68 && salario_bruto<=5189.82){//desconte inss de 11% e irpf de 27.5%
                salario_liquido=salario_bruto*0.89-869.36;
                desconto_INSS=salario_bruto*0.11;
                Console.Write("|SALARIO BRUTO: R$ "+salario_bruto+"\n");
                Console.Write("|SALARIO LIQUÍDO: R$ "+salario_liquido+"\n");
                Console.Write("|CONTRIBUIÇÃO INSS - ALIQUOTA 9%: R$ "+desconto_INSS+"\n");
                Console.Write("|CONTRIBUIÇÃO IRPF - PARCELA A DEDUZIR: R$ 869.36\n");
            }else {//desconto somente de  irpf de 27.5%
                salario_liquido=salario_bruto-869.36;
                Console.Write("|SALARIO BRUTO: R$ "+salario_bruto+"\n");
                Console.Write("|SALARIO LIQUÍDO: R$ "+salario_liquido+"\n");
                Console.Write("|CONTRIBUIÇÃO INSS - 'NÃO HÁ DESCONTO PARA ESTA FAIXA SALARIAL\n");
                Console.Write("|CONTRIBUIÇÃO IRPF - PARCELA A DEDUZIR: R$ 869.36\n");
            }
        }
    }
}