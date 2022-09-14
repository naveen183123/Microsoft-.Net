using Microsoft.AspNetCore.Mvc;
using RestApiPractice.Dtos;
using RestApiPractice.Models;
using RestApiPractice.Repository;
namespace RestApiPractice.Controllers
{
    [ApiController]
    [Route("ii/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemRepository repository;
        public ItemController(IItemRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public IEnumerable<ItemDto> GetItems()
        {
            var ii = repository.GetItems().Select(iii => iii.AsDto());
            return ii;
        }
        [HttpGet("{id}")]
        public ActionResult<ItemDto> GetItems(Guid id)
        {
            var iii = repository.GetItems(id).AsDto();
            if(iii is null)
            {
                return NotFound();
            }
            return iii;
        }
        [HttpPost("{items}")]
        public ActionResult<ItemDto> CreateItem(CreateItemDto itemDto)
        {
            items it = new items()
            {
                id = Guid.NewGuid(),
                Name = itemDto.Name,
                Price = itemDto.Price,
                ManufacDate = DateTimeOffset.UtcNow
            };
            repository.CreateItem(it);
            return CreatedAtAction(nameof(GetItems), new {id=it.id},it.AsDto());
        }
        [HttpPut("{id}")]
        public ActionResult UpdateItem(Guid id,UpdateItemDto itemDto)
        {
            var Eitem = repository.GetItems(id);
            if(Eitem is null)
            {
                return NotFound();
            }
            items updateItem = Eitem with
            {
                Name = itemDto.Name,
                Price = itemDto.Price
            };
            repository.UpdateItem(updateItem);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteItem(Guid id)
        {
            var Eitem = repository.GetItems(id);
            if (Eitem is null)
            {
                return NotFound();
            }
            repository.DeleteItem(id);
            return NoContent();
        }
    }
}
