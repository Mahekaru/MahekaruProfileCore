using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahekaruProfileCore.Models
{
    public class ProfileModel
    {
        public string Name { get; set; }
        public List<Skills> Skills { get; set; }
        public double Exp { get; set; }
        public double ExpTotal { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Cell { get; set; }
        public string GitHub { get; set; }
        public string LinkedIn { get; set; }
        public string ProfileImage { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

        public ProfileModel()
        {
            Skills = new List<Skills>();
        }
    }
}
