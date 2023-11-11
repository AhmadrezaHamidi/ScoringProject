using Domain.Model.Rules;
using Domain.Model.Rules.Calculations;
using Domain.Model.Rules.Criterias;

namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Scoring_Applies_to_Work_Experiense()
        {
            var applience = new ApplicantCondition()
            {
                FireDate = new DateTime(2018, 01, 01),
            };

            var workingExperience = new WorkingExperience(TimeSpan.FromDays(365));
            var rule = new Rule(workingExperience, 1, "more thatn 2 years  ");
            rule.SetCalculation(CalculationStrategy.IncreasePointTo(1));
            var pointes = rule.Calculate(applience);

            Assert.Equal("1","0");
            //pointes.Be(2);
        }
    }


}