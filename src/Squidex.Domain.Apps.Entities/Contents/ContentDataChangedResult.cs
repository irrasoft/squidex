﻿// ==========================================================================
//  ContentChangedResult.cs
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex Group
//  All rights reserved.
// ==========================================================================

using Squidex.Domain.Apps.Core.Contents;
using Squidex.Infrastructure.Commands;

namespace Squidex.Domain.Apps.Entities.Contents
{
    public sealed class ContentDataChangedResult : EntitySavedResult
    {
        public NamedContentData Data { get; }

        public ContentDataChangedResult(NamedContentData data, long version)
            : base(version)
        {
            Data = data;
        }
    }
}
