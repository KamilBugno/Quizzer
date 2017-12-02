using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Quizzer.Models
{
    public class Context : DbContext
    {
        public Context() : base(nameOrConnectionString: "QuizzerEntities") { }

        public DbSet<Project> Project { get; set; }
    }
}