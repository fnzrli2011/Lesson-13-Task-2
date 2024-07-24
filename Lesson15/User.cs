using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace Lesson15
{
    public class User : IAccount
    {
        private static long _id=0;
        public long Id {get; private set;}
        public string FullName {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}
         public User(string email , string password2)
        {
            Email = email;
            Password=password2;
            _id++;
            Id=_id;
        }
        public bool PasswordChecker(string password)
        {
            char[] pass =password.ToCharArray();
            if(password.Length>=8 && password.Any(x=>char.IsUpper(x)) && password.Any(x=>char.IsLower(x)) && password.Any(x=>char.IsDigit(x)))
            {
                return true;
            }
            return false;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine($"Id : {Id} Adi ve Soyadi : {FullName} Mail unvani {Email}");        
        }
    }
}