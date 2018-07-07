using DndSearch.EntityFramework.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndSearch.EntityFramework.Models
{
    public class Spell : EntityBase
    {
        public int Level { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
        public bool Concentration { get; set; }
        public bool VerbalComponent { get; set; }
        public bool SomaticComponent { get; set; }
        public bool MaterialComponent { get; set; }
        public int? MaterialComponentCost { get; set; }
        public bool RequiresTouchAttack { get; set; }
        public bool RequiresRangedAttack { get; set; }
        public bool RequiresSave { get; set; }
        public string Save { get; set; }
        public string Range { get; set; }
        public string Area { get; set; }
        public string SpellSchool { get; set; }
        public string CastingTime { get; set; }
        public bool Ritual { get; set; }
        public IEnumerable<string> Classes { get; set; }
        public string Source { get; set; }
    }
}
