// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    internal class BorderRadius : ITailwindPlugin
    {
        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            compiler.MatchUtilities((key, value) => new Dictionary<string, Dictionary<string, string>>
            {
                // inset
                { $".rounded-{key}", new Dictionary<string, string> { { "border-radius", compiler.ToPixel(value) } } },
                // top-left
                { $".rounded-tl-{key}", new Dictionary<string, string> { { "border-top-left-radius", compiler.ToPixel(value) } } },
                // top-right
                { $".rounded-tr-{key}", new Dictionary<string, string> { { "border-top-right-radius", compiler.ToPixel(value) } } },
                // bottom-left
                { $".rounded-bl-{key}", new Dictionary<string, string> { { "border-bottom-left-radius", compiler.ToPixel(value) } } },
                // bottom-right
                { $".rounded-br-{key}", new Dictionary<string, string> { { "border-bottom-right-radius", compiler.ToPixel(value) } } },
                // t
                {
                    $".rounded-t-{key}", new Dictionary<string, string>
                    {
                        { "border-top-left-radius", compiler.ToPixel(value) },
                        { "border-top-right-radius", compiler.ToPixel(value) }
                    }
                },
                // r
                {
                    $".rounded-r-{key}", new Dictionary<string, string>
                    {
                        { "border-top-right-radius", compiler.ToPixel(value) },
                        { "border-bottom-right-radius", compiler.ToPixel(value) }
                    }
                },
                // b
                {
                    $".rounded-b-{key}", new Dictionary<string, string>
                    {
                        { "border-bottom-left-radius", compiler.ToPixel(value) },
                        { "border-bottom-right-radius", compiler.ToPixel(value) }
                    }
                },
                // l
                {
                    $".rounded-l-{key}", new Dictionary<string, string>
                    {
                        { "border-top-left-radius", compiler.ToPixel(value) },
                        { "border-bottom-left-radius", compiler.ToPixel(value) }
                    }
                }
            }, configuration.Theme.BorderRadius);
        }
    }
}