﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator_Pattern.Abstract
{
    public abstract class CondimentDecorator : Beverage
    {
        public override abstract String Description { get; }
    }

}
