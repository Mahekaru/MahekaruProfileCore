using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MahekaruProfileCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MahekaruProfileCore.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            AppModel apps = new AppModel();

            apps = SetupApps();

            return View(apps);
        }

        private AppModel SetupApps()
        {
            AppModel apps = new AppModel();

            apps.Apps.Add(
            CreateApp("Binary Converter",
            "Originally a desktop application. I liked it a lot, so I converted it into a web app.",
            "/img/Apps/BC.png",
            "https://github.com/Mahekaru/Binary-Converter-Web",
            ""));

            apps.Apps.Add(
            CreateApp("Binary Converter API",
            "API to act in place of the Binary Converter is used by Binary Converter 2.0",
            "/img/Apps/BCAPI.png",
            "https://github.com/Mahekaru/BinaryConverterAPI",
            ""));

            apps.Apps.Add(
            CreateApp("Our Time Together",
            "IOS App that shows your total time in a relationship, notifies you on your anniversary, and so much more!",
            "/img/Apps/OTTIconFB.png",
            "",
            "https://apps.apple.com/us/app/our-time-together/id1633279048"));
            
            apps.Apps.Add(
            CreateApp("Dig It To The Ground!",
            "A mining game created for the play.date",
            "/img/Apps/PDDemo1.gif",
            "",
            ""));
  

            return apps;
        }

        private App CreateApp(string Name, string Description, string ImageName, string GithubLink, string Applink)
        {
            App app = new App();

            app.Name = Name;
            app.Description = Description;
            app.ImageName = ImageName;
            app.GithubLink = GithubLink;
            app.AppLink = Applink;

            return app;
        }
    }
}