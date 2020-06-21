using ALL_MVC_ALL.Models.Repository.DatabaseLogicLayer;
using ALL_MVC_ALL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALL_MVC_ALL.Models.Repository.BussinessLogicLayer
{
    public class ProductBLO
    {
        private ProductDLO _ProductDLO;

        public ProductBLO()
        {
            _ProductDLO = new ProductDLO();
        }
        public List<ProductListViewModel> GetAll()
        {
            List<ProductListViewModel> result;
            var queryresult = _ProductDLO.GetAll();
            result = queryresult.Select(x => new ProductListViewModel
            {
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                Price = x.Price,
                Image = x.Image,
                Quantity = x.Quantity,
                SmallClassificationID = x.SmallClassificationID,
                ProductSpecificationID = x.ProductSpecificationID
            }).ToList();

            return result;
        }
    }
}