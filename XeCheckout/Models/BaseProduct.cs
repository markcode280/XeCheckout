using System;
namespace XeCheckout.Models
{
	public abstract class BaseProduct
	{
		public BaseProduct()
		{

		}

    

        protected virtual double getSingleUnitValueAtQuantity(int quantityAtDiscount, int actualQuantity, double singleUnitValue, double priceAtQuantityDiscount)
        {
            if (actualQuantity < quantityAtDiscount)
                return singleUnitValue;

            var discount = (quantityAtDiscount * singleUnitValue) - priceAtQuantityDiscount;

            var totalQuantityDiscount = Math.DivRem(actualQuantity, quantityAtDiscount);

            return ((actualQuantity * singleUnitValue) - (totalQuantityDiscount.Quotient * discount)) / actualQuantity;
        }
    }
}

