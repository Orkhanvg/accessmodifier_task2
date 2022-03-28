using System;

namespace Access_Modifierspart_2.model3
{
    class Person2
    {
        private string _name;
        public string Name
        {
            get
            {
                { return _name; }


            }
            set
            {
                if (char.IsUpper(value[0]) == true && value.Length < 30 && value.Length > 3)
                {
                    _name = value;
                    Console.WriteLine("name be set");
                    return;
                }
                else
                {
                    Console.WriteLine("it is not correct!");

                }
            }
        }


        private string _surname;
        public string Surname
        {
            get
            {
                { return _surname; }


            }
            set
            {
                if (value.Length < 35 && value.Length > 3 && char.IsUpper(value[0]) == true)
                {
                    _surname = value;
                    Console.WriteLine("surname be set");
                    return;

                }
                else
                {
                    Console.WriteLine("it is not correct!");
                }
            }
        }


        private int _age;
        public int Age
        {
            get
            {
                { return _age; }


            }
            set
            {
                { _age = value; }
            }
        }


        public Person2(string name, int age)
        {
            Name = name;
            Age = age;

        }
        public Person2()
        {

        }
    }
}







