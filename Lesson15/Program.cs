using System.ComponentModel.DataAnnotations;
using System.Formats.Tar;
using System.Threading.Channels;
using Lesson15;

class Program
{
    public static void Main (String[] args)
    {
        User[] users = new User[0];
        Group[] groups = new Group[0];
        string user1mail="ferid123@gmail.com";
        string user1password="Ferid1234";
        User user1 = new User(user1mail,user1password) {FullName="Nazarli Farid"};
        if(user1.PasswordChecker(user1.Password)==true)
        {
            System.Console.WriteLine("Password setleri uygundur");
            Array.Resize(ref users,users.Length+1);
            users[users.Length-1]=user1;
        }
        else
        {
            System.Console.WriteLine("pasword sertleri qarsilamir");
        }
        bool command3=true;
        while(command3==true){
        System.Console.WriteLine("1.Show info");
        System.Console.WriteLine("2.Create new Group");
        System.Console.WriteLine("3.Exit");
        int command = Convert.ToInt32(Console.ReadLine());
        if(command==1)
        {
            System.Console.WriteLine("Id daxil edin : ");
            long commandid=Convert.ToInt64(Console.ReadLine());
            long k=0;
            long kcopy=k;
            foreach (User user in users)
            {
                if(user.Id==commandid)
                {
                    user.ShowInfo();
                    k++;
                }
            }
            if(k==kcopy)
            {
                System.Console.WriteLine("Bele istifadeci tapilmadi");
            }
        }
        else if(command==2)
        {
            System.Console.WriteLine("Groupun Nomresini daxil edin unutmayin ki, 2 Boyuk herfle baslayan ve 3 reqemle biten 5 isareden ibaret bir element yigini olmalidir");
            string gn=Console.ReadLine();
            System.Console.WriteLine("Gropda ola bilecek usaq sayini daxil edin : ");
            int sl=Convert.ToInt32(Console.ReadLine());
            Group group = new Group(gn,sl);
            if(group.CheckGroupNo(group.GroupNo)==false)
            {
               System.Console.WriteLine("Group Nomresi sertleri odemedi group yaradilmadi :(");
            }
            else
            {
                System.Console.WriteLine("Groupunuz yaradildi");
            }
       }
       else if(command == 3)
       {
        System.Console.WriteLine("Programdan cixis edildi!!!");
        command3=false;
       }
        }
    }
}