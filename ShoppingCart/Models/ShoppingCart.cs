namespace ShoppingCartProject.Models
{
    public class ShoppingCart
    {
        private readonly List<Product> _products;

        public ShoppingCart()
        {
            _products = new List<Product>();
        }

        public int ProductCount => _products.Count;

        //TODO Készítse el a ShoppingCart osztályban azokat a metódusokat, amelyekkel sikeresen lefutnak a tesztesetek!

        public void AddProduct(string name, double price)
        {
            _products.Add(new Product(name, price));
        }

        public void RemoveProduct(string name)
        {
            Product? product = _products.Find(x => x.Name == name);
            if (product == null)
            { throw new InvalidOperationException(); }
            else
            { _products.Remove(product); }
        }

        public double GetTotalPrice()
        {
            double total = 0;
            foreach (var product in _products)
            {
                total += product.Price;
            }
            return total;
        }

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                products.AddRange(_products);
            }
            catch
            {
                throw new Exception();
            }

            return products;

        }
    }
}
