using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex5
{
    class Cobrar
    {
        private decimal valor;
        private decimal multa;

        public Cobrar(decimal valor, decimal multa)
        {
            this.valor = valor;
            this.multa = multa;
        }

        private decimal CalcularMulta()
        {
            return valor + multa;
        }

        public void Calcular()
        {
            decimal somaValor = CalcularMulta();
            Console.WriteLine("Valor cobrado: " + valor + ", Multa: " + multa + ", Soma valor: " + somaValor);
        }
    }
}
    
