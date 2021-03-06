﻿// ==========================================================================
//  ErrorController.cs
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex Group
//  All rights reserved.
// ==========================================================================

using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;

namespace Squidex.Areas.IdentityServer.Controllers.Error
{
    [SwaggerIgnore]
    public sealed class ErrorController : IdentityServerController
    {
        [Route("error/")]
        public IActionResult Error()
        {
            return View();
        }
    }
}
