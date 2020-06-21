using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALL_MVC_ALL.Models.Database
{
    public class ProductList
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public int SmallClassificationID { get; set; }


        public string LargePageImage { get; set; }


        public string DesignDiagramImage { get; set; }


        public string DescriptionTitle { get; set; }


        public string ProductDescription { get; set; }

        public int ProductSpecificationID { get; set; }


        public decimal Price { get; set; }


        public string Colour { get; set; }


        public string Image { get; set; }
    }
}