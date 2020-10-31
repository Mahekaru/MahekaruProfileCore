using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahekaruProfileCore.Models
{
    public class Skills
    {
        public string Name { get; set; }
        public double SkillPoints { get; set; }
        public string ExperianceLevel {
            get {
                string experianceLevel = "Learning...";

                if (SkillPoints > 2)
                {
                    experianceLevel = "Novice";
                }

                if (SkillPoints > 5)
                {
                    experianceLevel = "Intermediate";
                }

                if (SkillPoints >= 9)
                {
                    experianceLevel = "Expert";
                }

                if (SkillPoints > 10)
                {
                    experianceLevel = "Expert ++";
                }

                return experianceLevel; 
            
            }
        }
    }
}
