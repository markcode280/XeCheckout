using System;
namespace XeCheckout.Models
{
	public class ProductC
	{
		public ProductC()
		{
		}
        public int Quantity { get; set; }
        public string Name { get; set; } = "C";
        public double Price { get; set; } = 1.00;
    }
}

