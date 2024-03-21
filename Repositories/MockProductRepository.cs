using Microsoft.AspNetCore.Mvc;
using VoHongHai.Models;

namespace VoHongHai.Repositories
{

    public class MockProductRepository : IProductRepository
    {
        private readonly List<Product> _products;
        public MockProductRepository()
        {
            // Tạo một số dữ liệu mẫu
            _products = new List<Product>
{
                new Product { Id = 1, Name = "Cơm sườn ", Price = 50000, Description
                = "Cơm ", ImageUrl="/images/303_qua_dau.jpg"},
                new Product { Id = 2, Name = "Cơm sườn bì/chả ", Price = 65000, Description
                = "Cơm ",ImageUrl="/images/496_2_1376385268_maysaycs2400.jpg"},
                new Product { Id = 3, Name = "Cơm sườn bì chả ", Price = 70000 , Description
                = "Cơm  ",ImageUrl="/images/496_2_1376385268_maysaycs2400.jpg"},
                 new Product { Id = 1, Name = "Opla  ", Price = 10000, Description
                = "Thêm  ", ImageUrl="/images/303_qua_dau.jpg"},
                new Product { Id = 2, Name = "Canh theo ngày ", Price = 18000, Description
                = "Hôm nay có:Khổ qua,Canh chua,Khoai mỡ,Bồ ngót,Tần ô  ",ImageUrl="/images/496_2_1376385268_maysaycs2400.jpg"},
                new Product { Id = 3, Name = "Trà đá ", Price = 5000 , Description
                = "Nước  ",ImageUrl="/images/496_2_1376385268_maysaycs2400.jpg"},
                // Thêm các sản phẩm khác
};
        }
        public IEnumerable<Product> GetAll()
        {
            return _products;
        }
        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
        public void Add(Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
        }
        public void Update(Product product)
        {
            var index = _products.FindIndex(p => p.Id == product.Id);
            if (index != -1)
            {
                _products[index] = product;
            }
        }
        public void Delete(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }
}

