﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

using System.Web.Mvc;

namespace DotNetNuke.Tests.Web.Mvc.Fakes.Filters
{
    public class FakeOnExecutingRedirectAttribute : FakeRedirectAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Result = Result;
        }
    }
}
