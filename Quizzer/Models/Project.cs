using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Quizzer.Models
{
    [Table("Projects", Schema = "public")]
    public class Project
    {
        [Key]
        [Column("ProjectId")]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Description { get; set; }
    }
}