using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    class Calculation
    {
        private readonly List<Ioperation> _operation;
        public Calculation()
        {
            _operation.Add(new SumOperation());
            _operation.Add(new SubOperation());
            _operation.Add(new MulOperation());
            _operation.Add(new DivOperation());

        }

        public decimal Calcul(int index, string[] nombre)
        {
            return _operation[index].Calcule(nombre);
        }

    }
}
