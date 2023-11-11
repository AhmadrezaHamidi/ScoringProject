using Domain.Framwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Rules.Criterias
{
    internal class tt
    {
    }

    public class WorkingExperience : Specification<ApplicantCondition>
    {
        public override bool IsSatisfiedBy(ApplicantCondition value)
        {
            return false;
        }
    }
}
