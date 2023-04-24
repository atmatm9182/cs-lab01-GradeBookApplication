namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            var twentyPercent = (float)Students.Count / 5;
            var count = 0;

            foreach(var student in Students)
            {
                if(student.AverageGrade > averageGrade)
                {
                    count++;
                }
            }

            var percentage = (float)count / Students.Count;
            if(percentage <= 0.2)
            {
                return 'A';
            }
            else
            {
                if(percentage <= 0.4)
                {
                    return 'B';
                }
                if(percentage <= 0.6)
                {
                    return 'C';
                }
                if(percentage <= 0.8)
                {
                    return 'D';
                }
                return 'F';
            }
        }
    }
}