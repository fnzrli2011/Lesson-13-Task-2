using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson15
{
    public interface IAccount
    {
        public bool PasswordChecker (string password);
        public void ShowInfo();
    }
}