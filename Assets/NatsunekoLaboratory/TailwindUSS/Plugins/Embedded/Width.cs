﻿// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    internal class Width : ITailwindPlugin
    {
        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            compiler.MatchUtilities((key, value) => new Dictionary<string, Dictionary<string, string>> { { $".w-{key}", new Dictionary<string, string> { { "width", compiler.ToPixel(value) } } } }, configuration.Theme.Width);
        }
    }
}