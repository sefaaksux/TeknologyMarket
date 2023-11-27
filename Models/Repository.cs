namespace FormApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();


        static Repository(){

            _categories.Add(new Category{CategoryId=1, Name="Telefon"});
            _categories.Add(new Category{CategoryId=2, Name="Bilgisayar"});

            _products.Add(new Product {ProductId = 1, Image="iphone13.jpg", Name = "İphone 13",Price=18000,IsActive = true,CategoryId=1});
            _products.Add(new Product {ProductId = 2, Image="iphone14.jpg", Name = "İphone 14",Price=25000,IsActive = true,CategoryId=1});
            _products.Add(new Product {ProductId = 3, Image="iphone15.jpg", Name = "İphone 15",Price=35000,IsActive = true,CategoryId=1});
            _products.Add(new Product {ProductId = 4, Image="iphone15pro.jpg", Name = "İphone 15 pro",Price=49000,IsActive = true,CategoryId=1});
              
            _products.Add(new Product {ProductId = 5, Image="macAir.jpg", Name = "Mac Air",Price=20000,IsActive = true,CategoryId=2});
            _products.Add(new Product {ProductId = 6, Image="mac14pro.jpg", Name = "mac 14 pro",Price=25000,IsActive = true,CategoryId=2});
        }

        public static List<Product> Products{
            get{
                return _products;
            }
        }

        public static List<Category> Categories{
            get{
                return _categories;
            }
        }

    }
    
}