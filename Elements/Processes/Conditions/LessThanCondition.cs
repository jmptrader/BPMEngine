﻿using Org.Reddragonit.BpmEngine.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Org.Reddragonit.BpmEngine.Elements.Processes.Conditions
{
    [XMLTag("exts", "lessThanCondition")]
    internal class LessThanCondition : ACompareCondition
    {
        public LessThanCondition(XmlElement elem, XmlPrefixMap map, AElement parent)
            : base(elem, map, parent) { }

        protected override bool _Evaluate(ProcessVariablesContainer variables)
        {
            return _Compare(variables) < 0;
        }
    }
}
