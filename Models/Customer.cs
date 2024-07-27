using System.ComponentModel.DataAnnotations;

namespace webPay.Models;

public class Customer
{
    public string? Name { get; set; }
    public int? Id { get; set;}
    [Display (Name = "subscribe for newsLetter")]
    public bool IsSubscribed { get; set; }
    public MemberShipType? MemberShipType { get; set; }
    public byte MemberShipTypeId { get; set; }
    [Display (Name = "Date of Birth")]

    public DateTime? DateOfBirth { get; set; }
}