﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.IO;

namespace BuildValidator
{
    internal class FileNameEqualityComparer : IEqualityComparer<FileInfo>
    {
        public static readonly StringComparison StringComparison = StringComparison.OrdinalIgnoreCase;
        public static readonly StringComparer StringComparer = StringComparer.FromComparison(StringComparison);
        public static readonly FileNameEqualityComparer Instance = new FileNameEqualityComparer();

        private FileNameEqualityComparer()
        {
        }

        public bool Equals(FileInfo? x, FileInfo? y)
            => StringComparer.Equals(x?.Name, y?.Name);

        public int GetHashCode(FileInfo? file)
            => file?.Name.GetHashCode() ?? 0;
    }
}
