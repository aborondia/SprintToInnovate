using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HackathonMockup.Models
{
  public class Role
  {
    public string Name { get; set; }
    public int Cost { get; set; }
    public string PurchaseText { get; set; }
    public bool Obtained { get; set; }
  }
}