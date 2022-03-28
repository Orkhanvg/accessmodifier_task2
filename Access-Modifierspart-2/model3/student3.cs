using System;

namespace Access_Modifierspart_2.model3
{
    class Student3:Person2
    {
        private int _point;
        public int Point
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
        public Student3(int point1, string name, int age):base(name, age)
        {
            Point = point1;
        }
        public Student3()
        {

        }
       
    }
}
