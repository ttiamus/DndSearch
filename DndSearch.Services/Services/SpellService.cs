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
        private readonly ISpellRepo spellRepo;

        public SpellService(ISpellRepo spellRepo)
        {
            this.spellRepo = spellRepo;
        }

        public int CreateSpell(CreateSpellRequest request)
        {
            //Check for nulls
            var newSpell = Spell.Create(
                id: null,
                level: request.Level.Value,
                name: request.Name,
                duration: request.Duration,
                concentration: request.Concentration.Value,
                verbalComponent: request.VerbalComponent.Value,
                somaticComponent: request.SomaticComponent.Value,
                materialComponent: request.MaterialComponent.Value,
                materialComponentCost: request.MaterialComponentCost,
                requiresTouchAttack: request.RequiresTouchAttack.Value,
                requiresRangedAttack: request.RequiresRangedAttack.Value,
                requiresSave: request.RequiresSave.Value,
                save: request.Save,
                range: request.Range,
                area: request.Area,
                spellSchool: request.SpellSchool,
                castingTime: request.CastingTime,
                ritual: request.Ritual.Value,
                classes: request.Classes,
                source: request.Source);

            return this.spellRepo.CreateSpell(newSpell);
        }

        public Spell GetSpell(int id)
        {
            return this.spellRepo.GetSpell(id);
        }

        public IEnumerable<Spell> GetAllSpells()
        {
            return this.spellRepo.GetAllSpells();
        }

        public void RemoveSpell(int id)
        {
            this.spellRepo.RemoveSpell(id);
        }

        public void UpdateSpell(UpdateSpellRequest request)
        {
            if (!request.Id.HasValue)
                throw new ArgumentNullException("request.Id");

            var spell = this.spellRepo.GetSpell(request.Id.Value);
            //do updates
            this.spellRepo.UpdateSpell(spell);
        }
    }
}
