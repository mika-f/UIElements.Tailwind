// ------------------------------------------------------------------------------------------
//  Copyright (c) Natsuneko. All rights reserved.
//  Licensed under the MIT License. See LICENSE in the project root for license information.
// ------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using UnityEngine;

namespace NatsunekoLaboratory.TailwindUSS
{
    [Serializable]
    public class Configuration : ScriptableObject
    {
        [SerializeField]
        private Theme _theme;

        public static Configuration Default => new Configuration();

        public Theme Theme
        {
            get => _theme;
            set => _theme = value;
        }

        private Configuration()
        {
            Theme = new Theme
            {
                Colors = new Dictionary<string, Dictionary<string, string>>
                {
                    { "transparent", new Dictionary<string, string> { { "DEFAULT", "transparent" } } },
                    { "black", new Dictionary<string, string> { { "DEFAULT", "#000" } } },
                    { "white", new Dictionary<string, string> { { "DEFAULT", "#fff" } } },
                    {
                        "slate", new Dictionary<string, string>
                        {
                            { "50", "#f8fafc" },
                            { "100", "#f1f5f9" },
                            { "200", "#e2e8f0" },
                            { "300", "#cbd5e1" },
                            { "400", "#94a3b8" },
                            { "500", "#64748b" },
                            { "600", "#475569" },
                            { "700", "#334155" },
                            { "800", "#1e293b" },
                            { "900", "#0f172a" }
                        }
                    },
                    {
                        "gray", new Dictionary<string, string>
                        {
                            { "50", "#f9fafb" },
                            { "100", "#f3f4f6" },
                            { "200", "#e5e7eb" },
                            { "300", "#d1d5db" },
                            { "400", "#9ca3af" },
                            { "500", "#6b7280" },
                            { "600", "#4b5563" },
                            { "700", "#374151" },
                            { "800", "#1f2937" },
                            { "900", "#111827" }
                        }
                    },
                    {
                        "zinc", new Dictionary<string, string>
                        {
                            { "50", "#fafafa" },
                            { "100", "#f4f4f5" },
                            { "200", "#e4e4e7" },
                            { "300", "#d4d4d8" },
                            { "400", "#a1a1aa" },
                            { "500", "#71717a" },
                            { "600", "#52525b" },
                            { "700", "#3f3f46" },
                            { "800", "#27272a" },
                            { "900", "#18181b" }
                        }
                    },
                    {
                        "neutral", new Dictionary<string, string>
                        {
                            { "50", "#fafafa" },
                            { "100", "#f5f5f5" },
                            { "200", "#e5e5e5" },
                            { "300", "#d4d4d4" },
                            { "400", "#a3a3a3" },
                            { "500", "#737373" },
                            { "600", "#525252" },
                            { "700", "#404040" },
                            { "800", "#262626" },
                            { "900", "#171717" }
                        }
                    },
                    {
                        "stone", new Dictionary<string, string>
                        {
                            { "50", "#fafaf9" },
                            { "100", "#f5f5f4" },
                            { "200", "#e7e5e4" },
                            { "300", "#d6d3d1" },
                            { "400", "#a8a29e" },
                            { "500", "#78716c" },
                            { "600", "#57534e" },
                            { "700", "#44403c" },
                            { "800", "#292524" },
                            { "900", "#1c1917" }
                        }
                    },
                    {
                        "red", new Dictionary<string, string>
                        {
                            { "50", "#fef2f2" },
                            { "100", "#fee2e2" },
                            { "200", "#fecaca" },
                            { "300", "#fca5a5" },
                            { "400", "#f87171" },
                            { "500", "#ef4444" },
                            { "600", "#dc2626" },
                            { "700", "#b91c1c" },
                            { "800", "#991b1b" },
                            { "900", "#7f1d1d" }
                        }
                    },
                    {
                        "orange", new Dictionary<string, string>
                        {
                            { "50", "#fff7ed" },
                            { "100", "#ffedd5" },
                            { "200", "#fed7aa" },
                            { "300", "#fdba74" },
                            { "400", "#fb923c" },
                            { "500", "#f97316" },
                            { "600", "#ea580c" },
                            { "700", "#c2410c" },
                            { "800", "#9a3412" },
                            { "900", "#7c2d12" }
                        }
                    },
                    {
                        "amber", new Dictionary<string, string>
                        {
                            { "50", "#fffbeb" },
                            { "100", "#fef3c7" },
                            { "200", "#fde68a" },
                            { "300", "#fcd34d" },
                            { "400", "#fbbf24" },
                            { "500", "#f59e0b" },
                            { "600", "#d97706" },
                            { "700", "#b45309" },
                            { "800", "#92400e" },
                            { "900", "#78350f" }
                        }
                    },
                    {
                        "yellow", new Dictionary<string, string>
                        {
                            { "50", "#fefce8" },
                            { "100", "#fef9c3" },
                            { "200", "#fef08a" },
                            { "300", "#fde047" },
                            { "400", "#facc15" },
                            { "500", "#eab308" },
                            { "600", "#ca8a04" },
                            { "700", "#a16207" },
                            { "800", "#854d0e" },
                            { "900", "#713f12" }
                        }
                    },
                    {
                        "lime", new Dictionary<string, string>
                        {
                            { "50", "#f7fee7" },
                            { "100", "#ecfccb" },
                            { "200", "#d9f99d" },
                            { "300", "#bef264" },
                            { "400", "#a3e635" },
                            { "500", "#84cc16" },
                            { "600", "#65a30d" },
                            { "700", "#4d7c0f" },
                            { "800", "#3f6212" },
                            { "900", "#365314" }
                        }
                    },
                    {
                        "green", new Dictionary<string, string>
                        {
                            { "50", "#f0fdf4" },
                            { "100", "#dcfce7" },
                            { "200", "#bbf7d0" },
                            { "300", "#86efac" },
                            { "400", "#4ade80" },
                            { "500", "#22c55e" },
                            { "600", "#16a34a" },
                            { "700", "#15803d" },
                            { "800", "#166534" },
                            { "900", "#14532d" }
                        }
                    },
                    {
                        "emerald", new Dictionary<string, string>
                        {
                            { "50", "#ecfdf5" },
                            { "100", "#d1fae5" },
                            { "200", "#a7f3d0" },
                            { "300", "#6ee7b7" },
                            { "400", "#34d399" },
                            { "500", "#10b981" },
                            { "600", "#059669" },
                            { "700", "#047857" },
                            { "800", "#065f46" },
                            { "900", "#064e3b" }
                        }
                    },
                    {
                        "teal", new Dictionary<string, string>
                        {
                            { "50", "#f0fdfa" },
                            { "100", "#ccfbf1" },
                            { "200", "#99f6e4" },
                            { "300", "#5eead4" },
                            { "400", "#2dd4bf" },
                            { "500", "#14b8a6" },
                            { "600", "#0d9488" },
                            { "700", "#0f766e" },
                            { "800", "#115e59" },
                            { "900", "#134e4a" }
                        }
                    },
                    {
                        "cyan", new Dictionary<string, string>
                        {
                            { "50", "#ecfeff" },
                            { "100", "#cffafe" },
                            { "200", "#a5f3fc" },
                            { "300", "#67e8f9" },
                            { "400", "#22d3ee" },
                            { "500", "#06b6d4" },
                            { "600", "#0891b2" },
                            { "700", "#0e7490" },
                            { "800", "#155e75" },
                            { "900", "#164e63" }
                        }
                    },
                    {
                        "sky", new Dictionary<string, string>
                        {
                            { "50", "#f0f9ff" },
                            { "100", "#e0f2fe" },
                            { "200", "#bae6fd" },
                            { "300", "#7dd3fc" },
                            { "400", "#38bdf8" },
                            { "500", "#0ea5e9" },
                            { "600", "#0284c7" },
                            { "700", "#0369a1" },
                            { "800", "#075985" },
                            { "900", "#0c4a6e" }
                        }
                    },
                    {
                        "blue", new Dictionary<string, string>
                        {
                            { "50", "#eff6ff" },
                            { "100", "#dbeafe" },
                            { "200", "#bfdbfe" },
                            { "300", "#93c5fd" },
                            { "400", "#60a5fa" },
                            { "500", "#3b82f6" },
                            { "600", "#2563eb" },
                            { "700", "#1d4ed8" },
                            { "800", "#1e40af" },
                            { "900", "#1e3a8a" }
                        }
                    },
                    {
                        "indigo", new Dictionary<string, string>
                        {
                            { "50", "#eef2ff" },
                            { "100", "#e0e7ff" },
                            { "200", "#c7d2fe" },
                            { "300", "#a5b4fc" },
                            { "400", "#818cf8" },
                            { "500", "#6366f1" },
                            { "600", "#4f46e5" },
                            { "700", "#4338ca" },
                            { "800", "#3730a3" },
                            { "900", "#312e81" }
                        }
                    },
                    {
                        "violet", new Dictionary<string, string>
                        {
                            { "50", "#f5f3ff" },
                            { "100", "#ede9fe" },
                            { "200", "#ddd6fe" },
                            { "300", "#c4b5fd" },
                            { "400", "#a78bfa" },
                            { "500", "#8b5cf6" },
                            { "600", "#7c3aed" },
                            { "700", "#6d28d9" },
                            { "800", "#5b21b6" },
                            { "900", "#4c1d95" }
                        }
                    },
                    {
                        "purple", new Dictionary<string, string>
                        {
                            { "50", "#faf5ff" },
                            { "100", "#f3e8ff" },
                            { "200", "#e9d5ff" },
                            { "300", "#d8b4fe" },
                            { "400", "#c084fc" },
                            { "500", "#a855f7" },
                            { "600", "#9333ea" },
                            { "700", "#7e22ce" },
                            { "800", "#6b21a8" },
                            { "900", "#581c87" }
                        }
                    },
                    {
                        "fuchsia", new Dictionary<string, string>
                        {
                            { "50", "#fdf4ff" },
                            { "100", "#fae8ff" },
                            { "200", "#f5d0fe" },
                            { "300", "#f0abfc" },
                            { "400", "#e879f9" },
                            { "500", "#d946ef" },
                            { "600", "#c026d3" },
                            { "700", "#a21caf" },
                            { "800", "#86198f" },
                            { "900", "#701a75" }
                        }
                    },
                    {
                        "pink", new Dictionary<string, string>
                        {
                            { "50", "#fdf2f8" },
                            { "100", "#fce7f3" },
                            { "200", "#fbcfe8" },
                            { "300", "#f9a8d4" },
                            { "400", "#f472b6" },
                            { "500", "#ec4899" },
                            { "600", "#db2777" },
                            { "700", "#be185d" },
                            { "800", "#9d174d" },
                            { "900", "#831843" }
                        }
                    },
                    {
                        "rose", new Dictionary<string, string>
                        {
                            { "50", "#fff1f2" },
                            { "100", "#ffe4e6" },
                            { "200", "#fecdd3" },
                            { "300", "#fda4af" },
                            { "400", "#fb7185" },
                            { "500", "#f43f5e" },
                            { "600", "#e11d48" },
                            { "700", "#be123c" },
                            { "800", "#9f1239" },
                            { "900", "#881337" }
                        }
                    }
                },
                Spacing = new Dictionary<string, string>
                {
                    { "px", "1px" },
                    { "0", "0px" },
                    { "0.5", "0.125rem" },
                    { "1", "0.25rem" },
                    { "1.5", "0.375rem" },
                    { "2", "0.5rem" },
                    { "2.5", "0.625rem" },
                    { "3", "0.75rem" },
                    { "3.5", "0.875rem" },
                    { "4", "1rem" },
                    { "5", "1.25rem" },
                    { "6", "1.5rem" },
                    { "7", "1.75rem" },
                    { "8", "2rem" },
                    { "9", "2.25rem" },
                    { "10", "2.5rem" },
                    { "11", "2.75rem" },
                    { "12", "3rem" },
                    { "14", "3.5rem" },
                    { "16", "4rem" },
                    { "20", "5rem" },
                    { "24", "6rem" },
                    { "28", "7rem" },
                    { "32", "8rem" },
                    { "36", "9rem" },
                    { "40", "10rem" },
                    { "44", "11rem" },
                    { "48", "12rem" },
                    { "52", "13rem" },
                    { "56", "14rem" },
                    { "60", "15rem" },
                    { "64", "16rem" },
                    { "72", "18rem" },
                    { "80", "20rem" },
                    { "96", "24rem" }
                },
                BorderRadius = new Dictionary<string, string>
                {
                    { "none", "0px" },
                    { "sm", "0.125rem" },
                    { "DEFAULT", "0.25rem" },
                    { "md", "0.375rem" },
                    { "lg", "0.5rem" },
                    { "xl", "0.75rem" },
                    { "'2xl'", "1rem" },
                    { "'3xl'", "1.5rem" },
                    { "full", "9999px" }
                },
                BorderWidth = new Dictionary<string, string>
                {
                    { "DEFAULT", "1px" },
                    { "0", "0px" },
                    { "2", "2px" },
                    { "4", "4px" },
                    { "8", "8px" }
                },
                FlexBasis = new Dictionary<string, string>
                {
                    { "auto", "auto" },
                    { "px", "1px" },
                    { "0", "0px" },
                    { "0.5", "0.125rem" },
                    { "1", "0.25rem" },
                    { "1.5", "0.375rem" },
                    { "2", "0.5rem" },
                    { "2.5", "0.625rem" },
                    { "3", "0.75rem" },
                    { "3.5", "0.875rem" },
                    { "4", "1rem" },
                    { "5", "1.25rem" },
                    { "6", "1.5rem" },
                    { "7", "1.75rem" },
                    { "8", "2rem" },
                    { "9", "2.25rem" },
                    { "10", "2.5rem" },
                    { "11", "2.75rem" },
                    { "12", "3rem" },
                    { "14", "3.5rem" },
                    { "16", "4rem" },
                    { "20", "5rem" },
                    { "24", "6rem" },
                    { "28", "7rem" },
                    { "32", "8rem" },
                    { "36", "9rem" },
                    { "40", "10rem" },
                    { "44", "11rem" },
                    { "48", "12rem" },
                    { "52", "13rem" },
                    { "56", "14rem" },
                    { "60", "15rem" },
                    { "64", "16rem" },
                    { "72", "18rem" },
                    { "80", "20rem" },
                    { "96", "24rem" },
                    { "1/2", "50%" },
                    { "1/3", "33.333333%" },
                    { "2/3", "66.666667%" },
                    { "1/4", "25%" },
                    { "2/4", "50%" },
                    { "3/4", "75%" },
                    { "1/5", "20%" },
                    { "2/5", "40%" },
                    { "3/5", "60%" },
                    { "4/5", "80%" },
                    { "1/6", "16.666667%" },
                    { "2/6", "33.333333%" },
                    { "3/6", "50%" },
                    { "4/6", "66.666667%" },
                    { "5/6", "83.333333%" },
                    { "1/12", "8.333333%" },
                    { "2/12", "16.666667%" },
                    { "3/12", "25%" },
                    { "4/12", "33.333333%" },
                    { "5/12", "41.666667%" },
                    { "6/12", "50%" },
                    { "7/12", "58.333333%" },
                    { "8/12", "66.666667%" },
                    { "9/12", "75%" },
                    { "10/12", "83.333333%" },
                    { "11/12", "91.666667%" },
                    { "full", "100%" }
                },
                FlexGrow = new Dictionary<string, string>
                {
                    { "0", "0" },
                    { "DEFAULT", "1" }
                },
                FlexShrink = new Dictionary<string, string>
                {
                    { "0", "0" },
                    { "DEFAULT", "1" }
                },
                FontSize = new Dictionary<string, (string, Dictionary<string, string>)>
                {
                    { "xs", ("0.75rem", new Dictionary<string, string> { { "line-height", "1rem" } }) },
                    { "sm", ("0.85rem", new Dictionary<string, string> { { "line-height", "1.25rem" } }) },
                    { "base", ("1rem", new Dictionary<string, string> { { "line-height", "1.5rem" } }) },
                    { "lg", ("1.125rem", new Dictionary<string, string> { { "line-height", "1.75rem" } }) },
                    { "xl", ("1.25rem", new Dictionary<string, string> { { "line-height", "1.75rem" } }) },
                    { "2xl", ("1.5rem", new Dictionary<string, string> { { "line-height", "2rem" } }) },
                    { "3xl", ("1.875rem", new Dictionary<string, string> { { "line-height", "2.25rem" } }) },
                    { "4xl", ("2.25rem", new Dictionary<string, string> { { "line-height", "2.5rem" } }) },
                    { "5xl", ("3rem", new Dictionary<string, string> { { "line-height", "1" } }) },
                    { "6xl", ("3.75rem", new Dictionary<string, string> { { "line-height", "1" } }) },
                    { "7xl", ("4.5rem", new Dictionary<string, string> { { "line-height", "1" } }) },
                    { "8xl", ("6rem", new Dictionary<string, string> { { "line-height", "1" } }) },
                    { "9xl", ("8rem", new Dictionary<string, string> { { "line-height", "1" } }) }
                },
                Height = new Dictionary<string, string>
                {
                    { "auto", "auto" },
                    { "px", "1px" },
                    { "0", "0px" },
                    { "0.5", "0.125rem" },
                    { "1", "0.25rem" },
                    { "1.5", "0.375rem" },
                    { "2", "0.5rem" },
                    { "2.5", "0.625rem" },
                    { "3", "0.75rem" },
                    { "3.5", "0.875rem" },
                    { "4", "1rem" },
                    { "5", "1.25rem" },
                    { "6", "1.5rem" },
                    { "7", "1.75rem" },
                    { "8", "2rem" },
                    { "9", "2.25rem" },
                    { "10", "2.5rem" },
                    { "11", "2.75rem" },
                    { "12", "3rem" },
                    { "14", "3.5rem" },
                    { "16", "4rem" },
                    { "20", "5rem" },
                    { "24", "6rem" },
                    { "28", "7rem" },
                    { "32", "8rem" },
                    { "36", "9rem" },
                    { "40", "10rem" },
                    { "44", "11rem" },
                    { "48", "12rem" },
                    { "52", "13rem" },
                    { "56", "14rem" },
                    { "60", "15rem" },
                    { "64", "16rem" },
                    { "72", "18rem" },
                    { "80", "20rem" },
                    { "96", "24rem" },
                    { "1/2", "50%" },
                    { "1/3", "33.333333%" },
                    { "2/3", "66.666667%" },
                    { "1/4", "25%" },
                    { "2/4", "50%" },
                    { "3/4", "75%" },
                    { "1/5", "20%" },
                    { "2/5", "40%" },
                    { "3/5", "60%" },
                    { "4/5", "80%" },
                    { "1/6", "16.666667%" },
                    { "2/6", "33.333333%" },
                    { "3/6", "50%" },
                    { "4/6", "66.666667%" },
                    { "5/6", "83.333333%" },
                    { "full", "100%" }
                },
                Inset = new Dictionary<string, string>
                {
                    { "auto", "auto" },
                    { "px", "1px" },
                    { "0", "0px" },
                    { "0.5", "0.125rem" },
                    { "1", "0.25rem" },
                    { "1.5", "0.375rem" },
                    { "2", "0.5rem" },
                    { "2.5", "0.625rem" },
                    { "3", "0.75rem" },
                    { "3.5", "0.875rem" },
                    { "4", "1rem" },
                    { "5", "1.25rem" },
                    { "6", "1.5rem" },
                    { "7", "1.75rem" },
                    { "8", "2rem" },
                    { "9", "2.25rem" },
                    { "10", "2.5rem" },
                    { "11", "2.75rem" },
                    { "12", "3rem" },
                    { "14", "3.5rem" },
                    { "16", "4rem" },
                    { "20", "5rem" },
                    { "24", "6rem" },
                    { "28", "7rem" },
                    { "32", "8rem" },
                    { "36", "9rem" },
                    { "40", "10rem" },
                    { "44", "11rem" },
                    { "48", "12rem" },
                    { "52", "13rem" },
                    { "56", "14rem" },
                    { "60", "15rem" },
                    { "64", "16rem" },
                    { "72", "18rem" },
                    { "80", "20rem" },
                    { "96", "24rem" },
                    { "1/2", "50%" },
                    { "1/3", "33.333333%" },
                    { "2/3", "66.666667%" },
                    { "1/4", "25%" },
                    { "2/4", "50%" },
                    { "3/4", "75%" },
                    { "full", "100%" }
                },
                LineHeight = new Dictionary<string, string>
                {
                    { "none", "1" },
                    { "tight", "1.25" },
                    { "snug", "1.375" },
                    { "normal", "1.5" },
                    { "relaxed", "1.625" },
                    { "loose", "2" },
                    { "3", ".75rem" },
                    { "4", "1rem" },
                    { "5", "1.25rem" },
                    { "6", "1.5rem" },
                    { "7", "1.75rem" },
                    { "8", "2rem" },
                    { "9", "2.25rem" },
                    { "10", "2.5rem" }
                },
                Margin = new Dictionary<string, string>
                {
                    { "auto", "auto" },
                    { "px", "1px" },
                    { "0", "0px" },
                    { "0.5", "0.125rem" },
                    { "1", "0.25rem" },
                    { "1.5", "0.375rem" },
                    { "2", "0.5rem" },
                    { "2.5", "0.625rem" },
                    { "3", "0.75rem" },
                    { "3.5", "0.875rem" },
                    { "4", "1rem" },
                    { "5", "1.25rem" },
                    { "6", "1.5rem" },
                    { "7", "1.75rem" },
                    { "8", "2rem" },
                    { "9", "2.25rem" },
                    { "10", "2.5rem" },
                    { "11", "2.75rem" },
                    { "12", "3rem" },
                    { "14", "3.5rem" },
                    { "16", "4rem" },
                    { "20", "5rem" },
                    { "24", "6rem" },
                    { "28", "7rem" },
                    { "32", "8rem" },
                    { "36", "9rem" },
                    { "40", "10rem" },
                    { "44", "11rem" },
                    { "48", "12rem" },
                    { "52", "13rem" },
                    { "56", "14rem" },
                    { "60", "15rem" },
                    { "64", "16rem" },
                    { "72", "18rem" },
                    { "80", "20rem" },
                    { "96", "24rem" }
                },
                MaxHeight = new Dictionary<string, string>
                {
                    { "px", "1px" },
                    { "0", "0px" },
                    { "0.5", "0.125rem" },
                    { "1", "0.25rem" },
                    { "1.5", "0.375rem" },
                    { "2", "0.5rem" },
                    { "2.5", "0.625rem" },
                    { "3", "0.75rem" },
                    { "3.5", "0.875rem" },
                    { "4", "1rem" },
                    { "5", "1.25rem" },
                    { "6", "1.5rem" },
                    { "7", "1.75rem" },
                    { "8", "2rem" },
                    { "9", "2.25rem" },
                    { "10", "2.5rem" },
                    { "11", "2.75rem" },
                    { "12", "3rem" },
                    { "14", "3.5rem" },
                    { "16", "4rem" },
                    { "20", "5rem" },
                    { "24", "6rem" },
                    { "28", "7rem" },
                    { "32", "8rem" },
                    { "36", "9rem" },
                    { "40", "10rem" },
                    { "44", "11rem" },
                    { "48", "12rem" },
                    { "52", "13rem" },
                    { "56", "14rem" },
                    { "60", "15rem" },
                    { "64", "16rem" },
                    { "72", "18rem" },
                    { "80", "20rem" },
                    { "96", "24rem" },
                    { "full", "100%" }
                },
                MaxWidth = new Dictionary<string, string>
                {
                    { "none", "none" },
                    { "0", "0rem" },
                    { "xs", "20rem" },
                    { "sm", "24rem" },
                    { "md", "28rem" },
                    { "lg", "32rem" },
                    { "xl", "36rem" },
                    { "2xl", "42rem" },
                    { "3xl", "48rem" },
                    { "4xl", "56rem" },
                    { "5xl", "64rem" },
                    { "6xl", "72rem" },
                    { "7xl", "80rem" },
                    { "full", "100%" }
                },
                MinHeight = new Dictionary<string, string>
                {
                    { "0", "0px" },
                    { "full", "100%" }
                },
                MinWidth = new Dictionary<string, string>
                {
                    { "0", "0px" },
                    { "full", "100%" }
                },
                Opacity = new Dictionary<string, string>
                {
                    { "0", "0" },
                    { "5", "0.05" },
                    { "10", "0.1" },
                    { "20", "0.2" },
                    { "25", "0.25" },
                    { "30", "0.3" },
                    { "40", "0.4" },
                    { "50", "0.5" },
                    { "60", "0.6" },
                    { "70", "0.7" },
                    { "75", "0.75" },
                    { "80", "0.8" },
                    { "90", "0.9" },
                    { "95", "0.95" },
                    { "100", "1" }
                },
                Padding = new Dictionary<string, string>
                {
                    { "px", "1px" },
                    { "0", "0px" },
                    { "0.5", "0.125rem" },
                    { "1", "0.25rem" },
                    { "1.5", "0.375rem" },
                    { "2", "0.5rem" },
                    { "2.5", "0.625rem" },
                    { "3", "0.75rem" },
                    { "3.5", "0.875rem" },
                    { "4", "1rem" },
                    { "5", "1.25rem" },
                    { "6", "1.5rem" },
                    { "7", "1.75rem" },
                    { "8", "2rem" },
                    { "9", "2.25rem" },
                    { "10", "2.5rem" },
                    { "11", "2.75rem" },
                    { "12", "3rem" },
                    { "14", "3.5rem" },
                    { "16", "4rem" },
                    { "20", "5rem" },
                    { "24", "6rem" },
                    { "28", "7rem" },
                    { "32", "8rem" },
                    { "36", "9rem" },
                    { "40", "10rem" },
                    { "44", "11rem" },
                    { "48", "12rem" },
                    { "52", "13rem" },
                    { "56", "14rem" },
                    { "60", "15rem" },
                    { "64", "16rem" },
                    { "72", "18rem" },
                    { "80", "20rem" },
                    { "96", "24rem" }
                },
                Width = new Dictionary<string, string>
                {
                    { "auto", "auto" },
                    { "px", "1px" },
                    { "0", "0px" },
                    { "0.5", "0.125rem" },
                    { "1", "0.25rem" },
                    { "1.5", "0.375rem" },
                    { "2", "0.5rem" },
                    { "2.5", "0.625rem" },
                    { "3", "0.75rem" },
                    { "3.5", "0.875rem" },
                    { "4", "1rem" },
                    { "5", "1.25rem" },
                    { "6", "1.5rem" },
                    { "7", "1.75rem" },
                    { "8", "2rem" },
                    { "9", "2.25rem" },
                    { "10", "2.5rem" },
                    { "11", "2.75rem" },
                    { "12", "3rem" },
                    { "14", "3.5rem" },
                    { "16", "4rem" },
                    { "20", "5rem" },
                    { "24", "6rem" },
                    { "28", "7rem" },
                    { "32", "8rem" },
                    { "36", "9rem" },
                    { "40", "10rem" },
                    { "44", "11rem" },
                    { "48", "12rem" },
                    { "52", "13rem" },
                    { "56", "14rem" },
                    { "60", "15rem" },
                    { "64", "16rem" },
                    { "72", "18rem" },
                    { "80", "20rem" },
                    { "96", "24rem" },
                    { "1/2", "50%" },
                    { "1/3", "33.333333%" },
                    { "2/3", "66.666667%" },
                    { "1/4", "25%" },
                    { "2/4", "50%" },
                    { "3/4", "75%" },
                    { "1/5", "20%" },
                    { "2/5", "40%" },
                    { "3/5", "60%" },
                    { "4/5", "80%" },
                    { "1/6", "16.666667%" },
                    { "2/6", "33.333333%" },
                    { "3/6", "50%" },
                    { "4/6", "66.666667%" },
                    { "5/6", "83.333333%" },
                    { "1/12", "8.333333%" },
                    { "2/12", "16.666667%" },
                    { "3/12", "25%" },
                    { "4/12", "33.333333%" },
                    { "5/12", "41.666667%" },
                    { "6/12", "50%" },
                    { "7/12", "58.333333%" },
                    { "8/12", "66.666667%" },
                    { "9/12", "75%" },
                    { "10/12", "83.333333%" },
                    { "11/12", "91.666667%" },
                    { "full", "100%" }
                }
            };
        }
    }

