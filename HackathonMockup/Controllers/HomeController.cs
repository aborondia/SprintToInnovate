using HackathonMockup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HackathonMockup.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }

    public PartialViewResult Sidebar()
    {
      return PartialView("_SidebarPartial");
    }

    public ActionResult Leaderboard()
    {
      return View();
    }

    public ActionResult Challenges()
    {
      var challenges = new List<Challenge>();

      challenges.Add(new Challenge
      {
        Complete = true,
        Content = "Write a short essay on the SOLID principles in a way the a 5 year old could understand.",
        Reward = 100,
        Expires = DateTime.Now.AddDays(3)
      });

      challenges.Add(new Challenge
      {
        Complete = false,
        Content = "Write an algorithm that returns the second largest and second smallest number of an array in a single iteration.",
        Reward = 150,
        Expires = DateTime.Now.AddDays(3)
      });

      return View(challenges);
    }

    public ActionResult PurchaseRewards()
    {
      return View();
    }

    public ActionResult DailyChallenge()
    {
      return View();
    }

    public ActionResult GroupSession()
    {
      return View();
    }

    public ActionResult RecentAchievements()
    {
      return View();
    }

    public ActionResult RoleAdvance()
    {
      return View();
    }

    public ActionResult Map()
    {
      return View();
    }

    public ActionResult ChangeDisplay()
    {
      var avatars = new List<AvatarChange>();
      var roles = new List<Role>();

      avatars.Add(new AvatarChange
      {
        ImageSource = "/Content/images/ava1.png"
      });
      avatars.Add(new AvatarChange
      {
        ImageSource = "/Content/images/ava2.png"
      });
      avatars.Add(new AvatarChange
      {
        ImageSource = "/Content/images/ava3.png"
      });
      avatars.Add(new AvatarChange
      {
        ImageSource = "/Content/images/ava4.png"
      });
      avatars.Add(new AvatarChange
      {
        ImageSource = "/Content/images/ava5.png"
      });
      avatars.Add(new AvatarChange
      {
        ImageSource = "/Content/images/ava6.png"
      });

      //--------------------------------------
//      < div class="list-inline">
//  <div class="h2 list-inline-item">Scout - </div>
//  <input type = "submit" class="h4 list-inline-item" value="Change">
//</div>

//<div class="list-inline">
//  <div class="h2 list-inline-item">The Seeker - </div>
//  <input type = "submit" class="text-secondary h4 list-inline-item" value="Current Role">
//</div>
      roles.Add(new Role{ 
      Name = "Scout",
      Cost = 0,
      Obtained = true
      });

      roles.Add(new Role
      {
        Name = "The Seeker",
        Cost = 10000,
        Obtained = true
      });


      ViewBag.Avatars = avatars;
      ViewBag.Roles = roles;

      return View();
    }
  }
}