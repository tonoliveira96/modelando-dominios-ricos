using System;

namespace PaymenContext.Domain.Entities 
{
  public class Subscription
  {
    public DateTime CreateDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
    public DateTime? ExpireDate { get; set; }
    public List<Payment> Payments {get; set;}
  }
}