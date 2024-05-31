// -----------------------------------------------------------------------
// <copyright file="NamingRule.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.API.Features
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Respawning;
    using Respawning.NamingRules;

    /// <summary>
    /// Warpper of UnitNamingRule.
    /// </summary>
    public static class NamingRule
    {
        /// <summary>
        /// Gets all naming rules.
        /// </summary>
        public static Dictionary<SpawnableTeamType, UnitNamingRule> AllRules => UnitNamingRule.AllNamingRules;
    }
}
