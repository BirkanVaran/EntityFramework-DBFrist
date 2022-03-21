using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkDBFrist_BLL.ViewModels;
using EntityFrameworkDBFirst_DAL;

namespace EntityFrameworkDBFrist_BLL
{
    public class ProductManager
    {
        NORTHWNDEntities myDBContext = new NORTHWNDEntities();
        public List<ProductViewModel> TumUrunleriGetir()
        {
            List<ProductViewModel> urunler = new List<ProductViewModel>();
            var data = myDBContext.Products.ToList();

            foreach (var item in data)
            {
                ProductViewModel p = new ProductViewModel()
                {
                    CategoryID = item.CategoryID,
                    ProductID = item.ProductID,
                    UnitPrice = item.UnitPrice,
                    UnitsInStock = item.UnitsInStock,
                    Discontinued = item.Discontinued,
                    UnitsOnOrder = item.UnitsOnOrder,
                    ReorderLevel = item.ReorderLevel,
                    SupplierID = item.SupplierID,
                    ProductName = item.ProductName,
                    QuantityPerUnit=item.QuantityPerUnit
                };

                // CategoryName
                // 1. Yol:
                p.CategoryName = item.Category.CategoryName;

                //2. Yol:
                //p.CategoryName=myDBContext.Categories.FirstOrDefault(x=>x.CategoryID=item.CategoryID)?.CategoryName;



                urunler.Add(p);
            }
            return urunler;

        }

    }
}
