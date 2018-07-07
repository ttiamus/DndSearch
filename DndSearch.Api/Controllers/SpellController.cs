using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DndSearch.Common.Configuration;
using DndSearch.Domain.Models;
using DndSearch.Domain.Models.ViewModels;
using DndSearch.Domain.ViewModels;
using DndSearch.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DndSearch.Api.Controllers
{
    [Route("Spell")]
    [Produces("application/json")]
    public class SpellController : Controller
    {
        private readonly ISpellService spellService;
        ConnectionStrings config;

        public SpellController(ISpellService spellService, IOptions<ConnectionStrings> config)
        {
            this.spellService = spellService;
            this.config = config.Value;
        }

        [HttpGet]
        [Route("Test")]
        public string Test()
        {
            return $"conn: {config.DndSearch}";
        }

        /// <summary>
        /// Return a list of all spells
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Spell> GetSpells()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Return a list of all spells that match criteria in filter
        /// </summary>
        /// <param name="filter">A list of criteria that is used to filter spell list</param>
        /// <returns></returns>
        [HttpPost]
        public IEnumerable<Spell> GetSpells(FilterSpellRequest filter)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a spell by an Id
        /// </summary>
        /// <param name="id">Id of spell to retrieve</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        public Spell GetSpell(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create a new spell from request
        /// </summary>
        /// <param name="request">Attribtues used to create new spell</param>
        /// <returns>Id of created spell</returns>
        [HttpPost]
        [Route("Create")]
        public int CreateSpell(CreateSpellRequest request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a spell based on request attributes
        /// </summary>
        /// <param name="request">Attributes used to update spell. Id is the spell being updated</param>
        [HttpPut]
        [Route("Update")]
        public void UpdateSpell(UpdateSpellRequest request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Remove a spell with Id
        /// </summary>
        /// <param name="id">Id of spell to be removed</param>
        [HttpDelete]
        [Route("Remove")]
        public void RemoveSpell(int id)
        {
            throw new NotImplementedException();
        }
    }
}