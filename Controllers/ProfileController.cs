using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MahekaruProfileCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MahekaruProfileCore.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            ProfileModel vm = new ProfileModel();
            vm = FillViewModel(vm);
            return View(vm);
        }

        private ProfileModel FillViewModel(ProfileModel vm)
        {
            vm.Name = "Michael Jennings";
            vm.Exp = 173394;
            vm.ExpTotal = 4470000;
            vm.HP = 33041;
            vm.MP = 17650;
            vm.LinkedIn = "https://linkedin.com/in/michaelejennings42";
            vm.Email = "MichaelEJennings@yahoo.com";
            vm.Title = "LEVEL 73 Programmer";
            vm.GitHub = "https://github.com/MichaelEJennings";
            vm.ProfileImage = "/img/profile/ProfileImage.png";

            vm.Skills.Add(AddSkill("React", 1.5));
            vm.Skills.Add(AddSkill("Node.js", 5.3));
            vm.Skills.Add(AddSkill("Angular", 5.8));
            vm.Skills.Add(AddSkill("MEAN Stack", 6));
            vm.Skills.Add(AddSkill("OOP", 8));
            vm.Skills.Add(AddSkill("SQL", 8.4));
            vm.Skills.Add(AddSkill("C#", 9));
            vm.Skills.Add(AddSkill("Javascript", 8));
            vm.Skills.Add(AddSkill("CSS", 7));
            vm.Skills.Add(AddSkill("VB", 7.5));
            vm.Skills.Add(AddSkill("Automation", 8));
            vm.Skills.Add(AddSkill("Application Development", 10));
            vm.Skills.Add(AddSkill("Visual Studio", 10));
            vm.Skills.Add(AddSkill("MVVM", 6));
            vm.Skills.Add(AddSkill("Aurelia", 6));

            return vm;
        }

        private Skills AddSkill(string name, double skillPoints)
        {
            Skills skill = new Skills();
            
            skill.Name = name;
            skill.SkillPoints = skillPoints;
            

            return skill;
        }
    }
}