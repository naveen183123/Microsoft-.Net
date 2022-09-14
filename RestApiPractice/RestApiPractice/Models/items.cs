namespace RestApiPractice.Models
{
    public record items
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset ManufacDate { get; set; }

    }
}
