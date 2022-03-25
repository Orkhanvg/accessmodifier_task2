using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifierspart_2.model3
{
    class student3 : person2
    {
        private int _point;
        public int point
        {
            get
            {
                { return _point; }


            }
            set
            {
                if (value < 100 || value > 0)
                {
                    _point = value;
                    Console.WriteLine("Point be set");
                    return;
                }
                else
                {
                    Console.WriteLine("it is not correct!");
                    return;
                }

            }



        }
        public student3(int point1, string name, int age) : base(name, age)
        {
            point1 = point;
        }
        public student3()
        {

        }
        //    public void getinfo()
        //    {

        //        Console.WriteLine($"Name      {Name}, Surname        {Surname},Age      {Age},      Point       {point}       ");
        //    }
        //}
    }
}
