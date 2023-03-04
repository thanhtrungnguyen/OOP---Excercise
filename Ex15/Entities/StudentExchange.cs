using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15.Entities
{
    internal class StudentExchange : Student
    {
        private string _partnerInstitution;

        public string PartnerInstitution
        {
            get { return _partnerInstitution; }
            set { _partnerInstitution = value; }
        }

        public StudentExchange(string id, string fullname, DateTime birthDate, int startYear, List<MarkReport> markReports, string partnerInstitution) : base(id, fullname, birthDate, startYear, markReports)
        {
            this.PartnerInstitution = partnerInstitution;
        }
    }
}
