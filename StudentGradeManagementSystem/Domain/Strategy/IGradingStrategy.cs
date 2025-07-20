namespace StudentGradeManagementSystem.Domain.Strategy;

public interface IGradingStrategy
{
    string GetLetterGrade(double score, IEnumerable<double> allScores);
    bool IsPassing(double score);
}