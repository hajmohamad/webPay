namespace webPay.Models;

public class MemberShipType
{
  public byte Id { get; set; }
  public short SignUpFeed { get; set; }
  public byte DurationInMonths { get; set; }
  public string Name { get; set; }
  public byte DiscountRate { get; set; }
  
}