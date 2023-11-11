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
        public TimeSpan _timeSpan { get; private set; }

        public WorkingExperience(TimeSpan timeSpan)
        {
            _timeSpan = timeSpan;
        }

        public override bool IsSatisfiedBy(ApplicantCondition value)
        {
            if (value.FireDate.Add(_timeSpan) < DateTime.Now)
                return false;
            return true;
        }
    }
}
