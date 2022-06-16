using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1.Base
{
    public enum Trait
    {
        PlaceHolder,
    }

    public class TestTraitsAttribute : TestCategoryBaseAttribute
    {
        private readonly Trait[] _traits;

        public TestTraitsAttribute(params Trait[] traits)
        {
            _traits = traits;
        }

        public override IList<string> TestCategories 
            => _traits.Select(trait => 
                Enum.GetName(typeof(Trait), trait))
                .ToList();
    }

}