using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RequestModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public RequestModel()
        {
            Email = "someEmail3@gmail.com";
            Password = "Some3.com";
            ConfirmPassword = "Some3.com";
            FirstName = "Someemail";
            LastName = "Someemail";
        }
    }
}
