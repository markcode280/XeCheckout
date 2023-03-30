using System;
namespace XeCheckout
{
	public interface ISalesTerminal
	{
		void SetPricing(string product);
		void ScanProduct(string product);
		double CalculateTotal();
	}
}

