using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace EFCoeTest
{
    [Table("Register1")]
    [Index("CreateTime", IsUnique = true)]
    public class User1
    {
        public int Id { get; set; }
        [Required]
        public string Password { get; set; }
        [Column("UserName")]
        [MaxLength(256)]
        [Key]
        public string Name { get; set; }
        public int HelpMoney { get; set; }
        [NotMapped]
        public int FailedTry { get; set; }

         //[Range()] 
        public DateTime CreateTime { get; set; }







    }
}
