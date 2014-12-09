using System;

public class CSharpExam : Exam
{
    public int Score { get; private set; }

    public CSharpExam(int score)
    {
        if (score < 0 || Score > 100)
        {
            throw new ArgumentOutOfRangeException("score", "The score must be between 0 and 100.");
        }

        this.Score = score;
    }

    public override ExamResult Check()
    {
        return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
    }
}
