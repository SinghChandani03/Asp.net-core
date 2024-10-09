using System.ComponentModel.DataAnnotations;

namespace CRUDApp.Models
{
    public class Student
    {
         public int id { get; set; }

         [Required]
         public string firstName { get; set; }

         [Required]
         public string email { get; set; }

         [Required]
         public string password { get; set; }
    }
}
