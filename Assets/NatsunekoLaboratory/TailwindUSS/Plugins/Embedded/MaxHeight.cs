// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    internal class MaxHeight : ITailwindPlugin
    {
        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            compiler.MatchUtilities((key, value) => new Dictionary<string, Dictionary<string, string>> { { $".max-h-{key}", new Dictionary<string, string> { { "max-height", compiler.ToPixel(value) } } } }, configuration.Theme.MaxHeight);
        }
    }
}