using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson13
{
    public class Car
    {
        private static int _id=0;
        public int Id {get; private set;}
        public string Brand {get ; set ;}
        public string model { get ; set ;}

        public Car()
        {
            _id+=1;
            Id=_id;
        }

        public override string ToString()
        {
            return  $"Adi : {Brand} Model : {model} Id : {Id} Type {Type.Sport}";
        }
    }
}