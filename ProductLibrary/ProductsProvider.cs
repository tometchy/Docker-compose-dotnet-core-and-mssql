namespace ProductLibrary
{
    public class ProductsProvider
    {
        public Product[] GetAll()
        {
            return new[] {new Product(1, "nazwa", "opis"),};
        }
    }
}
