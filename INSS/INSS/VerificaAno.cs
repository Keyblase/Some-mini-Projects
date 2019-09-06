using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    class VerificaAno : CalcularInss
    {
        
        public static int VerficiadorDeAnoeSalarioAtual(DateTime anoAtual, decimal salario)
        {
            CalcularInss calcular = new CalcularInss();

            if (anoAtual.Year == 2011)
            {             
                if(salario <= 1106.90m)
                {
                    
                    calcular.CalcularDesconto(anoAtual, salario);
                    return anoAtual.Year;
                }
                if (salario <= 1844.83m)
                {

                }
                if (salario <= 3689.66m)
                {

                }
                if (salario > 3689.66m)
                {

                }

            }
            else if (anoAtual.Year == 2012)
            {
                calcular.CalcularDesconto(anoAtual, salario);
                return anoAtual.Year;
            }

            /* else if(anoAtual.Year == XXXX) independente do numero que vier
                {
                calcular.CalcularDesconto(anoAtual, salario);
               return anoAtual.Year;
               }
            */

            else
            {
                Console.WriteLine("Erro! ano da tabela não encontrado");
                return 0;
            }
        }
    }
}
