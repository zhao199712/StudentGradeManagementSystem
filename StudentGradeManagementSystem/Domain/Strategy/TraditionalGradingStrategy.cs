using System.Collections.Generic;

namespace StudentGradeManagementSystem.Domain.Strategy
{
    public class TraditionalGradingStrategy : IGradingStrategy
    {
        public string GetLetterGrade(double score, IEnumerable<double> allScores)
        {
            return score switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _ => "F"
            };
        }

        public bool IsPassing(double score) => score >= 60;
    }
}