using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    class SumOperation : Ioperation
    {
        private decimal resultat;
        public decimal Calcule(string[] tabsString)
        {
            for (int i = 0; i < tabsString.Length; i++)
            {
                resultat = resultat + Convert.ToDecimal(tabsString[i]);
            }
            return resultat;
        }
    }
    
}
