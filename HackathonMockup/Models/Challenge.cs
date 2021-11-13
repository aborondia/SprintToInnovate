using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HackathonMockup.Models
{
  public class Challenge
  {
    public string Content { get; set; }
    public bool Complete { get; set; }
    public int Reward { get; set; }
    public DateTime Expires { get; set; }
  }
}