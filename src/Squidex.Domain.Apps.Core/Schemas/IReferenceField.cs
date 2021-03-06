﻿// ==========================================================================
//  IReferenceField.cs
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex Group
//  All rights reserved.
// ==========================================================================

using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Squidex.Domain.Apps.Core.Schemas
{
    public interface IReferenceField
    {
        IEnumerable<Guid> GetReferencedIds(JToken value);

        JToken RemoveDeletedReferences(JToken value, ISet<Guid> deletedReferencedIds);
    }
}
