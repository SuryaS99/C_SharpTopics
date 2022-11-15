using System;

namespace Classes_Object
{
    class Students
    {
        int rollno;
        string name;
        int age;
        int standard;

        //set the roll no
        public void setStudent(int rollno, string name, int age, int standard)
        {
            this.rollno = rollno;
            this.name = name;
            this.age = age;
            this.standard = standard;
        }
        //get the roll no

        public void getStudent()
        {
            Console.WriteLine("your roll no is: {0}", this.rollno);
            Console.WriteLine("your name is: {0}", this.name);
            Console.WriteLine("your age no is: {0}", this.age);
            Console.WriteLine("your standard is: {0}", this.standard);
        }
        static void Main(string[] args)
        {
            //object creation

            Students Annu = new Students();
            Annu.setStudent(20, "Annu", 12, 4);
            Annu.getStudent();
            Console.WriteLine("_________________________");
            Students asad = new Students();
            Annu.setStudent(20, "asad", 12, 4);
            Annu.getStudent();

            //Console.ReadLine();

            //User input object creation
            //Console.WriteLine("Enter Your Roll no");
            //int roll = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Your Name");
            //string name= Console.ReadLine();

            //Console.WriteLine("Enter Your Age");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Your Standard");
            //int std = int.Parse(Console.ReadLine());

            //object are instance of class
            //Students info = new Students();
            //info.setStudent(roll,name,age,std);
            //info.getStudent();
        }
    }
}
