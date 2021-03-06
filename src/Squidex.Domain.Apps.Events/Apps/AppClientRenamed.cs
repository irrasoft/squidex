﻿// ==========================================================================
//  AppClientRenamed.cs
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex Group
//  All rights reserved.
// ==========================================================================

using Squidex.Infrastructure.EventSourcing;

namespace Squidex.Domain.Apps.Events.Apps
{
    [EventType(nameof(AppClientRenamed))]
    public sealed class AppClientRenamed : AppEvent
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