    [Serializable]
    public class Theme : ScriptableObject
    {
        [SerializeField]
        private Dictionary<string, string> _borderRadius;

        [SerializeField]
        private Dictionary<string, string> _borderWidth;

        [SerializeField]
        private Dictionary<string, Dictionary<string, string>> _colors;

        [SerializeField]
        private Dictionary<string, string> _flexBasis;

        [SerializeField]
        private Dictionary<string, string> _flexGrow;

        [SerializeField]
        private Dictionary<string, string> _flexShrink;

        [SerializeField]
        private Dictionary<string, (string, Dictionary<string, string>)> _fontSize;

        [SerializeField]
        private Dictionary<string, string> _height;

        [SerializeField]
        private Dictionary<string, string> _inset;

        [SerializeField]
        private Dictionary<string, string> _lineHeight;

        [SerializeField]
        private Dictionary<string, string> _margin;

        [SerializeField]
        private Dictionary<string, string> _maxHeight;

        [SerializeField]
        private Dictionary<string, string> _maxWidth;

        [SerializeField]
        private Dictionary<string, string> _minHeight;

        [SerializeField]
        private Dictionary<string, string> _minWidth;

        [SerializeField]
        private Dictionary<string, string> _opacity;

        [SerializeField]
        private Dictionary<string, string> _padding;

