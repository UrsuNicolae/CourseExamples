namespace DataAccessLayer.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url1 { get; set; }

        public string Title { get; set; }

        public ICollection<Post> Posts { get; }
    }
}
