﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5_assignment_template.Interfaces
{
    public interface ICastable
    {
        void CastSpell(IEntity target, string spellName);
    }
}
