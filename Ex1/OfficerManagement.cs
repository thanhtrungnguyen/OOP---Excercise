using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class OfficerManagement
    {
        List<Officer> officers;

        public OfficerManagement()
        {
            officers = new List<Officer>();
        }

        public void AddOfficer(Officer officer)
        {
            officers.Add(officer);
        }
        public void SearchOfficer(string keyword)
        {
            IEnumerable<Officer> list = officers.Where(officer => officer.Name.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0);
            foreach (Officer officer in list) { officer.Show(); }
        }
        public void ShowOfficers()
        {
            officers.ForEach(officer => { officer.Show(); });
        }
    }
}
