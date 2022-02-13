// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

namespace NatsunekoLaboratory.TailwindUSS.Plugins
{
    public interface ITailwindPlugin
    {
        void Run(Configuration configuration, ITailwindCompiler compiler);
    }
}