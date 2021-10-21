using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {

        public RankedGradeBook( string name) : base( name )
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {

            if (Students.Count < 5)
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");
                        
            //sort the list of students by their average grade descending
            List<Student> SortedByGrade = Students.OrderByDescending(o => o.AverageGrade).ToList();

            //Calculate 20%, 40%, 60%, 80% of the total student list (round down) 
            int aCount = Convert.ToInt32(Math.Floor(.2 * SortedByGrade.Count));
            int bCount = Convert.ToInt32(Math.Floor(.4 * SortedByGrade.Count));
            int cCount = Convert.ToInt32(Math.Floor(.6 * SortedByGrade.Count));
            int dCount = Convert.ToInt32(Math.Floor(.8 * SortedByGrade.Count));

            double lastAGrade = Students[aCount - 1].AverageGrade;
            double lastBGrade = Students[bCount - 1].AverageGrade;
            double lastCGrade = Students[cCount - 1].AverageGrade;
            double lastDGrade = Students[dCount - 1].AverageGrade;

            if (averageGrade >= lastAGrade)
                return 'A';
            else if (averageGrade >= lastBGrade)
                return 'B';
            else if (averageGrade >= lastCGrade)
                return 'C';
            else if (averageGrade >= lastDGrade)
                return 'D';
            else
                return 'F';
        }

    }
}
