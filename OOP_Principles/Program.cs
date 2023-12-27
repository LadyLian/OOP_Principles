namespace OOP_Principles
{
    internal class Program:Money
    {
        static void Main(string[] args)
        {
            
            var product = new Product
            {
                Amount = new Money
                {
                    Uah = 520,
                    Kop = 50
                },
                Name = "Mobile"
            };
            product.ProductInfo();
            


        }
    }
}