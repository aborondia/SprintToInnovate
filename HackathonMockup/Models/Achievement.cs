using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HackathonMockup.Models
{
  public class Achievement
  {
    public string Content { get; set; }
    public int Reward { get; set; }
    public DateTime CompletionDate { get; set; }
  }
}