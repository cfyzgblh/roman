using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7
{
    public class User
    {
        public string Name { get; set; }
        public string Sername { get; set; }
        public int Age { get; set; }

        public User(string name, string sername, int age)
        {
            Name = name;
            Sername = sername;
            Age = age;
        }
    }
}
