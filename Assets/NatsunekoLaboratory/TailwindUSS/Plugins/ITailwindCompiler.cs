using System;
using System.Collections.Generic;

namespace NatsunekoLaboratory.TailwindUSS.Plugins
{
    public interface ITailwindCompiler
    {
        void AddUtility(string @class, Dictionary<string, string> body);

        void AddUtilities(Dictionary<string, Dictionary<string, string>> classes);

        void MatchUtilities<TValue>(Func<string, TValue, Dictionary<string, Dictionary<string, string>>> invoker, Dictionary<string, TValue> obj);

        void AddBase(string @class, Dictionary<string, string> body);

        void AddBases(Dictionary<string, Dictionary<string, string>> classes);

        void AddVariants(string name, params string[] statuses);

        string ToPixel(string value);
    }
}
