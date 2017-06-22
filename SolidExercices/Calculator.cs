using System;
using System.Linq;

namespace SolidExercices
{
    public class Calculator
    {
        public double Calculate(string operation)
        {

            double resultat = 0;
            //On enlève tout les espaces possible dans le String
            var operationTrim = operation.Trim();


            //////////////////*          Gestion d'une addition              *//////////////////
           if (operationTrim.Contains('+') == true )
            { 
                // 1 -Il faut séparer les opérations des nombres
                var tabString = operationTrim.Split('+');
                // 2- Convertir les différentes chaîne en type double et faire le calcule
                for (int i = 0; i < tabString.Length; i++)
                {
                    resultat = resultat + Convert.ToDouble(tabString[i]);
                }
           }
           
            return resultat;
            // throw new NotImplementedException();
        }

        
    }

    
}