using System;
using XeCheckout.Interfaces;

namespace XeCheckout.Models
{
	public class ProductD:BaseProduct, IProduct
	{
		public ProductD()
		{
		}
        public int Quantity { get; set; }
        public string Name { get; set; } = "D";
        public double Price { get; set; } = Constants.Constants.ProductDPrice;

        public double getSingleUnitValueAtQuantityForProduct(int quantityAtDiscount, int actualQuantity, double singleUnitValue, double priceAtQuantityDiscount)
        {
            return Constants.Constants.ProductDPrice;
        }

    }
}

