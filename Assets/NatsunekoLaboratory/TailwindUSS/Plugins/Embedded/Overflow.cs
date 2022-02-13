// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    public class Overflow : ITailwindPlugin
    {
        private static readonly string[] OverflowValues = { "hidden", "visible" };

        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            foreach (var value in OverflowValues)
                compiler.AddUtility($".overflow-{value}", new Dictionary<string, string> { { "overflow", value } });
        }
    }
}