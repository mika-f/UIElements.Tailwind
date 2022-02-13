// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    internal class AlignContent : ITailwindPlugin
    {
        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            compiler.AddUtilities(new Dictionary<string, Dictionary<string, string>>
            {
                { ".content-start", new Dictionary<string, string> { { "align-content", "flex-start" } } },
                { ".content-end", new Dictionary<string, string> { { "align-content", "flex-end" } } },
                { ".content-center", new Dictionary<string, string> { { "align-content", "center" } } },
                { ".content-stretch", new Dictionary<string, string> { { "align-content", "stretch" } } }
            });
        }
    }
}