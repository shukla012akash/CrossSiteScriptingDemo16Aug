using System.ComponentModel.DataAnnotations;

namespace XSSDemo16Aug.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; } 
        public string? Name { get; set; }
        public string ?Bio { get; set; }    
    }
}
