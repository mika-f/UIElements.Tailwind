// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    public class FlexDirection : ITailwindPlugin
    {
        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            compiler.AddUtilities(new Dictionary<string, Dictionary<string, string>>
            {
                { ".flex-row", new Dictionary<string, string> { { "flex-direction", "row" } } },
                { ".flex-row-reverse", new Dictionary<string, string> { { "flex-direction", "row-reverse" } } },
                { ".flex-col", new Dictionary<string, string> { { "flex-direction", "column" } } },
                { ".flex-col-reverse", new Dictionary<string, string> { { "flex-direction", "column-reverse" } } }
            });
        }
    }
}