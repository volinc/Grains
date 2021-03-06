﻿using System;
using System.Threading.Tasks;
using Orleans;

namespace Grains.Interfaces
{
    public interface IOrderGrain : IGrainWithGuidKey
    {
        Task<Guid> CreateAsync();

        Task StartSearchAsync();

        Task StopSearchAsync();

        Task AcceptAsync();

        Task CheckExceptionSerializationAsync();
    }
}