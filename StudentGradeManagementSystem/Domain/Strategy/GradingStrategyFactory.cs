using System;

namespace StudentGradeManagementSystem.Domain.Strategy
{
    public static class GradingStrategyFactory
    {
        public static IGradingStrategy Create(string strategyType)
        {
            return strategyType.ToLower() switch
            {
                "traditional" => new TraditionalGradingStrategy(),
                "curved" => new CurvedGradingStrategy(),
                _ => throw new ArgumentException($"未知的策略型別: {strategyType}")
            };
        }
    }
}