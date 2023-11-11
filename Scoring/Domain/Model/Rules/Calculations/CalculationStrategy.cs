using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Rules.Calculations
{
    public  class CalculationStrategy
    {
        public static CalculationStrategy NeturalCalculation = new CalculationStrategy(0);
        public  int value { get;private set; }

        public CalculationStrategy(int value)
        {
            this.value = value;
        }

        public static CalculationStrategy IncreasePointTo(int value) {
            return new CalculationStrategy(value);
        }



        public static CalculationStrategy DecressPointTo(int value)
        { 
            return new CalculationStrategy(value=-1);
        }



    }
}
