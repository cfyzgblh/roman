using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public interface IUser
    {
        public string Name { get; }
        public string Password { get; }
        public string Login { get; }
        public int Id { get; } 
        
    }

    
}
