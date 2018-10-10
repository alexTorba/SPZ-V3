using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2_V2._0
{
    static class Extension
    {
        public static University FindById(this List<University> universities, int id)
        {
            foreach (var u in universities)
            {
                if (u.Id == id)
                    return u;
            }
            return null;
        }

        public static University FindByName(this List<University> universities, string name)
        {
            foreach (var u in universities)
            {
                if (u.Name == name)
                    return u;
            }
            return null;
        }

        public static void ChangeUniversityById(this List<University> universities, int id, University university)
        {
            for (int i = 0; i < universities.Count; i++)
            {
                if (universities[i].Id == id)
                    universities[i] = university;

            }
        }

        public static List<string> GetNamesUniverstyes(this List<University> universities)
        {
            List<string> names = new List<string>();

            foreach (University u in universities)
            {
                names.Add(u.Name);
            }

            return names;
        }
    }
}
