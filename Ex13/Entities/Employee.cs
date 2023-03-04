using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.Entities
{
	internal class Employee
	{
		private string _id;

		public string ID
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		private DateTime _birthDate;

		public DateTime BirthDate
		{
			get { return _birthDate; }
			set { _birthDate = value; }
		}
		private string _phone;

		public string Phone
		{
			get { return _phone; }
			set { _phone = value; }
		}
		private string _email;

		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}
		private List<Certificate> _certificates;

		public List<Certificate> Certificates
		{
			get { return _certificates; }
			set { _certificates = value; }
		}

		public Employee(string id, string name, DateTime birthDate, string phone, string email, List<Certificate> certificates)
		{
			this.ID = id;
			this.Name = name;
			this.BirthDate = birthDate;
			this.Phone = phone;
			this.Email = email;
			this.Certificates = certificates;
		}
		public override string ToString()
		{
			string combinedString = string.Empty;
			Certificates.ForEach(e => { combinedString += e.ToString(); });
			return string.Format("ID: {0}, \nName: {1}, \nBirthDate: {2}, \nPhone: {3}, \nEmail: {4}, \nList certificates: [\n{5}]", ID, Name, BirthDate, Phone, Email, combinedString);
		}
		public virtual void Show()
		{
			Console.WriteLine();
		}
	}
}
