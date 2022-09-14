using System.ComponentModel.DataAnnotations;

namespace RestApiPractice.Dtos
{
    public class UpdateItemDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
