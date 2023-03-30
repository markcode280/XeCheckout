using System;
using XeCheckout.Interfaces;

namespace XeCheckout.Models
{
	public class ProductA: BaseProduct,IProduct
    {
		public ProductA()
		{

		}
		
		public string Name { get; set; } = "A";
		public double Price { get; set; } = Constants.Constants.ProductAPrice;
        public int Quantity { get; set; }

        public double getSingleUnitValueAtQuantityForProduct(int quantityAtDiscount, int actualQuantity, double singleUnitValue, double priceAtQuantityDiscount)
        {
            return base.getSingleUnitValueAtQuantity(quantityAtDiscount,actualQuantity,singleUnitValue,priceAtQuantityDiscount);
        }
    }
}

