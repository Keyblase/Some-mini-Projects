using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    class ReceberInformacoes 
    {
        public static DateTime DateYear { get => DateYear; set => DateYear = DateTime.Now; }
        public static decimal Salario { get => Salario; set => Salario = value; }

        public void ReceberInformacoesEmpregado(DateTime data, decimal salario)
        {
            //Classe verifica ano ;
            VerificaAno.VerficiadorDeAnoeSalarioAtual(data, salario); // retorna o ano em int
        }
    }
}
