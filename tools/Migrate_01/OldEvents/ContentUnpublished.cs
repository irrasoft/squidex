﻿// ==========================================================================
//  ContentUnpublished.cs
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex Group
//  All rights reserved.
// ==========================================================================

using System;
using Squidex.Domain.Apps.Core.Contents;
using Squidex.Domain.Apps.Events.Contents;
using Squidex.Infrastructure.EventSourcing;
using Squidex.Infrastructure.Reflection;

namespace Migrate_01.OldEvents
{
    [EventType(nameof(ContentUnpublished))]
    [Obsolete]
    public sealed class ContentUnpublished : ContentEvent, IMigratedEvent
    {
        public IEvent Migrate()
        {
            return SimpleMapper.Map(this, new ContentStatusChanged { Status = Status.Draft });
        }
    }
}
