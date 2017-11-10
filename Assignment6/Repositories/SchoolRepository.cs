using Assignment6.DataAccess;
using Assignment6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment6.Repositories
{
    public class SchoolRepository
    {
        private SchoolContext context;

        public SchoolRepository ()
	{
            context = new SchoolContext();
	}





        public ICollection<Student> GetAllStudents()
        {
            return context.Students.ToList();
        }

        public ICollection<Class> GetAllClasses()
        {
            return context.Classes.ToList();
        }

        public Student GetStudentDetails(int id)
        {
            Student s = context.Students.FirstOrDefault(a=>a.StudentID==id);
            return s;

        }

        public void AddStudent(Student student)
        {
            if (student != null)
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }


    }
}