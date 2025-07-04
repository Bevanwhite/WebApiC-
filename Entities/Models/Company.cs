using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Company
    {
        [Column("CompanyId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Company namr is required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the namr is 60 characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Company address is required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the address is 60 characters.")]
        public string? Address { get; set; }

        public string? Country { get; set; }

        public ICollection<Employee>? Employess { get; set; }
    }

}