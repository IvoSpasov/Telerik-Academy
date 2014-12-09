using System;

public class SimpleMathExam : Exam
{
    public int ProblemsSolved { get; private set; }

    public SimpleMathExam(int problemsSolved)
    {
        if (problemsSolved < 0 || 3 < problemsSolved)
        {
            throw new ArgumentException("The problems are three and cannot be a negative number.");
        }

        this.ProblemsSolved = problemsSolved;
    }

    public override ExamResult Check()
    {
        if (ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Bad result: No problems solved.");
        }
        else if (ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Average result: One problem solved.");
        }
        else //if (ProblemsSolved == 2)
        {
            return new ExamResult(6, 2, 6, "Excellent result: All problems solved.");
        }
    }
}