        [SerializeField]
        private Dictionary<string, string> _spacing;

        [SerializeField]
        private Dictionary<string, string> _width;

        public Dictionary<string, Dictionary<string, string>> Colors
        {
            get => _colors;
            set => _colors = value;
        }

        public Dictionary<string, string> Spacing
        {
            get => _spacing;
            set => _spacing = value;
        }

        public Dictionary<string, string> BorderRadius
        {
            get => _borderRadius;
            set => _borderRadius = value;
        }

        public Dictionary<string, string> BorderWidth
        {
            get => _borderWidth;
            set => _borderWidth = value;
        }

        public Dictionary<string, string> FlexBasis
        {
            get => _flexBasis;
            set => _flexBasis = value;
        }

        public Dictionary<string, string> FlexGrow
        {
            get => _flexGrow;
            set => _flexGrow = value;
        }

        public Dictionary<string, string> FlexShrink
        {
            get => _flexShrink;
            set => _flexShrink = value;
        }

        public Dictionary<string, (string, Dictionary<string, string>)> FontSize
        {
            get => _fontSize;
            set => _fontSize = value;
        }

        public Dictionary<string, string> Height
        {
            get => _height;
            set => _height = value;
        }

        public Dictionary<string, string> Inset
        {
            get => _inset;
            set => _inset = value;
        }

        public Dictionary<string, string> LineHeight
        {
            get => _lineHeight;
            set => _lineHeight = value;
        }

        public Dictionary<string, string> Margin
        {
            get => _margin;
            set => _margin = value;
        }

        public Dictionary<string, string> MaxHeight
        {
            get => _maxHeight;
            set => _maxHeight = value;
        }

        public Dictionary<string, string> MaxWidth
        {
            get => _maxWidth;
            set => _maxWidth = value;
        }

        public Dictionary<string, string> MinHeight
        {
            get => _minHeight;
            set => _minHeight = value;
        }

        public Dictionary<string, string> MinWidth
        {
            get => _minWidth;
            set => _minWidth = value;
        }

        public Dictionary<string, string> Opacity
        {
            get => _opacity;
            set => _opacity = value;
        }

        public Dictionary<string, string> Padding
        {
            get => _padding;
            set => _padding = value;
        }

        public Dictionary<string, string> Width
        {
            get => _width;
            set => _width = value;
        }
    }
}