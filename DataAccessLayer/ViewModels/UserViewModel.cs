using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiPKadryIPlace.DataAccessLayer.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }

        private string lastName;
        public string LastName
        {
            get { return lastName.ToUpper(); }
            set { lastName = value; }
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName.ToUpper(); }
            set { firstName = value; }
        }

        private string emailAddress;
        public string EmailAddress
        {
            get { return emailAddress.ToUpper(); }
            set { emailAddress = value; }
        }

        public string name;
        public string Name 
        {
            get { return name.ToUpper(); }
            set { name = value; }
        }

        public string administrator;
        public string Administrator 
        {
            get { return administrator.ToUpper(); }
            set { administrator = value; } 
        }
    }
}
