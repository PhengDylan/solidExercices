using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    class MulOperation : Ioperation
    {
        private decimal resultat;
        public decimal Calcule(string[] tabsString)
        {
                
                resultat = Convert.ToDecimal(tabsString[0]);
                for (int i = 1; i < tabsString.Length; i++)
                {
                    resultat = resultat * Convert.ToDecimal(tabsString[i]);
                }
            return resultat;
        }
     }
}
