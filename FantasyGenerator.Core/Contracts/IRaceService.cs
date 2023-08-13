using FantasyGenerator.Core.Models.Race;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyGenerator.Core.Contracts
{
    public interface IRaceService
    {
         Task<string> CreateNewRace(RaceCreateViewModel model);
    }
}
