using Domain.Framwork;
using Domain.Model.Rules.Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Rules
{
    public class Rule
    {
        public Specification<ApplicantCondition> _criteria { get; private set; }
        public CalculationStrategy calculation { get; private set; }
        public int Id { get;private set; }
        public string  title { get;private set; }

        public Rule(Specification<ApplicantCondition> criteria, int id, string title)
        {
            _criteria = criteria;
            Id = id;
            this.title = title;
            this.calculation = CalculationStrategy.NeturalCalculation;

        }
        public void SetCalculation(CalculationStrategy calculation)
        {
            this.calculation = calculation;
        }  

        public int Calculate(ApplicantCondition applicantCondition)
        {
            if (_criteria.IsSatisfiedBy(applicantCondition))
            {
                return this.calculation.value;
            }
            return 0;
        }




    }





    public class Citeria
    {

    }
}
