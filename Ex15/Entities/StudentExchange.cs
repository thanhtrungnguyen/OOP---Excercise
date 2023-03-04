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

        public StudentExchange(string id, string fullname, DateTime birthDate, int startYear, float entryPoint, List<MarkReport> markReports, string partnerInstitution) : base(id, fullname, birthDate, startYear, entryPoint, markReports)
        {
            this.PartnerInstitution = partnerInstitution;
        }

        public override string ToString()
        {
            return string.Format("{0}, PartnerInstitution: {1}", base.ToString(), PartnerInstitution);
        }

        public override void Show()
        {
            Console.WriteLine("ExchangeStudent: {{{0}, {1}}}", base.ToString(), this.ToString());
        }
    }
}
