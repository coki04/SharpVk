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

namespace SharpVk.NVidia
{
    /// <summary>
    /// 
    /// </summary>
    public static class SwapchainExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Swapchain handle to extend.
        /// </param>
        /// <param name="sleepModeInfo">
        /// </param>
        public static unsafe void SetLatencySleepMode(this SharpVk.Khronos.Swapchain extendedHandle, SharpVk.NVidia.LatencySleepModeInfo sleepModeInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.LatencySleepModeInfo* marshalledSleepModeInfo = default(SharpVk.Interop.NVidia.LatencySleepModeInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledSleepModeInfo = (SharpVk.Interop.NVidia.LatencySleepModeInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.LatencySleepModeInfo>());
                sleepModeInfo.MarshalTo(marshalledSleepModeInfo);
                SharpVk.Interop.NVidia.VkSwapchainKHRSetLatencySleepModeDelegate commandDelegate = commandCache.Cache.vkSetLatencySleepModeNV;
                Result methodResult = commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, marshalledSleepModeInfo);
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
        /// The Swapchain handle to extend.
        /// </param>
        /// <param name="sleepInfo">
        /// </param>
        public static unsafe void LatencySleep(this SharpVk.Khronos.Swapchain extendedHandle, SharpVk.NVidia.LatencySleepInfo sleepInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.LatencySleepInfo* marshalledSleepInfo = default(SharpVk.Interop.NVidia.LatencySleepInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledSleepInfo = (SharpVk.Interop.NVidia.LatencySleepInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.LatencySleepInfo>());
                sleepInfo.MarshalTo(marshalledSleepInfo);
                SharpVk.Interop.NVidia.VkSwapchainKHRLatencySleepDelegate commandDelegate = commandCache.Cache.vkLatencySleepNV;
                Result methodResult = commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, marshalledSleepInfo);
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
        /// The Swapchain handle to extend.
        /// </param>
        /// <param name="latencyMarkerInfo">
        /// </param>
        public static unsafe void SetLatencyMarker(this SharpVk.Khronos.Swapchain extendedHandle, SharpVk.NVidia.SetLatencyMarkerInfo latencyMarkerInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.SetLatencyMarkerInfo* marshalledLatencyMarkerInfo = default(SharpVk.Interop.NVidia.SetLatencyMarkerInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledLatencyMarkerInfo = (SharpVk.Interop.NVidia.SetLatencyMarkerInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.SetLatencyMarkerInfo>());
                latencyMarkerInfo.MarshalTo(marshalledLatencyMarkerInfo);
                SharpVk.Interop.NVidia.VkSwapchainKHRSetLatencyMarkerDelegate commandDelegate = commandCache.Cache.vkSetLatencyMarkerNV;
                commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, marshalledLatencyMarkerInfo);
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
        /// The Swapchain handle to extend.
        /// </param>
        public static unsafe SharpVk.NVidia.GetLatencyMarkerInfo GetLatencyTimings(this SharpVk.Khronos.Swapchain extendedHandle)
        {
            try
            {
                SharpVk.NVidia.GetLatencyMarkerInfo result = default(SharpVk.NVidia.GetLatencyMarkerInfo);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.NVidia.GetLatencyMarkerInfo marshalledLatencyMarkerInfo = default(SharpVk.Interop.NVidia.GetLatencyMarkerInfo);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.NVidia.VkSwapchainKHRGetLatencyTimingsDelegate commandDelegate = commandCache.Cache.vkGetLatencyTimingsNV;
                commandDelegate(extendedHandle.parent.handle, extendedHandle.handle, &marshalledLatencyMarkerInfo);
                result = SharpVk.NVidia.GetLatencyMarkerInfo.MarshalFrom(&marshalledLatencyMarkerInfo);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
