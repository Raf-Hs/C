
Sale sale = new Sale(15);
var message = sale.GetInfo();

Console.WriteLine(message);

class SaleWIthTax : Sale{

    public decimal Tax {get; set;}

    public SaleWIthTax (decimal total, decimal tax) : base (total)
    {
        Tax = tax;
    }

    public override string GetInfo()
    {
        return "El total es " + Total + "Impuesto es: " +  Tax;
    }

    public string GetInfo(string message)
    {
        return message;
    }

    public string GetInfo( int a)
    {
        return a.ToString();
    }

    // public string GetInfoWithTaxt(){
    //     reutrn "El total es " + Total + "Impuesto es: " + Tax;
    // }

}

class Sale {

    public decimal Total {get; set;}
    private decimal some;


    public Sale (decimal total){
        Total = total;
        _some = 8
    }

    public string GetInfo(){
        return "El total es " + Total;
    }
}