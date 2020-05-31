﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dnn.PersonaBar.Pages.Services.Dto
{
    [JsonObject]
    public class FileDto
    {
        public int fileId { get; set; }
        public string fileName { get; set; }
        public int folderId { get; set; }
        public string folderPath { get; set; }
    }
}
