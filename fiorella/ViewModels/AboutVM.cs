using fiorella.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiorella.ViewModels
{
    public class AboutVM
    {
        public WelcomeNest WelcomeNest { get; set; }
        public IEnumerable<Provide> Provides { get; set; }
        public OurPerformance OurPerformances { get; set; }
        public ExpertMeet ExpertMeet { get; set; }
        public IEnumerable<OurTeam> OurTeams { get; set; }
    }
}
