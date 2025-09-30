using System.ComponentModel.Design.Serialization;
using System.Security.Authentication;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace SQlSs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new ApplicationContext())
            {
                var student1 = new Student
                {
                    Id = 1,
                    Name = "Иван",
                    SurName = "Иванов"
                };

                var student2 = new Student
                {
                    Id = 2,
                    Name = "Мария",
                    SurName = "Смирнова"
                };

                var student3 = new Student
                {
                    Id = 3,
                    Name = "Алексей",
                    SurName = "Петров"
                };

                context.Students.Add(student1);
                context.Students.Add(student2);
                context.Students.Add(student3);
                context.SaveChanges();

                Console.WriteLine("Студенты добавлены");
            }
            using (var context = new ApplicationContext())
            {
                var students = context.Students.ToList();
                Console.WriteLine("Список обьектов:");
                foreach (Student std in students)
                {
                    Console.WriteLine($"{std.Id}. {std.Name}");
                }
            }
        }

    }
}