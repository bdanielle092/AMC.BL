using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }


        //The question mark denotes a nullable type. A nullable type is a vlaue type such an as integer or a decimal that allow definiton of that value or a null
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }

        private string _productName;
      public string ProductName
        {
            get
            {

                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }



        public string Log() =>
          $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";
        public override string ToString() => ProductName;

        //Validates the product data
        public override bool Validate()
        {

            //vaildate the properties of the value
            var isVaild = true;
            //check that the lastName and EmailAddress are not empty or white space
            if (string.IsNullOrWhiteSpace(ProductName)) isVaild = false;
            if (CurrentPrice == null) isVaild = false;
            return isVaild;
        }
    }
}
