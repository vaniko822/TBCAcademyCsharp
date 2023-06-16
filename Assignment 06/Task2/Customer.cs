using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Customer
    {
        private string _firstname;
        private string _lastname;
        private int _age;
        private string _personalId;

        public string Firstname 
        { 
            get 
            { 
                return _firstname; 
            } 
            set 
            { 
                _firstname = value; 
            } 
        }

        public string Lastname
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public string PersonalId
        {
            get
            {
                return _personalId;
            }
            set
            {
                _personalId = value;
            }
        }
    }
}
