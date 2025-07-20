using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGradeManagementSystem.Domain.Strategy
{
    public class CurvedGradingStrategy : IGradingStrategy
    {
        public string GetLetterGrade(double score, IEnumerable<double> allScores)
        {
            var avg = allScores.Average();
            var stdDev = Math.Sqrt(allScores.Select(s => Math.Pow(s - avg, 2)).Average());
            var z = (score - avg) / stdDev;

            return z switch
            {
                > 1.0 => "A",
                > 0.0 => "B",
                > -1.0 => "C",
                _ => "D"
            };
        }

        public bool IsPassing(double score) => score >= 50;
    }
}