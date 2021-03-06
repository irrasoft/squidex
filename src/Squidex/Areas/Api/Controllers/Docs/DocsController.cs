﻿// ==========================================================================
//  DocsController.cs
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex Group
//  All rights reserved.
// ==========================================================================

using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using Squidex.Infrastructure.Commands;
using Squidex.Pipeline;

namespace Squidex.Areas.Api.Controllers.Docs
{
    [SwaggerIgnore]
    public sealed class DocsController : ApiController
    {
        public DocsController(ICommandBus commandBus)
            : base(commandBus)
        {
        }

        [HttpGet]
        [Route("docs/")]
        [ApiCosts(0)]
        public IActionResult Docs()
        {
            var vm = new DocsVM { Specification = "~/swagger/v1/swagger.json" };

            return View(nameof(Docs), vm);
        }
    }
}
