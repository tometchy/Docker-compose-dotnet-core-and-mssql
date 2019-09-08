namespace ProductLibrary
{
    public class Product
    {
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        
        public Product(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}