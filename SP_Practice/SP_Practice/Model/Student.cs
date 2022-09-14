namespace SP_Practice.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Message { get; set; }

        internal int Count()
        {
            throw new NotImplementedException();
        }
    }
}
