// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    internal class Cursor : ITailwindPlugin
    {
        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            compiler.AddUtility(".cursor-default", new Dictionary<string, string> { { "cursor", "arrow" } });
            compiler.AddUtility(".cursor-text", new Dictionary<string, string> { { "cursor", "text" } });
            compiler.AddUtility(".cursor-resize-vertical", new Dictionary<string, string> { { "cursor", "resize-vertical" } });
            compiler.AddUtility(".cursor-resize-horizontal", new Dictionary<string, string> { { "cursor", "resize-horizontal" } });
            compiler.AddUtility(".cursor-resize-up-right", new Dictionary<string, string> { { "cursor", "resize-up-right" } });
            compiler.AddUtility(".cursor-resize-up-left", new Dictionary<string, string> { { "cursor", "resize-up-left" } });
            compiler.AddUtility(".cursor-pointer", new Dictionary<string, string> { { "cursor", "link" } });
            compiler.AddUtility(".cursor-slide", new Dictionary<string, string> { { "cursor", "slide-arrow" } });
            compiler.AddUtility(".cursor-move", new Dictionary<string, string> { { "cursor", "arrow" } });
            compiler.AddUtility(".cursor-rotate", new Dictionary<string, string> { { "cursor", "rotate-arrow" } });
            compiler.AddUtility(".cursor-scale", new Dictionary<string, string> { { "cursor", "scale-arrow" } });
            compiler.AddUtility(".cursor-plus", new Dictionary<string, string> { { "cursor", "arrow-plus" } });
            compiler.AddUtility(".cursor-minus", new Dictionary<string, string> { { "cursor", "arrow-minus" } });
            compiler.AddUtility(".cursor-pan", new Dictionary<string, string> { { "cursor", "pan" } });
            compiler.AddUtility(".cursor-orbit", new Dictionary<string, string> { { "cursor", "orbit" } });
            compiler.AddUtility(".cursor-zoom", new Dictionary<string, string> { { "cursor", "zoom" } });
            compiler.AddUtility(".cursor-fps", new Dictionary<string, string> { { "cursor", "fps" } });
            compiler.AddUtility(".cursor-resize-up-down", new Dictionary<string, string> { { "cursor", "split-resize-up-down" } });
            compiler.AddUtility(".cursor-resize-left-right", new Dictionary<string, string> { { "cursor", "split-resize-left-right" } });
        }
    }
}