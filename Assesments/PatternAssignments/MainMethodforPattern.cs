using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesments.PatternAssignments
{
    public class MainMethodforPattern
    {
        static void Main(string[] args)
        {
            
            AllPatterns pattern = new AllPatterns();

            //1.Star right angled triangle
          //  pattern.RightTriangleStar(5);

            //2.Reverse right angles trianlge
            pattern.ReverseRightTriangleStar(5);
        }
    }
}
