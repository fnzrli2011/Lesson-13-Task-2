using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Formats.Tar;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lesson15
{
    public class Group
    {
        private string gno {get; set;}
        public string GroupNo 
        {
            get
            {
                return gno;
            }
            set
            {
                if(CheckGroupNo(value)==true) gno = value;
            }
        }
        private int sl {get; set;}
        public int StudentLimit 
        {
            get
            {
                return sl;
            }
            set
            {
                int minimum=5;
                int max =18;
                if(value>=5 && value<=max) sl=value;
            }
        }   
        private Student[] Students = new Student[0];

        public bool CheckGroupNo(string groupno)
        {
            char[] gn=  groupno.ToCharArray();
            bool tf=false;
            if(gn.Length>5)
            {
                return tf;
            }
           for(int i=0;i<2;i++)
           {
             if(Char.IsUpper(gn[i])==true)
             {
                continue;
             }
             else
             {
                return tf;
             }
           } 
           for(int i=2;i<5;i++)
           {
            if(Char.IsDigit(gn[i])==true)
             {
                continue;
             }
             else
             {
                return tf;
             }
           }
           tf=true;
           return tf;
        }
        public void AddStudent(Student student)
        {
            if(Students.Length+1<=StudentLimit)
            {
               Array.Resize(ref Students,Students.Length+1);
               Students[Students.Length-1]=student;
               System.Console.WriteLine("Groupa Xos geldin cocugim.Akilli kamalli ol");
            }
            else
            {
                System.Console.WriteLine("Malesef cocugum qrup doludur");
            }
        }
        public void GetStudent(int? id)
        {
            if(id==null)
            {
                throw new NullReferenceException("id daxil edin");
            }
             foreach (Student student in Students)
            {
                if(student.ID==id)
                {
                    System.Console.WriteLine(student); 
                }
            }
        }
        public Student[] GetAllStudent()
        {
            return Students;
        } 
        public Group(string Gn,int SL)
        {
            GroupNo=Gn;
            StudentLimit=SL;
        }
    }
}