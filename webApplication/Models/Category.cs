namespace webApplication.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        // Initialize with empty string to avoid null value and prevent null reference errors
        public string Name { get; set; } = string.Empty;
        // Allow null value for Name
        // public string? Name { get; set; }
        public string Description { get; set; } = string.Empty ;
    }
}
