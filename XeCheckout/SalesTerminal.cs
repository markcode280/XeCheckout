using System;
using XeCheckout.Models;

namespace XeCheckout
{
	public class SalesTerminal: ISalesTerminal
	{
        private ProductA _productA;
        private ProductB _productB;
        private ProductC _productC;
        private ProductD _productD;

        public SalesTerminal(ProductA productA, ProductB productB, ProductC productC, ProductD productD)
		{
            _productA = productA;
            _productB = productB;
            _productC = productC;
            _productD = productD;
        }

        public double CalculateTotal()
        {
            return (_productA.Quantity * _productA.Price) + (_productB.Quantity * _productB.Price) + (_productC.Quantity * _productC.Price) + (_productD.Quantity * _productD.Price);
        }

        public void ScanProduct(string product)
        {
            switch (product)
            {
                case "A":
                    _productA.Quantity++;
                    break;
                case "B":
                    _productB.Quantity++;
                    break;
                case "C":
                    _productC.Quantity++;
                    break;
                case "D":
                    _productD.Quantity++;
                    break;
            }
        }

        public void SetPricing(string product)
        {
            
            switch (product)
            {
                case "A":
                    _productA.Price = getSingleUnitValueAtQuantity(3, _productA.Quantity, _productA.Price, 3);
                    break;
                case "B":
                    return;   
                case "C":
                    _productA.Price = getSingleUnitValueAtQuantity(6, _productC.Quantity, _productA.Price, 5);
                    break;
                case "D":
                    return;

            }

        }
        private double getSingleUnitValueAtQuantity(int quantityAtDiscount,int actualQuantity, double singleUnitValue, double priceAtQuantityDiscount)
        {
            if (actualQuantity < quantityAtDiscount)
                return singleUnitValue;

            var discount = (quantityAtDiscount * singleUnitValue) - priceAtQuantityDiscount; 
            
            var totalQuantityDiscount= Math.DivRem(actualQuantity, quantityAtDiscount);

            return ((actualQuantity * singleUnitValue) - (totalQuantityDiscount.Quotient * discount)) / actualQuantity;
        }

       
        
    }
}

