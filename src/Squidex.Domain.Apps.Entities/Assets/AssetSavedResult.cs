﻿// ==========================================================================
//  AssetSavedResult.cs
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex Group
//  All rights reserved.
// ==========================================================================

using Squidex.Infrastructure.Commands;

namespace Squidex.Domain.Apps.Entities.Assets
{
    public class AssetSavedResult : EntitySavedResult
    {
        public long FileVersion { get; }

        public AssetSavedResult(long version, long fileVersion)
            : base(version)
        {
            FileVersion = fileVersion;
        }
    }
}
