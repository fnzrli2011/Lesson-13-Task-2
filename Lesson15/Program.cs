using System.ComponentModel.DataAnnotations;
using Lesson15;

class Program
{
    public static void Main (String[] args)
    {
        string user1mail="ferid123@gmail.com";
        string user1password="Ferid1234";
        User user1 = new User(user1mail,user1password) {FullName="Nazarli Farid"};
        // if(user1.PasswordChecker(user1.Password)==true)
        // {
        //     System.Console.WriteLine("Password setleri uygundur");
        // }
        // else
        // {
        //     System.Console.WriteLine("pasword sertleri qarsilamir");
        // }
        // user1.ShowInfo();
    }
}