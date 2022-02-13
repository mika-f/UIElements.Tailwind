// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    internal class TextAlign : ITailwindPlugin
    {
        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            compiler.AddUtility(".text-upper-left", new Dictionary<string, string> { { "-unity-text-align", "upper-left" } });
            compiler.AddUtility(".text-left", new Dictionary<string, string> { { "-unity-text-align", "middle-left" } });
            compiler.AddUtility(".text-lower-left", new Dictionary<string, string> { { "-unity-text-align", "lower-left" } });
            compiler.AddUtility(".text-upper-center", new Dictionary<string, string> { { "-unity-text-align", "upper-center" } });
            compiler.AddUtility(".text-center", new Dictionary<string, string> { { "-unity-text-align", "center" } });
            compiler.AddUtility(".text-lower-center", new Dictionary<string, string> { { "-unity-text-align", "lower-center" } });
            compiler.AddUtility(".text-upper-right", new Dictionary<string, string> { { "-unity-text-align", "upper-right" } });
            compiler.AddUtility(".text-right", new Dictionary<string, string> { { "-unity-text-align", "middle-right" } });
            compiler.AddUtility(".text-lower-right", new Dictionary<string, string> { { "-unity-text-align", "lower-right" } });
        }
    }
}