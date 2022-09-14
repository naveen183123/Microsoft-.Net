using RestApiPractice.Dtos;
using RestApiPractice.Models;

namespace RestApiPractice
{
    public static class Extensions
    {
        public static ItemDto AsDto(this items iii)
        {
            return new ItemDto
            {
                id = iii.id,
                Name = iii.Name,
                Price = iii.Price,
                ManufacDate = iii.ManufacDate
            };
        }
    }
}
