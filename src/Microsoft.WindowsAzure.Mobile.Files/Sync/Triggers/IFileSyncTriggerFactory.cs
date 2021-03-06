﻿// ---------------------------------------------------------------------------- 
// Copyright (c) Microsoft Corporation. All rights reserved.
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.WindowsAzure.MobileServices.Files.Sync.Triggers
{
    public interface IFileSyncTriggerFactory
    {
        IList<IFileSyncTrigger> CreateTriggers(IFileSyncContext fileSyncContext);
    }
}
