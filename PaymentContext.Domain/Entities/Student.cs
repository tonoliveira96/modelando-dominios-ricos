using System.Collections.Generic;

namespace PaymenContext.Domain.Entities 
{
  public class Student 
  {
    public string FirstName { get; set; }
    public string FLastName { get; set; }
    public string Document { get; set; }
    public string Email { get; set; }
    public string Address {get; set;}
    public List<Subscription> {get; set;}
  }
}