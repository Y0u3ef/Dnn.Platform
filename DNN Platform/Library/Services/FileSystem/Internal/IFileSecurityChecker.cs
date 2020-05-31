﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

using System.IO;

namespace DotNetNuke.Services.FileSystem.Internal
{
    /// <summary>
    /// File Content Security Checker.
    /// </summary>
    public interface IFileSecurityChecker
    {
        /// <summary>
        /// Checks if the file has valid content.
        /// </summary>
        /// <param name="fileContent">The File Content.</param>
        bool Validate(Stream fileContent);
    }
}
