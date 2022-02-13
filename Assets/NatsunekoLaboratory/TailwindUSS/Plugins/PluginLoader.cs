// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins
{
    internal class PluginLoader
    {
        private readonly List<ITailwindPlugin> _plugins;

        public IReadOnlyCollection<ITailwindPlugin> Plugins => _plugins.AsReadOnly();

        public PluginLoader()
        {
            _plugins = new List<ITailwindPlugin>();
        }

        public void Load()
        {
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            foreach (var t in assembly.GetTypes())
                if (typeof(ITailwindPlugin).IsAssignableFrom(t) && t != typeof(ITailwindPlugin))
                    _plugins.Add(Activator.CreateInstance(t) as ITailwindPlugin);
        }
    }
}