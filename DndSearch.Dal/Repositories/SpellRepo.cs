using DndSearch.Dal.Base;
using DndSearch.Dal.Interfaces;
using DndSearch.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndSearch.Dal.Repositories
{
    public class SpellRepo : RepoBase<Spell>, ISpellRepo
    {
    }
}
