namespace webPay.Models.PageAttribute;

public class CustomersPageAttribute
{
    //singleton
    public static CustomersPageAttribute CustomersPage { get; set; }
    public  List<Customer> Customers { get; set; }
    
}