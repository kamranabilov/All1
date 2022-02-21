using System;

namespace At_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Leo","Messi");
            Student studentA = new Student("Tiago", "Messi");
            
            Group groupNum = new Group("Leo", "Messi", "P111", 2);
            
            groupNum.AddStudent(student);
            groupNum.AddStudent(studentA);            

            Student[] students = groupNum.GetStudents();

            foreach (Student A in students)
            {
                Console.WriteLine($"A.Name: {A.Name}\nA.Surname: {A.Surname}");
            } 
        }
    }
}
