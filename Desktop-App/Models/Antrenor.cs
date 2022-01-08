using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_App.Models
{
	class Antrenor
	{

		private string firstName, lastName, phoneNumber;

		public Antrenor()
		{
			this.firstName = null;
			this.lastName = null;
			this.phoneNumber = null;
		}

		public Antrenor(string FirstName, string LastName, string PhoneNumber)
        {
			this.firstName = FirstName;
			this.lastName = LastName;
			this.phoneNumber = PhoneNumber;
		}

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
