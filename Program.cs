using System;

public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime EnrollmentDate { get; set; }
}
using System.Data.Entity;

public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }
}
class Program
{
    static void Main()
    {
        using (var context = new SchoolContext())
        {
            var newStudent = new Student
            {
                FirstName = "John",
                LastName = "Doe",
                EnrollmentDate = DateTime.Now
            };

            context.Students.Add(newStudent);
            context.SaveChanges();

            Console.WriteLine("Student added successfully!");
        }
    
