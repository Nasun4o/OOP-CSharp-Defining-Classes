using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        public Person(string name, int age) : this(name, age, null)
        {
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Name cannot be null");
                }
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if ((value < 1) && (value > 100))
                {
                    throw new ArgumentOutOfRangeException("Invalid Age, You can't be minus age or over hundred ");
                }
                age = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if ((value == null) || (value.Length < 1  && value.Contains("@")))
                {
                    throw new ArgumentException("Invalid email adress");
                }
                email = value;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine(name + " " + age + " " + email);
        }
    }
}
