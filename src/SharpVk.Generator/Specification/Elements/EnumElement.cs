using System;
using System.Collections.Generic;
using System.Text;

namespace SharpVk.Generator.Specification.Elements
{
    public class EnumElement
        : SpecElement
    {
        public int Bitwidth;

        public readonly Dictionary<string, EnumField> Fields = new Dictionary<string, EnumField>();
    }
}
