using System.ComponentModel.DataAnnotations;
using System.Formats.Tar;
using System.Threading.Channels;
using Lesson15;

class Program
{
    public static void Main (String[] args)
    {
        Student [] stds = new Student[0];
        User[] users = new User[0];
        Group[] groups = new Group[0];
        string user1mail="ferid123@gmail.com";
        string user1password="Ferid1234";
        User user1 = new User(user1mail,user1password) {FullName="Nazarli Farid"};
        Student student= new Student("Salam Salamli",100);
        Array.Resize(ref stds,stds.Length+1);
        stds[stds.Length-1]=student;
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
             System.Console.WriteLine("gropunuz yaradildi!!!");
             System.Console.WriteLine();
             bool h = true;
             while(h==true)
             {
             System.Console.WriteLine("1.Show all students");
             System.Console.WriteLine("2.Get Students by Id");
             System.Console.WriteLine("3.Add students");
             System.Console.WriteLine("Groupa student elave edin");
             System.Console.WriteLine("0.Quit");
             System.Console.WriteLine("Emri daxil edin : ");
             int cmd=Convert.ToInt32(Console.ReadLine());
             if(cmd==1)
             {
                group.GetAllStudent();
             }
             else if(cmd==2)
             {
                System.Console.WriteLine("Id daxil edin : ");
                int _id_=Convert.ToInt32(Console.ReadLine());
                group.GetStudent(_id_);
             }
             else if(cmd==3)
             {
                System.Console.WriteLine("Studentin FullNameni daxil edin : ");
                string fln=Console.ReadLine();
                System.Console.WriteLine("Derslerdeki ugur balini daxil edin : ");
                decimal pnt=Convert.ToDecimal(Console.ReadLine());
                Student student1 = new Student (fln,pnt);
             }
             else if(cmd == 4)
             {
                System.Console.WriteLine("Elave edilecek sagirdin Id sini daxil edin : ");
                long _ID_=Convert.ToInt64(Console.ReadLine());
                foreach (var item in stds)
                {
                    if(item.ID==_ID_)
                    {
                        group.AddStudent(item);
                    }
                }
             }
             else if(cmd==0)
             {
                h=false;
             }
             else
             {
                System.Console.WriteLine("Bele bir emr yoxdu!!!");
             }
             }
       }
       else if(command == 3)
       {
        System.Console.WriteLine("Programdan cixis edildi!!!");
        command3=false;
       }
       else
       {
        System.Console.WriteLine("Bele emr yoxdu");
       }
        }
    }
}