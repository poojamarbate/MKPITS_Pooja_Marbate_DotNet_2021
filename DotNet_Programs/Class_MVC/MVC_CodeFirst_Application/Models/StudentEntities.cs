using System;
using System.Data.Entity;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace MVC_CodeFirst_Application.Models
{
    public class StudentEntities : DbContext
    {
        // Your context has been configured to use a 'StudentEntities' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MVC_CodeFirst_Application.Models.StudentEntities' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'StudentEntities' 
        // connection string in the application configuration file.
        public StudentEntities()
            : base("name=StudentEntities")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Student> Students{ get; set; }
    }

    //public class MyEntity
    //{
     
    //    public int Id { get; set; }
    //    public string Name { get; set; }

      
    //}
}