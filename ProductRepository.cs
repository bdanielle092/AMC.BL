using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACM.BL
{
    public class ProductRepository
    {
        //Retrieve one product
        public Product Retrieve(int productId)
        {
            //Create the instance of the Product class
            //pass inthe requested Id
            Product product = new Product(productId);

            //code that  retrieves the defined product

            //Temporary hard-coded values to return 
            //a populated product 
            if(productId == 2)
            {
                product.ProductName = "SunFlowers";
                product.ProductDescription = "Assorted Size Swt of 4 Bright Yellow Mini Sunflowers";
                    product.CurrentPrice = 15.96M;
            }
            return product;
        }

        //Saves the current product
        public bool Save(Product product)
        {
            //code that saves the passed in customer
            return true;
        }
    }
}
