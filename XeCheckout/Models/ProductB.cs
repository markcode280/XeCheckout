using System;
using XeCheckout.Interfaces;

namespace XeCheckout.Models
{
	public class ProductB:BaseProduct, IProduct
    {
	
        public int Quantity { get; set; }
        public string Name { get; set; } = "B";
        public double Price { get; set; } = Constants.Constants.ProductBPrice;

        public double getSingleUnitValueAtQuantityForProduct(int quantityAtDiscount, int actualQuantity, double singleUnitValue, double priceAtQuantityDiscount)
        {
            return Constants.Constants.ProductBPrice;
        }

        
    }

	
}

