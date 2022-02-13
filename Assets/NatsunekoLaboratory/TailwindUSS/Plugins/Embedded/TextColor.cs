// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    internal class TextColor : ITailwindPlugin
    {
        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            compiler.MatchUtilities((key, value) =>
            {
                var dictionary = new Dictionary<string, Dictionary<string, string>>();
                foreach (var colors in value)
                    dictionary.Add($".text-{key}-{colors.Key}", new Dictionary<string, string> { { "color", colors.Value } });

                return dictionary;
            }, configuration.Theme.Colors);
        }
    }
}