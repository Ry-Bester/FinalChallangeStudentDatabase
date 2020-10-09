using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FinalChallangeStudentDatabase.Models;
using Microsoft.Ajax.Utilities;

namespace FinalChallangeStudentDatabase.DAL
{
    public class SchoolInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
        {
            new Student{FirstMidName="Bob", LastName="Jones"},
            new Student{FirstMidName="Billy", LastName="Bob"},
            new Student{FirstMidName="Cloud", LastName="Strife"},
            new Student{FirstMidName="Mary", LastName="Sue"},
            new Student{FirstMidName="Joe", LastName="Blow"},
            new Student{FirstMidName="Brad", LastName="Pitt"},
            new Student{FirstMidName="Tony", LastName="Stark"},
            new Student{FirstMidName="Joe", LastName="Jones"},
            new Student{FirstMidName="Patty", LastName="Pie"},
            new Student{FirstMidName="Jill", LastName="Cherry"},

        };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            
        }
        
       
    }
}