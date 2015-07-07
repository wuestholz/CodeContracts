﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ContractAdornments.Interfaces
{
    using Microsoft.Cci.Contracts;

    public interface INonlockingHost : IContractAwareHost
    {
        void AddLibPath(string path);
    }
}
