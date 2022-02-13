// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    internal class JustifyContent : ITailwindPlugin
    {
        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            compiler.AddUtilities(new Dictionary<string, Dictionary<string, string>>
            {
                { ".justify-start", new Dictionary<string, string> { { "justify-content", "flex-start" } } },
                { ".justify-end", new Dictionary<string, string> { { "justify-content", "flex-end" } } },
                { ".justify-center", new Dictionary<string, string> { { "justify-content", "center" } } },
                { ".justify-between", new Dictionary<string, string> { { "justify-content", "space-between" } } },
                { ".justify-around", new Dictionary<string, string> { { "justify-content", "space-around" } } }
            });
        }
    }
}