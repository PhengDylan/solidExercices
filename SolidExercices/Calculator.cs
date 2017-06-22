using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public decimal Calculate(string operation)
        {

            decimal resultat = 0;
            var _operation = new[] {'+', '-', '*', '/'};
            Calculation calcul = new Calculation() ;
            //On enlève tout les espaces possible dans le String
            var operationTrim = operation.Trim();

            for (int index = 0; index < _operation.Length; index++)
                {
                    if (operationTrim.Contains(_operation[index]) == true)
                    {                   
                    var tabString = operationTrim.Split(_operation[index]);
                        resultat = (decimal) calcul.Calcul(index, tabString);
                    }
            }
           

            return resultat;
            // throw new NotImplementedException();
        }

        
    }

    
}