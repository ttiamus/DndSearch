using DndSearch.Dal.Interfaces;
using DndSearch.Domain.Models;
using DndSearch.Domain.Models.ViewModels;
using DndSearch.Domain.ViewModels;
using DndSearch.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndSearch.Services.Services
{
    public class SpellService : ISpellService
    {
        private readonly ISpellRepo

        public int CreateSpell(CreateSpellRequest request)
        {
            throw new NotImplementedException();
        }

        public Spell GetSpell(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Spell> GetSpells()
        {
            throw new NotImplementedException();
        }

        public void RemoveSpell(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateSpell(UpdateSpellRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
