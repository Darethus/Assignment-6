namespace Assignment6.Migrations
{
    using Assignment6.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment6.DataAccess.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Assignment6.DataAccess.SchoolContext context)
        {
            


        Teacher teachers = new Teacher { TeacherID=1, TeacherName="Börje", Classes = new List<Class>()};

        Class classes = new Class {ClassID=1, ClassName="2B", Teachers = new List<Teacher>()};
        Class classes2 = new Class { ClassID = 2, ClassName = "3A", Teachers = new List<Teacher>() };

        classes.Teachers.Add(teachers);
        classes2.Teachers.Add(teachers);

        context.Classes.AddOrUpdate(

                        c => c.ClassID,
                        classes,
                        classes2,
                        new Class { ClassID = 3, ClassName = "1B" }
                        );
        

        }

       
    }
}
