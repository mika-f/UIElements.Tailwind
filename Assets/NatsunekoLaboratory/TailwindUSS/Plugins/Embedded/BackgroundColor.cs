// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    internal class BackgroundColor : ITailwindPlugin
    {
        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            compiler.MatchUtilities((key, value) =>
            {
                var dictionary = new Dictionary<string, Dictionary<string, string>>();
                foreach (var colors in value)
                    dictionary.Add($".bg-{key}-{colors.Key}", new Dictionary<string, string> { { "background-color", colors.Value } });

                return dictionary;
            }, configuration.Theme.Colors);
        }
    }
}