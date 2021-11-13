using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HackathonMockup.Models
{
  public class Reward
  {
    public string Description { get; set; }
    public bool IsImage { get; set; }
    public string ImageSource { get; set; }
    public int Cost { get; set; }
    public string ButtonText { get; set; }
    public string Style { get; set; } = "";
  }
}