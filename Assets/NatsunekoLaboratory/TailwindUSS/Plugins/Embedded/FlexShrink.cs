// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    internal class FlexShrink : ITailwindPlugin
    {
        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            compiler.AddUtilities(new Dictionary<string, Dictionary<string, string>>
            {
                { ".flex-shrink-0", new Dictionary<string, string> { { "flex-shrink", "0" } } },
                { ".flex-shrink", new Dictionary<string, string> { { "flex-shrink", "1" } } }
            });
        }
    }
}