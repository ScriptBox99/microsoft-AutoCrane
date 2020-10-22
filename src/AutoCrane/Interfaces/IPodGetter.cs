﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System.Collections.Generic;
using System.Threading.Tasks;
using AutoCrane.Models;

namespace AutoCrane.Interfaces
{
    public interface IPodGetter
    {
        Task<IReadOnlyList<PodInfo>> GetPodsAsync(string ns);

        Task<PodInfo> GetPodAsync(PodIdentifier podIdentifier);
    }
}
