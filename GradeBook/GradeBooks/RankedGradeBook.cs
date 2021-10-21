using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {

        public RankedGradeBook( string name, GradeBookType type) : base( name )
        {
            type = GradeBookType.Ranked;
        }

    }
}
