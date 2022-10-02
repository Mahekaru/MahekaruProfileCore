using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MahekaruProfileCore.Models;

namespace MahekaruProfileCore.Data
{
    public class MahekaruProfileCoreAPIContext : DbContext
    {
        public MahekaruProfileCoreAPIContext (DbContextOptions<MahekaruProfileCoreAPIContext> options)
            : base(options)
        {
        }
        
        public DbSet<APIProfileModel> Profile { get; set; }

        public DbSet<APISkillsModel> Skills { get; set; }
    }
}
