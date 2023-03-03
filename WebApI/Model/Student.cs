using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApI.Model
{
    [Table("tblstudent")]
    public class Student
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Mobileno { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set;}
        [Required]  
        public int Percentage { get; set; }
    }
}
