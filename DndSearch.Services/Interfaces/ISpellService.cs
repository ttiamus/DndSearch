using DndSearch.Domain.Models;
using DndSearch.Domain.Models.ViewModels;
using DndSearch.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndSearch.Services.Interfaces
{
    public interface ISpellService
    {
        IEnumerable<Spell> GetAllSpells();
        Spell GetSpell(int id);
        int CreateSpell(CreateSpellRequest request);
        void RemoveSpell(int id);
        void UpdateSpell(UpdateSpellRequest request);
    }
}
