using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ProductManagement.Model
{
    public class Product
    {
        public int Count { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }

    public class ImageProduct
    {
        public string IconImage { get; set; }
    }
    public class ItemImage
    {
        public static List<ImageProduct> GetImages()
        {

            var images = new List<ImageProduct>();
            images.Add(new ImageProduct { IconImage = "Assets/son1.jpg" });
            images.Add(new ImageProduct { IconImage = "Assets/nuochoa.jpeg" });
            images.Add(new ImageProduct { IconImage = "Assets/dongho.jpg" });
            return images;
        }
    }

    public class ProductManager
    {
        public static ObservableCollection<Product> GetListProduct()
        {
            var products = new ObservableCollection<Product>();
            return products;
        }
    }
}
