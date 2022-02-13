// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    internal class Whitespace : ITailwindPlugin
    {
        private static readonly string[] SupportedWhitespaceValues = { "normal", "nowrap" };

        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            foreach (var value in SupportedWhitespaceValues)
                compiler.AddUtility($".whitespace-{value}", new Dictionary<string, string> { { "white-space", value } });
        }
    }
}