Sale sale = new Sale(15m);
var message = sale.GetInfo();
Console.WriteLine(sale.GetInfo());
Sale sale2 = new SaleWithTax(15m, 2m);
Console.WriteLine(sale2.GetInfo());

class SaleWithTax : Sale
{
    public decimal Tax { get; set; }

    public SaleWithTax(decimal total, decimal tax) : base(total)
    {
        Tax = tax;
    }

    public override string GetInfo()
    {
        return "El total es " + Total + " Impuesto es: " + Tax;
    }

    public string GetInfo(string message)
    {
        return message;
    }

    public string GetInfo(int a)
    {
        return a.ToString();
    }
}

class Sale
{
    public decimal Total { get; set; }
    //private decimal some;

    public Sale(decimal total)
    {
        Total = total;
        //some = 8m;
    }

    public virtual string GetInfo()
    {
        return "El total es " + Total;
    }
}
