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
using DndSearch.Common.Expressions;

namespace DndSearch.Dal.Repositories
{
    public class SpellRepo : RepoBase<Entity.Spell>, ISpellRepo
    {
        public IEnumerable<Spell> GetAllSpells()
        {
            return base.GetAll(spell => spell.Level, true).ToDomainModel();
        }
        
        public Spell GetSpell(int id)
        {
            return base.Find(id).ToDomainModel(); //Retruns null if nout found
        }

        public IEnumerable<Spell> SearchSpellName(string searchTerm)
        {
            return base.GetSome(spell => spell.Name.Contains(searchTerm), spell => spell.Level, true).ToDomainModel();
        }

        public IEnumerable<Spell> SearchSpells(Expression<Func<Spell, bool>> searchParams)
        {
            if (searchParams == null)
                throw new ArgumentNullException("searchParams");

            var where = ExpressionConverter.ChangeInputType<Spell, Entity.Spell, bool>(searchParams);
            return base.GetSome(where).ToDomainModel();
        }

        public void RemoveSpell(int spellId)
        {
            var entity = base.Find(spellId);
            if (entity == null)
                throw new ResourceNotFoundException();  //Could also return from here. If we can't find the entity then it doesn't exist so is effectively deleted

            base.Delete(entity);
        }

        public int SaveSpell(Spell spell)
        {
            if (spell == null)
                throw new ArgumentNullException("spell");

            var entity = spell.ToEntityModel();
            if (spell.Id.HasValue)
                base.Update(entity, true);
            else
                base.Add(entity, true);
            return entity.Id;
        }
    }

    internal static class SpellMapper
    {
        public static Spell ToDomainModel(this Entity.Spell spell) => Spell.Create(
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

        public static IEnumerable<Spell> ToDomainModel(this IEnumerable<Entity.Spell> spells) => spells.Select(spell => spell.ToDomainModel());

        public static Entity.Spell ToEntityModel(this Spell spell) => new Entity.Spell()
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
        public static IEnumerable<Entity.Spell> ToEntityModel(this IEnumerable<Spell> spells) => spells.Select(spell => spell.ToEntityModel());
    }
}
