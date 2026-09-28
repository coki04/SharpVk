// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2026
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

// This file was automatically generated and should not be edited directly.

using System;

namespace SharpVk.Amd
{
    /// <summary>
    /// 
    /// </summary>
    public static class DeviceExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="secondaryCopySource">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Amd.GpaSession CreateGpaSession(this SharpVk.Device extendedHandle, SharpVk.Amd.GpaSession secondaryCopySource, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Amd.GpaSession result = default(SharpVk.Amd.GpaSession);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Amd.GpaSessionCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Amd.GpaSessionCreateInfo*);
                void* vkGpaSessionCreateInfoAMDNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Amd.GpaSession marshalledGpaSession = default(SharpVk.Interop.Amd.GpaSession);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Amd.GpaSessionCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amd.GpaSessionCreateInfo>());
                marshalledCreateInfo->SType = StructureType.GpaSessionCreateInfo;
                marshalledCreateInfo->Next = vkGpaSessionCreateInfoAMDNextPointer;
                marshalledCreateInfo->SecondaryCopySource = secondaryCopySource?.handle ?? default(SharpVk.Interop.Amd.GpaSession);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Amd.VkDeviceCreateGpaSessionDelegate commandDelegate = commandCache.Cache.vkCreateGpaSessionAMD;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledGpaSession);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Amd.GpaSession(extendedHandle, marshalledGpaSession);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        public static unsafe void SetGpaDeviceClockMode(this SharpVk.Device extendedHandle, SharpVk.Amd.GpaDeviceClockModeInfo info)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Amd.GpaDeviceClockModeInfo* marshalledInfo = default(SharpVk.Interop.Amd.GpaDeviceClockModeInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Amd.GpaDeviceClockModeInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amd.GpaDeviceClockModeInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Amd.VkDeviceSetGpaDeviceClockModeDelegate commandDelegate = commandCache.Cache.vkSetGpaDeviceClockModeAMD;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledInfo);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="data">
        /// </param>
        public static unsafe void AntiLagUpdate(this SharpVk.Device extendedHandle, SharpVk.Amd.AntiLagData data)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Amd.AntiLagData* marshalledData = default(SharpVk.Interop.Amd.AntiLagData*);
                commandCache = extendedHandle.commandCache;
                marshalledData = (SharpVk.Interop.Amd.AntiLagData*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amd.AntiLagData>());
                data.MarshalTo(marshalledData);
                SharpVk.Interop.Amd.VkDeviceAntiLagUpdateDelegate commandDelegate = commandCache.Cache.vkAntiLagUpdateAMD;
                commandDelegate(extendedHandle.handle, marshalledData);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
