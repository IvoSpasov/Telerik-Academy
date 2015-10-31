using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("grade", "The grade should be positive number.");
        }
        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("minGrade", "The minGrade should be positive number.");
        }
        if (maxGrade < minGrade)
        {
            throw new ArgumentOutOfRangeException("maxGrade", "The maxGrade must have a greater value than minGrade.");
        }
        if (string.IsNullOrEmpty(comments))
        {
            throw new ArgumentNullException("comments", "The comments should not be null or empty string.");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
