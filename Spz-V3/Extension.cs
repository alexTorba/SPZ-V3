using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lb1
{
    public static class Extension
    {
        public static bool IsEmptyOrContainNumber(this string str)
        {
            string pattern = @"\d+";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(str) || String.IsNullOrEmpty(str))
                return true;

            return false;
        }

        public static void FillMarks(this Student student)
        {
            for (int i = 0; i < student.Marks.Count; i++)
            {
                student.Marks[(Subjects)i] =
                    new Random(Guid.NewGuid().GetHashCode()).Next(55, 100);
            }
        }
    }
}
