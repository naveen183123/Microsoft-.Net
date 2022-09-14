using System.ComponentModel.DataAnnotations;
namespace RestApiPractice.Dtos
{
    public record CreateItemDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}