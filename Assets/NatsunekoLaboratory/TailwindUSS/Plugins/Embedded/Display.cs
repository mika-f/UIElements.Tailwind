// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    internal class Display : ITailwindPlugin
    {
        private static readonly string[] SupportedBlocks = { "none", "flex" };

        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            foreach (var value in SupportedBlocks)
                compiler.AddUtility($".{value}", new Dictionary<string, string> { { "display", value } });
        }
    }
}