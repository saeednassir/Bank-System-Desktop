using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System_Project
{
    public class clsPerson
    {
        private string FirstName;

        private string LastName;

        private string Email;

        private string Phone;


        public clsPerson(string FirstName,string LastName,string Email,string Phone)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
        } 
        
        public string GetFirstName()
        {
            return this.FirstName;
        }

        public void SetFirstName(string FirstName)
        {
            this.FirstName = FirstName;
        }

        public string GetLastName()
        {
            return this.LastName;
        }

        public void SetLastName(string LastName)
        {
            this.LastName = LastName;
        }

        public string GetFullName()
        {
            return GetFirstName() + " " + GetLastName();
        }

        public string GetEmail()
        {
            return this.Email;
        }

        public void SetEmail(string Email)
        {
            this.Email = Email;
        }

        public string GetPhone()
        {
            return this.Phone;
        }
      
        public void SetPhone(string Phone)
        {
            this.Phone = Phone;
        }

    }
}
