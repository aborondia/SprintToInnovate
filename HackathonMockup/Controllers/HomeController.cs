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
      var classroomRewards = new List<Reward>();
      var forumRewards = new List<Reward>();
      var avatarRewards = new List<Reward>();

      classroomRewards.Add(new Reward
      {
        ButtonText = "Early Weekend!",
        Cost = 300,
        Description = "Leave 15 minutes early this Friday!",
        ImageSource = "",
        IsImage = false
      });

      classroomRewards.Add(new Reward
      {
        ButtonText = "But really I know it...",
        Cost = 400,
        Description = "Choose 1 question on an upcoming quiz to skip & receive full credit for!",
        ImageSource = "",
        IsImage = false
      });

      classroomRewards.Add(new Reward
      {
        ButtonText = "I'm very generous",
        Cost = 5000,
        Description = "The instructor will buy pizza for the entire class!",
        ImageSource = "",
        IsImage = false
      });

      //------------------------------------
      forumRewards.Add(new Reward
      {
        ButtonText = "Beautiful",
        Cost = 1000,
        Description = "",
        ImageSource = "/Content/images/sig1.png",
        IsImage = true
      });

      forumRewards.Add(new Reward
      {
        ButtonText = "Stunning",
        Cost = 1000,
        Description = "",
        ImageSource = "/Content/images/sig2.png",
        IsImage = true
      });

      forumRewards.Add(new Reward
      {
        ButtonText = "Avante Garde...",
        Cost = 1000,
        Description = "",
        ImageSource = "/Content/images/sig3.png",
        IsImage = true
      });

      //-------------------------------------------
      avatarRewards.Add(new Reward
      {
        ButtonText = "Yes Please!",
        Cost = 1000,
        Description = "",
        ImageSource = "/Content/images/acc1.png",
        IsImage = true,
        Style = "width:5rem"
      });

      avatarRewards.Add(new Reward
      {
        ButtonText = "Yes Please!",
        Cost = 1000,
        Description = "",
        ImageSource = "/Content/images/acc2.png",
        IsImage = true,
        Style = "width:5rem"
      });

      avatarRewards.Add(new Reward
      {
        ButtonText = "Yes Please!",
        Cost = 1000,
        Description = "",
        ImageSource = "/Content/images/acc3.png",
        IsImage = true,
        Style = "width:5rem"
      });

      avatarRewards.Add(new Reward
      {
        ButtonText = "Yes Please!",
        Cost = 1000,
        Description = "",
        ImageSource = "/Content/images/acc4.png",
        IsImage = true,
        Style = "width:5rem"
      });

      avatarRewards.Add(new Reward
      {
        ButtonText = "Yes Please!",
        Cost = 1000,
        Description = "",
        ImageSource = "/Content/images/acc5.png",
        IsImage = true,
        Style = "width:5rem"
      });



      ViewBag.ClassroomRewards = classroomRewards;
      ViewBag.Forumrewards = forumRewards;
      ViewBag.AvatarRewards = avatarRewards;

      return View();
    }

    public ActionResult DailyChallenge()
    {
      var challenge = new Challenge
      {
        Complete = false,
        Content = "Help a classmate with a question/problem they have(you don't need to know the answer, just help!)",
        Expires = DateTime.Now.AddDays(2),
        Reward = 200
      };

      return View(challenge);
    }

    public ActionResult GroupSession()
    {
      return View();
    }

    public ActionResult RecentAchievements()
    {
      var achievements = new List<Achievement>();

      achievements.Add(new Achievement
      {
        CompletionDate = DateTime.Now.AddDays(-2),
        Content = "Write a short essay on the SOLID principles in a way the a 5 year old could understand.",
        Reward = 100
      });

      achievements.Add(new Achievement
      {
        CompletionDate = DateTime.Now.AddDays(-2),
        Content = "Place in the top 10 high scores on this weeks assignment.",
        Reward = 200
      });

      achievements.Add(new Achievement
      {
        CompletionDate = DateTime.Now.AddDays(-2),
        Content = "Help a classmate solve a question/problem they have.",
        Reward = 150
      });

      return View(achievements);
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
      roles.Add(new Role
      {
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

    public ActionResult ViewAchievements()
    {
      var achievements = new List<Achievement>();

      achievements.Add(new Achievement
      {
        CompletionDate = DateTime.Now.AddDays(-2),
        Content = "Write a short essay on the SOLID principles in a way the a 5 year old could understand.",
        Reward = 100
      });

      achievements.Add(new Achievement
      {
        CompletionDate = DateTime.Now.AddDays(-2),
        Content = "Place in the top 10 high scores on this weeks assignment.",
        Reward = 200
      });

      achievements.Add(new Achievement
      {
        CompletionDate = DateTime.Now.AddDays(-2),
        Content = "Help a classmate solve a question/problem they have.",
        Reward = 150
      });

      return View(achievements);
    }
  }
}