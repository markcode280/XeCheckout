using System;
using System.Diagnostics;
using XeCheckout.Interfaces;

namespace XeCheckout.Models
{
	public class ProductC:BaseProduct,IProduct
	{
		public ProductC()
		{
		}
        public int Quantity { get; set; }
        public string Name { get; set; } = "C";
        public double Price { get; set; } = Constants.Constants.ProductCPrice;

        public double getSingleUnitValueAtQuantityForProduct(int quantityAtDiscount, int actualQuantity, double singleUnitValue, double priceAtQuantityDiscount)
        {
            return base.getSingleUnitValueAtQuantity(quantityAtDiscount, actualQuantity, singleUnitValue, priceAtQuantityDiscount);
        }
    }


}

