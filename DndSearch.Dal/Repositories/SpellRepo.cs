using DndSearch.Dal.Base;
using DndSearch.Dal.Interfaces;
using DndSearch.Domain.Models;
using Entity = DndSearch.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DndSearch.Dal.Repositories
{
    public class SpellRepo : RepoBase<Entity.Spell>, ISpellRepo
    {
        
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
