// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    internal class FlexWrap : ITailwindPlugin
    {
        private static readonly string[] WrapSupportedValues = { "wrap", "wrap-reverse" };

        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            foreach (var value in WrapSupportedValues)
                compiler.AddUtility($".flex-{value}", new Dictionary<string, string> { { "flex-wrap", value } });
        }
    }
}