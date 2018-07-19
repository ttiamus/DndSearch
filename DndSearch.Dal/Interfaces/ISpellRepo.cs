using DndSearch.Dal.Base;
using System;
using System.Collections.Generic;
using System.Text;
using DndSearch.Domain.Models;
using System.Linq.Expressions;

namespace DndSearch.Dal.Interfaces
{
    //Not implementing IRepo to prevent those methods from being exposed past concrete repo
    public interface ISpellRepo //: IRepo<Entity.Spell> 
    {
        Spell GetSpell(int id);
        IEnumerable<Spell> SearchSpellName(string searchTerm);
        IEnumerable<Spell> GetAllSpells();
        IEnumerable<Spell> SearchSpells(Expression<Func<Spell, bool>> searchParams);
        int SaveSpell(Spell spell);
        void RemoveSpell(int spellId);
    }
}
