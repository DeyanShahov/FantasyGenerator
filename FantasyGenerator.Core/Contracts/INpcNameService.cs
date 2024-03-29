﻿using FantasyGenerator.Core.Models.Npc;

namespace FantasyGenerator.Core.Contracts
{
    public interface INpcNameService
    {
        Task<string> AddNewNpcName(NpcNameCreateViewModel model);

        Task<string> GetAllNpcNames();

        Task<(string, string)> FilterNpcName(string namesFromModel);
    }
}
