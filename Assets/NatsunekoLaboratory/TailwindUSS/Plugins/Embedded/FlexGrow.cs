using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins.Embedded
{
    internal class FlexGrow : ITailwindPlugin
    {
        public void Run(Configuration configuration, ITailwindCompiler compiler)
        {
            compiler.AddUtilities(new Dictionary<string, Dictionary<string, string>>
            {
                { ".flex-grow-0", new Dictionary<string, string> { { "flex-grow", "0" } } },
                { ".flex-grow", new Dictionary<string, string> { { "flex-grow", "1" } } }
            });
        }
    }
}
