using System;

namespace _4_oct_21_p2
{
    class Student
    {
        int Stdid, stu_age;
        string Stu_name, course;
        int maths, english, Science, total;
        public void Student_Details(int id, string name, int age, string course)
        {
            this.Stdid = id;
            this.stu_age = age;
            this.Stu_name = name;
            this.course = course;
            


        }
        public Student(int eng, int Math, int sci)
        {
            Console.WriteLine("Hi....this is student class default constrcutor");
            this.english = eng;
            this.maths = Math;
            this.Science = sci;
            total = sci + eng + Math;
        }
            
        void display()
        {
            Console.WriteLine("Student id =" + Stdid);
            Console.WriteLine("Student name=" + Stu_name);
            Console.WriteLine("Student age =" + stu_age);
            Console.WriteLine("Course =" + course);
            Console.WriteLine("total marks= " + total);
        }
        static void Main(string[] args)
        {
            Student s = new Student(99,87,93);
            s.Student_Details(1, "Rajanikant", 22, "IT");
            s.display();
        }
    }
}
//this is constructor and overloading program example