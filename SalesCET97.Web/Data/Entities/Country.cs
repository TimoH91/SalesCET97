using System.ComponentModel.DataAnnotations;

namespace SalesCET97.Web.Data.Entities
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Pais")]
        [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo {1} carateres")]
        [Required(ErrorMessage ="0 campo {0} é obrigatorio!")]

        public string? Name { get; set; }
    }
}
