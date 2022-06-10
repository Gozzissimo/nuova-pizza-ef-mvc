using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace nuova_pizza_ef_mvc.Models
{
    [Table("Pizza")]
    public class Pizza
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "Nome richiesto")]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImgPath { get; set; }
        [Required(ErrorMessage = "Prezzo richiesto")]
        public string? Price { get; set; }
        [NotMapped]
        public IFormFile? formFile { get; set; }
        public Pizza() { }
    }
}
