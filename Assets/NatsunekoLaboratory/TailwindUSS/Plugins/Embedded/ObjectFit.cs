// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    internal class ObjectFit : ITailwindPlugin
    {
        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            compiler.AddUtility(".object-fill", new Dictionary<string, string> { { "-unity-background-scale-mode", "stretch-to-fill" } });
            compiler.AddUtility(".object-crop", new Dictionary<string, string> { { "--unity-background-scale-mode", "scale-and-crop" } });
            compiler.AddUtility(".object-fit", new Dictionary<string, string> { { "--unity-background-scale-mode", "scale-to-fit" } });
        }
    }
}