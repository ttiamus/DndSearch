using DndSearch.Dal.Base;
using DndSearch.Dal.Interfaces;
using DndSearch.Domain.Models;
using Entity = DndSearch.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DndSearch.Common.Exceptions;

namespace DndSearch.Dal.Repositories
{
    public class SpellRepo : RepoBase<Entity.Spell>, ISpellRepo
    {
        

        public IEnumerable<Spell> GetAllSpells()
        {
            throw new NotImplementedException();
        }

        public Spell GetSpell(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Spell> SearchSpellName(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Spell> SearchSpells(Expression<Func<Spell, bool>> searchParams)
        {
            throw new NotImplementedException();
        }

        public void RemoveSpell(int spellId)
        {
            throw new NotImplementedException();
        }

        public int SaveSpell(Spell spell)
        {
            return spell.Id.HasValue ? this.UpdateSpell(spell) : this.CreateSpell(spell);
        }

        internal async Task<int> CreateSpell(Spell newSpell)
        {
            var entity = newSpell.ToEntity();
            return this.Add(entity, true);
        }

        internal async Task<int> UpdateSpell(Spell spell)
        {
            var currentSpell = this.Find(s => s.Id == spell.Id);
            if(currentSpell == null)
                throw new ResourceNotFoundException()
            //Update currentSpell

            return this.Update(currentSpell);
        }

        
    }

    internal static class SpellMapper
    {
        public static Spell ToDomain(this Entity.Spell spell) => Spell.Create(
            id: spell.Id,
            level: spell.Level,
            name: spell.Name,
            duration: spell.Duration,
            concentration: spell.Concentration,
            verbalComponent: spell.VerbalComponent,
            somaticComponent: spell.SomaticComponent,
            materialComponent: spell.MaterialComponent,
            materialComponentCost: spell.MaterialComponentCost,
            requiresTouchAttack: spell.RequiresTouchAttack,
            requiresRangedAttack: spell.RequiresRangedAttack,
            requiresSave: spell.RequiresSave,
            save: spell.Save,
            range: spell.Range,
            area: spell.Area,
            spellSchool: spell.SpellSchool,
            castingTime: spell.CastingTime,
            ritual: spell.Ritual,
            classes: spell.Classes,
            source: spell.Source
        );

        public static IEnumerable<Spell> ToDomain(this IEnumerable<Entity.Spell> spells) => spells.Select(spell => spell.ToDomain());

        public static Entity.Spell ToEntity(this Spell spell) => new Entity.Spell()
        {
            Id = spell.Id ?? default(int),
            Level = spell.Level,
            Name = spell.Name,
            Duration = spell.Duration,
            Concentration = spell.Concentration,
            VerbalComponent = spell.VerbalComponent,
            SomaticComponent = spell.SomaticComponent,
            MaterialComponent = spell.MaterialComponent,
            MaterialComponentCost = spell.MaterialComponentCost,
            RequiresTouchAttack = spell.RequiresTouchAttack,
            RequiresRangedAttack = spell.RequiresRangedAttack,
            RequiresSave = spell.RequiresSave,
            Save = spell.Save,
            Range = spell.Range,
            Area = spell.Area,
            SpellSchool = spell.SpellSchool,
            CastingTime = spell.CastingTime,
            Ritual = spell.Ritual,
            Classes = spell.Classes,
            Source = spell.Source
        };
        public static IEnumerable<Entity.Spell> ToEntity(this IEnumerable<Spell> spells) => spells.Select(spell => spell.ToEntity());
    }
}
