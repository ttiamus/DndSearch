using System;
using System.Collections.Generic;

namespace DndSearch.Domain.Models
{
    public class Spell
    {
        public int? Id { get; protected set; }
        public int Level { get; protected set; }
        public string Name { get; protected set; }
        public string Duration { get; protected set; }
        public bool Concentration { get; protected set; }
        public bool VerbalComponent { get; protected set; }
        public bool SomaticComponent { get; protected set; }
        public bool MaterialComponent { get; protected set; }
        public int? MaterialComponentCost { get; protected set; }
        public bool RequiresTouchAttack { get; protected set; }
        public bool RequiresRangedAttack { get; protected set; }
        public bool RequiresSave { get; protected set; }
        public string Save { get; protected set; }
        public string Range { get; protected set; }
        public string Area { get; protected set; }
        public string SpellSchool { get; protected set; }
        public string CastingTime { get; protected set; }
        public bool Ritual { get; protected set; }
        public IEnumerable<string> Classes { get; protected set; }
        public string Source { get; protected set; }

        public static Spell Create(
            int? id,
            int level,
            string name,
            string duration,
            bool concentration,
            bool verbalComponent,
            bool somaticComponent,
            bool materialComponent,
            int? materialComponentCost,
            bool requiresTouchAttack,
            bool requiresRangedAttack,
            bool requiresSave,
            string save,
            string range,
            string area,
            string spellSchool,
            string castingTime,
            bool ritual,
            IEnumerable<string> classes,
            string source) => 

            new Spell()
            {
                Id = id,
                Level = level,
                Name = name,
                Duration = duration,
                Concentration = concentration,
                VerbalComponent = verbalComponent,
                SomaticComponent = somaticComponent,
                MaterialComponent = materialComponent,
                MaterialComponentCost = materialComponentCost,
                RequiresTouchAttack = requiresTouchAttack,
                RequiresRangedAttack = requiresRangedAttack,
                RequiresSave = requiresSave,
                Save = save,
                Range = range,
                Area = area,
                SpellSchool = spellSchool,
                CastingTime = castingTime,
                Ritual = ritual,
                Classes = classes,
                Source = source
        };

        public static DndSearch.EntityFramework.Models.Spell ToEntity()
        {
            throw new NotImplementedException();
        }

        public void UpdateLevel(int level)
        {
            this.Level = level;
        }
    }
}
