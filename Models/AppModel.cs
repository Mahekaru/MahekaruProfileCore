using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahekaruProfileCore.Models
{
    public class AppModel
    {
        public List<App> Apps { get; set; }

        public AppModel()
        {
            Apps = new List<App>();

        }
    }
}
