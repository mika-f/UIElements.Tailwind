// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    internal class AlignItems : ITailwindPlugin
    {
        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            compiler.AddUtilities(new Dictionary<string, Dictionary<string, string>>
            {
                { ".items-start", new Dictionary<string, string> { { "align-items", "flex-start" } } },
                { ".items-end", new Dictionary<string, string> { { "align-items", "flex-end" } } },
                { ".items-center", new Dictionary<string, string> { { "align-items", "center" } } },
                { ".items-stretch", new Dictionary<string, string> { { "align-items", "stretch" } } }
            });
        }
    }
}