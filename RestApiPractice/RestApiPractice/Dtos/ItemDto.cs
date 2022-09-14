namespace RestApiPractice.Dtos
{
    public record ItemDto
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset ManufacDate { get; set; }

    }
}
