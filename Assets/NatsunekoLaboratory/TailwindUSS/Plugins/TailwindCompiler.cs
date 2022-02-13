// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NatsunekoLaboratory.TailwindUSS.Plugins
{
    public class TailwindCompiler : ITailwindCompiler
    {
        private static readonly Regex BaseClassRegex = new Regex("^[A-Za-z][A-Za-z0-9]+$", RegexOptions.Compiled);
        private static readonly char[] EscapeChars = { ':', '[', ']', '(', ')', '#', '\'', '.', '/' };

        private readonly Dictionary<string, Dictionary<string, string>> _classes;
        private readonly Dictionary<string, List<string>> _variants;

        internal TailwindCompiler()
        {
            _classes = new Dictionary<string, Dictionary<string, string>>();
            _variants = new Dictionary<string, List<string>>();
        }

        public void AddUtility(string @class, Dictionary<string, string> body)
        {
            if (!@class.StartsWith("."))
                throw new InvalidOperationException("class is must be starts with .");

            _classes.Add(@class, body);
        }

        public void AddUtilities(Dictionary<string, Dictionary<string, string>> classes)
        {
            foreach (var key in classes.Keys)
                AddUtility(key, classes[key]);
        }


        public void AddBase(string @class, Dictionary<string, string> body)
        {
            if (!BaseClassRegex.IsMatch(@class))
                throw new InvalidOperationException("class is must be matched with C# naming convention");

            _classes.Add(@class, body);
        }

        public void AddBases(Dictionary<string, Dictionary<string, string>> classes)
        {
            foreach (var key in classes.Keys)
                AddBase(key, classes[key]);
        }

        public void AddVariants(string name, params string[] statuses)
        {
            _variants.Add(name, statuses.ToList());
        }

        public string ToPixel(string value)
        {
            // TODO: Fetch Root Content
            if (value.EndsWith("rem"))
                return $"{float.Parse(value.Substring(0, value.LastIndexOf("rem", StringComparison.Ordinal))) * 12}px";

            return value;
        }

        public void MatchUtilities<TValue>(Func<string, TValue, Dictionary<string, Dictionary<string, string>>> invoker, Dictionary<string, TValue> obj)
        {
            foreach (var key in obj.Keys)
                AddUtilities(invoker.Invoke(key, obj[key]));
        }

        public string Compile()
        {
            var sb = new StringBuilder();

            foreach (var @class in _classes)
            {
                sb.AppendLine($"{EscapeClassName(@class.Key)} {{");

                foreach (var kvp in @class.Value)
                    sb.AppendLine($"  {kvp.Key}: {kvp.Value};");

                sb.AppendLine("}");
            }

            return sb.ToString();
        }

        private static string EscapeClassName(string @class)
        {
            var sb = new StringBuilder();
            foreach (var (c, i) in @class.Select((w, i) => (w, i)))
                if (EscapeChars.Contains(c) && i != 0)
                    sb.Append("_"); // Unity can't use escaped chars, replace it
                else
                    sb.Append(c);

            return sb.ToString().Replace("-DEFAULT", "");
        }
    }
}