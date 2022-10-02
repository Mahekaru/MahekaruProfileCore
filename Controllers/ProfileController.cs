using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using MahekaruProfileCore.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

namespace MahekaruProfileCore.Controllers
{
    public class ProfileController : Controller
    {
        private string _Baseurl = "";
        private readonly IConfiguration _configuration;

        public ProfileController(IConfiguration config)
        {
            _configuration = config;
            _Baseurl = "https://localhost:44368/";
        }

        public IActionResult Index()
        {
            ProfileModel vm = new ProfileModel();
            vm = FillViewModelFromAPI(vm);

            return View(vm);
        }

        private ProfileModel FillViewModelFromAPI(ProfileModel vm)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage profileResponse = client.GetAsync("/api/APIProfile/1").Result;

                if (profileResponse.IsSuccessStatusCode)
                {
                    var EmpResponse = profileResponse.Content.ReadAsStringAsync().Result;
                    vm = JsonConvert.DeserializeObject<ProfileModel>(EmpResponse);
                }

                HttpResponseMessage skillsResponse = client.GetAsync("/api/Skills").Result;
                if (skillsResponse.IsSuccessStatusCode)
                {
                    var EmpResponse = skillsResponse.Content.ReadAsStringAsync().Result;
                    vm.Skills = JsonConvert.DeserializeObject<List<Skills>>(EmpResponse);
                }
            }

            return vm;
        }

        private ProfileModel FillViewModel(ProfileModel vm)
        {
            //vm.Name = "Michael Jennings";
            //vm.Exp = 173394;
            //vm.ExpTotal = 4470000;
            //vm.HP = 33041;
            //vm.MP = 17650;
            //vm.LinkedIn = "https://linkedin.com/in/michaelejennings42";
            //vm.Email = "MichaelEJennings@yahoo.com";
            //vm.Title = "LEVEL 73 Programmer";
            //vm.GitHub = "https://github.com/MichaelEJennings";
            //vm.ProfileImage = "/img/profile/ProfileImage.png";

            vm.Skills.Add(AddSkill("React", 1.5));
            vm.Skills.Add(AddSkill("Node.js", 5.3));
            vm.Skills.Add(AddSkill("Angular", 5.8));
            vm.Skills.Add(AddSkill("MEAN Stack", 6));
            vm.Skills.Add(AddSkill("OOP", 8));
            vm.Skills.Add(AddSkill("SQL", 8.4));
            vm.Skills.Add(AddSkill("C#", 8.6));
            vm.Skills.Add(AddSkill("Javascript", 8));
            vm.Skills.Add(AddSkill("APIs", 8));
            vm.Skills.Add(AddSkill("Flexbox", 7));
            vm.Skills.Add(AddSkill("CSS", 7));
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