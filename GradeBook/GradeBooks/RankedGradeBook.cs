using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook : BaseGradeBook
    {

        public RankedGradeBook( string name, GradeBookType type) : base( name )
        {
            Type = GradeBookType.Ranked;
        }

    }
}
