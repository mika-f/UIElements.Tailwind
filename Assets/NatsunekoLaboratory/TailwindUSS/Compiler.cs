// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using NatsunekoLaboratory.TailwindUSS.Plugins;

namespace NatsunekoLaboratory.TailwindUSS
{
    public class Compiler
    {
        private readonly Configuration _configuration;
        private readonly PluginLoader _loader;
        public static Compiler Default => new Compiler(Configuration.Default);

        public Compiler(Configuration configuration)
        {
            _configuration = configuration;
            _loader = new PluginLoader();
        }

        public string Compile()
        {
            var compiler = new TailwindCompiler();

            _loader.Load();
            foreach (var plugin in _loader.Plugins)
                plugin.Run(_configuration, compiler);

            return compiler.Compile();
        }
    }
}