using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public  class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Surname{ get; set; }
        public int _Age { get; set; }
        public float _PhoneNumber { get; set; }

        public User( string name, string serName, int age, float phoneNumber)
        {  
            Name = name;
            Surname = serName;
            _Age = age;
            _PhoneNumber = phoneNumber;
        }
    }
}
