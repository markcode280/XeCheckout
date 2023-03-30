using System;
namespace XeCheckout.Interfaces
{
	public interface IProduct
	{
         int Quantity { get; set; }
         string Name { get; set; } 
         double Price { get; set; }

        double getSingleUnitValueAtQuantityForProduct(int quantityAtDiscount, int actualQuantity, double singleUnitValue, double priceAtQuantityDiscount);
    }
}

