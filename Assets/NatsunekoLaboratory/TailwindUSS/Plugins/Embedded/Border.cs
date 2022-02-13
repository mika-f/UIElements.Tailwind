// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    internal class Border : ITailwindPlugin
    {
        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            compiler.MatchUtilities((key, value) => new Dictionary<string, Dictionary<string, string>>
            {
                // inset
                { $".rounded-{key}", new Dictionary<string, string> { { "border-width", compiler.ToPixel(value) } } },
                // top
                { $".rounded-t-{key}", new Dictionary<string, string> { { "border-top-width", compiler.ToPixel(value) } } },
                // right
                { $".rounded-r-{key}", new Dictionary<string, string> { { "border-right-width", compiler.ToPixel(value) } } },
                // left
                { $".rounded-l-{key}", new Dictionary<string, string> { { "border-left-width", compiler.ToPixel(value) } } },
                // bottom
                { $".rounded-b-{key}", new Dictionary<string, string> { { "border-bottom-width", compiler.ToPixel(value) } } }
            }, configuration.Theme.Padding);
        }
    }
}