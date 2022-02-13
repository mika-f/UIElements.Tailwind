// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    public class Visibility : ITailwindPlugin
    {
        private static readonly string[] VisibilityValues = { "hidden", "visible" };

        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            foreach (var value in VisibilityValues)
                compiler.AddUtility($".{value}", new Dictionary<string, string> { { "visibility", value } });
        }
    }
}