﻿// ==========================================================================
//  GetStatesResponse.cs
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex Group
//  All rights reserved.
// ==========================================================================

namespace Squidex.Infrastructure.EventSourcing.Grains.Messages
{
    public sealed class GetStatesResponse
    {
        public EventConsumerInfo[] States { get; set; }
    }
}
