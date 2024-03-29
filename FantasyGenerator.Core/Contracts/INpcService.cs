﻿using FantasyGenerator.Core.Models.Npc;

namespace FantasyGenerator.Core.Contracts
{
    public interface INpcService : INpcNameService, INpcCategoryNameService
    {
        Task<string> CreateNewNpc(NpcCreateViewModel model, string userId);

        Task<IEnumerable<NpcListViewModel>> GetAllNpc();

        Task<IEnumerable<NpcListViewModel>> GetMyNpc(string authorId);

        Task<NpcFullViewModel> NpcDetails(string npcId);

        Task<NpcEditViewModel> GetNpcForEdit(string npcId);

        Task<bool> UpdateNpc(NpcEditViewModel model);

        Task<bool> DeleteNpc(string npcId);

    }
}
