using System;
using CodeSquirrel.RecipeApp.Model;
using CodeSquirrel.System;

namespace CodeSquirrel.RecipeApp.DataProvider
{
    public interface IUnitDTO : IEntity
    {
        int Value { get; set; }
        UnitType Type { get; set; }
    }
}
