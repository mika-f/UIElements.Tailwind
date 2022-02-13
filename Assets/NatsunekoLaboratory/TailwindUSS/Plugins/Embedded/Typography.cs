// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    internal class Typography : ITailwindPlugin
    {
        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            compiler.MatchUtilities((key, value) =>
            {
                var innerDict = new Dictionary<string, string> { { "font-size", compiler.ToPixel(value.Item1) } };
                foreach (var dictKey in value.Item2.Keys)
                    innerDict.Add(dictKey, compiler.ToPixel(value.Item2[dictKey]));

                return new Dictionary<string, Dictionary<string, string>>
                {
                    { $".text-{key}", innerDict }
                };
            }, configuration.Theme.FontSize);

            compiler.AddUtility(".normal", new Dictionary<string, string> { { "-unity-font-style", "normal" } });
            compiler.AddUtility(".italic", new Dictionary<string, string> { { "-unity-font-style", "italic" } });
            compiler.AddUtility(".bold", new Dictionary<string, string> { { "-unity-font-style", "bold" } });
            compiler.AddUtility(".italic-bold", new Dictionary<string, string> { { "-unity-font-style", "italic-and-bold" } });
        }
    }
}