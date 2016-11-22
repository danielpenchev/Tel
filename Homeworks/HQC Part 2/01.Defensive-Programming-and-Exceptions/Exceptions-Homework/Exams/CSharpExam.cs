using System;

public class CSharpExam : Exam
{
    public CSharpExam(int score)
    {
        if (this.Score < 0 || this.Score > 100)
        {
            throw new ArgumentOutOfRangeException("Score must be a value between 0 and 100.");
        }

        this.Score = score;
    }

    public int Score { get; set; }

    public override ExamResult Check()
    {
        return new ExamResult(this.Score, 0, 100, "Eam results calculated by score.");
    }
}
