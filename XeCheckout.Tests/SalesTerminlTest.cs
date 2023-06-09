﻿using XeCheckout.Models;

namespace XeCheckout.Tests;

public class SalesTerminlTest
{
    private ISalesTerminal salesTerminal;
    [SetUp]
    public void Setup()
    {
        salesTerminal = new SalesTerminal(new ProductA(), new ProductB(), new ProductC(), new ProductD());
    }

    [Test]

    public void ScanProducts_InOrderABCDABA_ShouldReturn13Point25()
    {
        salesTerminal.ScanProduct("A");
        salesTerminal.SetPricing("A");
        salesTerminal.ScanProduct("B");
        salesTerminal.SetPricing("B");
        salesTerminal.ScanProduct("C");
        salesTerminal.SetPricing("C");
        salesTerminal.ScanProduct("D");
        salesTerminal.SetPricing("D");
        salesTerminal.ScanProduct("A");
        salesTerminal.SetPricing("A");
        salesTerminal.ScanProduct("B");
        salesTerminal.SetPricing("B");
        salesTerminal.ScanProduct("A");
        salesTerminal.SetPricing("A");

        Assert.That(salesTerminal.CalculateTotal(), Is.EqualTo(13.25));
    }

    [Test]

    public void ScanProducts_InOrderCCCCCCC_ShouldReturn6()
    {
        salesTerminal.ScanProduct("C");
        salesTerminal.SetPricing("C");
        salesTerminal.ScanProduct("C");
        salesTerminal.SetPricing("C");
        salesTerminal.ScanProduct("C");
        salesTerminal.SetPricing("C");
        salesTerminal.ScanProduct("C");
        salesTerminal.SetPricing("C");
        salesTerminal.ScanProduct("C");
        salesTerminal.SetPricing("C");
        salesTerminal.ScanProduct("C");
        salesTerminal.SetPricing("C");
        salesTerminal.ScanProduct("C");
        salesTerminal.SetPricing("C");
        Assert.That(salesTerminal.CalculateTotal(), Is.EqualTo(6.00));
    }

    [Test]

    public void ScanProducts_InOrderABCD_ShouldReturn7point25()
    {
        salesTerminal.ScanProduct("A");
        salesTerminal.SetPricing("A");
        salesTerminal.ScanProduct("B");
        salesTerminal.SetPricing("B");
        salesTerminal.ScanProduct("C");
        salesTerminal.SetPricing("C");
        salesTerminal.ScanProduct("D");
        salesTerminal.SetPricing("D");


        Assert.That(salesTerminal.CalculateTotal(), Is.EqualTo(7.25));
    }

    [Test]
    public void ScanProducts_InOrderAAAAAAAAAA_ShouldReturn7point25()
    {
        salesTerminal.ScanProduct("A");
        salesTerminal.SetPricing("A");
        salesTerminal.ScanProduct("A");
        salesTerminal.SetPricing("A");
        salesTerminal.ScanProduct("A");
        salesTerminal.SetPricing("A");
        salesTerminal.ScanProduct("A");
        salesTerminal.SetPricing("A");
        salesTerminal.ScanProduct("A");
        salesTerminal.SetPricing("A");
        salesTerminal.ScanProduct("A");
        salesTerminal.SetPricing("A");
        salesTerminal.ScanProduct("A");
        salesTerminal.SetPricing("A");
        salesTerminal.ScanProduct("A");
        salesTerminal.SetPricing("A");
        salesTerminal.ScanProduct("A");
        salesTerminal.SetPricing("A");
        salesTerminal.ScanProduct("A");
        salesTerminal.SetPricing("A");

        Assert.That(salesTerminal.CalculateTotal(), Is.EqualTo(10.25));
    }
}
