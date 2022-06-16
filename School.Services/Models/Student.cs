using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Services.Models
{
    [Table("Students")]
    public  class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int RollNo { get; set; }
        public string Address { get; set; }
       
    }
}
