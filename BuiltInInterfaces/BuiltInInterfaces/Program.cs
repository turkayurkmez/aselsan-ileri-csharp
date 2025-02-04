// See https://aka.ms/new-console-template for more information
using BuiltInInterfaces;
using System.Collections;

Console.WriteLine("Hello, World!");
Student student1 = new() { Id = 1, Name = "Türkay", Score = 80 };
Student student2 = new() { Id = 2, Name = "Müslüme", Score = 95 };
Student student3 = new() { Id = 3, Name = "Meryem", Score = 82 };

Students students = new();
students.Add(student1);
students.Add(student2);
students.Add(student3);

//var sortedStudents = students.SortStudents();
students.SortStudents();
//foreach (var student in sortedStudents)
//{
//    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Score: {student.Score}");
//}

foreach (var student in students)
{
    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Score: {student.Score}");
}

ArrayList elements = new();
elements.Add("Fasülye");
elements.Add(1.5);
elements.Add('X');
elements.Add(new Random());

List<string> markalar = new();

//markalar.Add()

int firstElement = (int)elements[0];