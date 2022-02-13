// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    internal class Padding : ITailwindPlugin
    {
        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            compiler.MatchUtilities((key, value) => new Dictionary<string, Dictionary<string, string>>
            {
                // inset
                { $".p-{key}", new Dictionary<string, string> { { "padding", compiler.ToPixel(value) } } },
                // t
                { $".pt-{key}", new Dictionary<string, string> { { "padding-top", compiler.ToPixel(value) } } },
                // r
                { $".pr-{key}", new Dictionary<string, string> { { "padding-right", compiler.ToPixel(value) } } },
                // l
                { $".pl-{key}", new Dictionary<string, string> { { "padding-left", compiler.ToPixel(value) } } },
                // b
                { $".pb-{key}", new Dictionary<string, string> { { "padding-bottom", compiler.ToPixel(value) } } },
                // x
                {
                    $".px-{key}", new Dictionary<string, string>
                    {
                        { "padding-left", compiler.ToPixel(value) },
                        { "padding-right", compiler.ToPixel(value) }
                    }
                },
                // y
                {
                    $".py-{key}", new Dictionary<string, string>
                    {
                        { "padding-top", compiler.ToPixel(value) },
                        { "padding-bottom", compiler.ToPixel(value) }
                    }
                }
            }, configuration.Theme.Padding);
        }
    }
}