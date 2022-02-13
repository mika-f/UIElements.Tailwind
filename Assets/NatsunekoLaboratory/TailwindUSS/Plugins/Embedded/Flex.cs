// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    internal class Flex : ITailwindPlugin
    {
        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            compiler.AddUtilities(new Dictionary<string, Dictionary<string, string>>
            {
                { ".flex-1", new Dictionary<string, string> { { "flex", "1 1 0" } } },
                { ".flex-auto", new Dictionary<string, string> { { "flex", "1 1 auto" } } },
                { ".flex-initial", new Dictionary<string, string> { { "flex", "0 1 auto" } } },
                { ".flex-none", new Dictionary<string, string> { { "flex", "none" } } }
            });
        }
    }
}