using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson15
{
    public class Student
    {
        private static long _ID=0;
        public long ID {get; private set;}
        public string Fullname {get; set;}
        public decimal Point {get; set;}
        public Student(string fullname , decimal point)
        {
            Fullname=fullname;
            Point=point;
            _ID++;
            ID=_ID;
        }
        public string ShowInfoStudent()
        {
            return $"Adi ve Soyadi: {Fullname} Bali : {Point} Id : {ID} ";   
        }
        public override string ToString()
        {
            return ShowInfoStudent();
        }

    }
}