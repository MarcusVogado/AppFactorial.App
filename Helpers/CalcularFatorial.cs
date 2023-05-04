using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFactorial.Helpers
{
    public class CalcularFatorial : ICaulcularFatorial
    {
        public int Calcular(int numero)
        {  
            if (numero <= 1)return 1;
            Calcular(numero - 1);
            return numero * Calcular(numero-1);
        }
    }
}
