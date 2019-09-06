using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    class CalcularInss : ICalculadorInss
    {
        //public float ICalculadorInss.Desconto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public decimal CalcularDesconto(DateTime data, decimal salario)
        {
            if(data.Year == 2011 && salario <= 1106.90m)
            {
                return salario * 0.08m;
            }
            if (data.Year == 2011 && salario <= 1844.83m)
            {
                return salario * 0.09m;
            }
            if (data.Year == 2011 && salario <= 3689.66m)
            {
                return salario * 0.11m;
            }
            if (data.Year == 2011 && salario > 3689.66m)
            {
                return 405.86m;
            }


            if (data.Year == 2012 && salario <= 1000.00m)
            {
                return salario * 0.07m;
            }
            if (data.Year == 2012 && salario <= 1500.00m)
            {
                return salario * 0.08m;
            }
            if (data.Year == 2012 && salario <= 3000.00m)
            {
                return salario * 0.09m;
            }
            if (data.Year == 2012 && salario <= 4000.00m)
            {
                return salario * 0.11m;
            }
            if (data.Year == 2012 && salario > 4000.00m)
            {
                return 500.00m;
            }

            else return 0.0m;
        }

        decimal ICalculadorInss.CalcularDesconto(DateTime data, decimal salario)
        {
            throw new NotImplementedException();
        }
    }
}
