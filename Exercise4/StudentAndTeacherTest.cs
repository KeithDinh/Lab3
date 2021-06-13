using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class StudentAndTeacherTest
    {
        static void Main()
        {
            Person person = new Person();
            person.SayHello();

            Student student = new Student();
            student.Age = 21;
            student.SayHello();
            student.showAge();

            Teacher teacher = new Teacher();
            teacher.Age = 30;
            teacher.SayHello();
            teacher.Explain();
        }
    }
}
