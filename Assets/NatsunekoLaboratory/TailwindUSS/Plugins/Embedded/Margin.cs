// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    internal class Margin : ITailwindPlugin
    {
        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            compiler.MatchUtilities((key, value) =>
            {
                if (key == "auto")
                    return new Dictionary<string, Dictionary<string, string>> { { ".mx-auto", new Dictionary<string, string> { { "margin-left", "auto" }, { "margin-right", "auto" } } } };

                return new Dictionary<string, Dictionary<string, string>>
                {
                    // positive
                    // inset
                    { $".m-{key}", new Dictionary<string, string> { { "margin", compiler.ToPixel(value) } } },
                    // t
                    { $".mt-{key}", new Dictionary<string, string> { { "margin-top", compiler.ToPixel(value) } } },
                    // r
                    { $".mr-{key}", new Dictionary<string, string> { { "margin-right", compiler.ToPixel(value) } } },
                    // l
                    { $".ml-{key}", new Dictionary<string, string> { { "margin-left", compiler.ToPixel(value) } } },
                    // b
                    { $".mb-{key}", new Dictionary<string, string> { { "margin-bottom", compiler.ToPixel(value) } } },
                    // x
                    {
                        $".mx-{key}", new Dictionary<string, string>
                        {
                            { "margin-left", compiler.ToPixel(value) },
                            { "margin-right", compiler.ToPixel(value) }
                        }
                    },
                    // y
                    {
                        $".my-{key}", new Dictionary<string, string>
                        {
                            { "margin-top", compiler.ToPixel(value) },
                            { "margin-bottom", compiler.ToPixel(value) }
                        }
                    },

                    // negative
                    // inset
                    { $".-m-{key}", new Dictionary<string, string> { { "margin", $"-{compiler.ToPixel(value)}" } } },
                    // t
                    { $".-mt-{key}", new Dictionary<string, string> { { "margin-top", $"-{compiler.ToPixel(value)}" } } },
                    // r
                    { $".-mr-{key}", new Dictionary<string, string> { { "margin-right", $"-{compiler.ToPixel(value)}" } } },
                    // l
                    { $".-ml-{key}", new Dictionary<string, string> { { "margin-left", $"-{compiler.ToPixel(value)}" } } },
                    // b
                    { $".-mb-{key}", new Dictionary<string, string> { { "margin-bottom", $"-{compiler.ToPixel(value)}" } } },
                    // x
                    {
                        $".-mx-{key}", new Dictionary<string, string>
                        {
                            { "margin-left", $"-{compiler.ToPixel(value)}" },
                            { "margin-right", $"-{compiler.ToPixel(value)}" }
                        }
                    },
                    // y
                    {
                        $".-my-{key}", new Dictionary<string, string>
                        {
                            { "margin-top", $"-{compiler.ToPixel(value)}" },
                            { "margin-bottom", $"-{compiler.ToPixel(value)}" }
                        }
                    }
                };
            }, configuration.Theme.Margin);
        }
    }
}