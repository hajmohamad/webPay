namespace webPay.Models.PageAttribute;

public class CustomerFormViewModel
{
    public IEnumerable<MemberShipType> MemberShipTypes { get; set; }
    public Customer Customer { get; set; }
}