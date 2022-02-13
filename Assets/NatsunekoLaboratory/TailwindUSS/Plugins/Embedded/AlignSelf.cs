// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    internal class AlignSelf : ITailwindPlugin
    {
        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            compiler.AddUtilities(new Dictionary<string, Dictionary<string, string>>
            {
                { ".self-auto", new Dictionary<string, string> { { "align-self", "auto" } } },
                { ".self-start", new Dictionary<string, string> { { "align-self", "flex-start" } } },
                { ".self-end", new Dictionary<string, string> { { "align-self", "flex-end" } } },
                { ".self-center", new Dictionary<string, string> { { "align-self", "center" } } },
                { ".self-stretch", new Dictionary<string, string> { { "align-self", "stretch" } } }
            });
        }
    }
}