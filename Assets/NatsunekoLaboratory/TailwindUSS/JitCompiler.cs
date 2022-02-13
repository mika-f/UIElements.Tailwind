// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

using UnityEditor;

using UnityEngine.UIElements;

namespace NatsunekoLaboratory.TailwindUSS
{
    public class JitCompiler
    {
        private readonly string _xaml;
        private readonly bool _withDefault;

        private JitCompiler(string xaml, bool withDefault)
        {
            _xaml = xaml;
            _withDefault = withDefault;
        }

        public static JitCompiler FromXaml(string xaml, bool withDefault)
        {
            return new JitCompiler(xaml, withDefault);
        }

        public static JitCompiler FromXaml(VisualTreeAsset asset, bool withDefault)
        {
            var path = AssetDatabase.GetAssetPath(asset);
            using (var sr = new StreamReader(path))
                return new JitCompiler(sr.ReadToEnd(), withDefault);
        }

        public StyleSheet DynamicCompile()
        {
            var path = GetDestinationPath();
            var root = Path.GetDirectoryName(path);
            if (!Directory.Exists(root))
                Directory.CreateDirectory(root ?? throw new InvalidOperationException());

            if (File.Exists(path))
                return AssetDatabase.LoadAssetAtPath<StyleSheet>(path);

            using (var sw = new StreamWriter(path))
                sw.WriteLine(Compiler.Default.Compile());

            AssetDatabase.Refresh();
            return AssetDatabase.LoadAssetAtPath<StyleSheet>(path);
        }

        private string GetDestinationPath()
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                var data = Encoding.UTF8.GetBytes(_xaml);
                var hash = md5.ComputeHash(data);
                var sb = new StringBuilder();
                foreach (var b in hash)
                    sb.Append(b.ToString("x2"));

                return Path.Combine("Assets", "Generated", sb.ToString(), "TailwindUSS-Jit.uss");
            }
        }
    }
}