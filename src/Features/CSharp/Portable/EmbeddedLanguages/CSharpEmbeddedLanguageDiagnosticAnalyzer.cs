﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.CSharp.EmbeddedLanguages.LanguageServices;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.EmbeddedLanguages;

namespace Microsoft.CodeAnalysis.CSharp.EmbeddedLanguages
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    internal class CSharpEmbeddedLanguageDiagnosticAnalyzer : AbstractEmbeddedLanguageDiagnosticAnalyzer
    {
        public CSharpEmbeddedLanguageDiagnosticAnalyzer()
            : base(CSharpEmbeddedLanguagesProvider.Instance)
        {
        }
    }
}
