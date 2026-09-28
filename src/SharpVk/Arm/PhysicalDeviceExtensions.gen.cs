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

namespace SharpVk.Arm
{
    /// <summary>
    /// 
    /// </summary>
    public static class PhysicalDeviceExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="externalTensorInfo">
        /// </param>
        public static unsafe SharpVk.Arm.ExternalTensorProperties GetExternalTensorProperties(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Arm.PhysicalDeviceExternalTensorInfo externalTensorInfo)
        {
            try
            {
                SharpVk.Arm.ExternalTensorProperties result = default(SharpVk.Arm.ExternalTensorProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.PhysicalDeviceExternalTensorInfo* marshalledExternalTensorInfo = default(SharpVk.Interop.Arm.PhysicalDeviceExternalTensorInfo*);
                SharpVk.Interop.Arm.ExternalTensorProperties marshalledExternalTensorProperties = default(SharpVk.Interop.Arm.ExternalTensorProperties);
                commandCache = extendedHandle.commandCache;
                marshalledExternalTensorInfo = (SharpVk.Interop.Arm.PhysicalDeviceExternalTensorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.PhysicalDeviceExternalTensorInfo>());
                externalTensorInfo.MarshalTo(marshalledExternalTensorInfo);
                SharpVk.Interop.Arm.VkPhysicalDeviceGetExternalTensorPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceExternalTensorPropertiesARM;
                commandDelegate(extendedHandle.handle, marshalledExternalTensorInfo, &marshalledExternalTensorProperties);
                result = SharpVk.Arm.ExternalTensorProperties.MarshalFrom(&marshalledExternalTensorProperties);
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
        /// The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="queueFamilyDataGraphProcessingEngineInfo">
        /// </param>
        public static unsafe SharpVk.Arm.QueueFamilyDataGraphProcessingEngineProperties GetQueueFamilyDataGraphProcessingEngineProperties(this SharpVk.PhysicalDevice extendedHandle, SharpVk.Arm.PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfo queueFamilyDataGraphProcessingEngineInfo)
        {
            try
            {
                SharpVk.Arm.QueueFamilyDataGraphProcessingEngineProperties result = default(SharpVk.Arm.QueueFamilyDataGraphProcessingEngineProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfo* marshalledQueueFamilyDataGraphProcessingEngineInfo = default(SharpVk.Interop.Arm.PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfo*);
                SharpVk.Interop.Arm.QueueFamilyDataGraphProcessingEngineProperties marshalledQueueFamilyDataGraphProcessingEngineProperties = default(SharpVk.Interop.Arm.QueueFamilyDataGraphProcessingEngineProperties);
                commandCache = extendedHandle.commandCache;
                marshalledQueueFamilyDataGraphProcessingEngineInfo = (SharpVk.Interop.Arm.PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfo>());
                queueFamilyDataGraphProcessingEngineInfo.MarshalTo(marshalledQueueFamilyDataGraphProcessingEngineInfo);
                SharpVk.Interop.Arm.VkPhysicalDeviceGetQueueFamilyDataGraphProcessingEnginePropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM;
                commandDelegate(extendedHandle.handle, marshalledQueueFamilyDataGraphProcessingEngineInfo, &marshalledQueueFamilyDataGraphProcessingEngineProperties);
                result = SharpVk.Arm.QueueFamilyDataGraphProcessingEngineProperties.MarshalFrom(&marshalledQueueFamilyDataGraphProcessingEngineProperties);
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
        /// The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="queueFamilyIndex">
        /// </param>
        /// <param name="counters">
        /// </param>
        /// <param name="counterDescriptions">
        /// </param>
        public static unsafe Result EnumerateQueueFamilyPerformanceCountersByRegion(this SharpVk.PhysicalDevice extendedHandle, uint queueFamilyIndex, out PerformanceCounter[] counters, out PerformanceCounterDescription[] counterDescriptions)
        {
            try
            {
                Result result = default(Result);
                uint marshalledCounterCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.PerformanceCounter* marshalledCounters = default(SharpVk.Interop.Arm.PerformanceCounter*);
                SharpVk.Interop.Arm.PerformanceCounterDescription* marshalledCounterDescriptions = default(SharpVk.Interop.Arm.PerformanceCounterDescription*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Arm.VkPhysicalDeviceEnumerateQueueFamilyPerformanceCountersByRegionDelegate commandDelegate = commandCache.Cache.vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM;
                result = commandDelegate(extendedHandle.handle, queueFamilyIndex, &marshalledCounterCount, marshalledCounters, marshalledCounterDescriptions);
                if (SharpVkException.IsError(result))
                {
                    throw SharpVkException.Create(result);
                }
                marshalledCounterDescriptions = (SharpVk.Interop.Arm.PerformanceCounterDescription*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.PerformanceCounterDescription>((uint)(marshalledCounterCount)));
                marshalledCounters = (SharpVk.Interop.Arm.PerformanceCounter*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.PerformanceCounter>((uint)(marshalledCounterCount)));
                commandDelegate(extendedHandle.handle, queueFamilyIndex, &marshalledCounterCount, marshalledCounters, marshalledCounterDescriptions);
                if (marshalledCounters != null)
                {
                    var fieldPointer = new SharpVk.Arm.PerformanceCounter[(uint)(marshalledCounterCount)];
                    for(int index = 0; index < (uint)(marshalledCounterCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Arm.PerformanceCounter.MarshalFrom(&marshalledCounters[index]);
                    }
                    counters = fieldPointer;
                }
                else
                {
                    counters = null;
                }
                if (marshalledCounterDescriptions != null)
                {
                    var fieldPointer = new SharpVk.Arm.PerformanceCounterDescription[(uint)(marshalledCounterCount)];
                    for(int index = 0; index < (uint)(marshalledCounterCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Arm.PerformanceCounterDescription.MarshalFrom(&marshalledCounterDescriptions[index]);
                    }
                    counterDescriptions = fieldPointer;
                }
                else
                {
                    counterDescriptions = null;
                }
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
        /// The PhysicalDevice handle to extend.
        /// </param>
        public static unsafe SharpVk.Arm.ShaderInstrumentationMetricDescription[] EnumerateShaderInstrumentationMetrics(this SharpVk.PhysicalDevice extendedHandle)
        {
            try
            {
                SharpVk.Arm.ShaderInstrumentationMetricDescription[] result = default(SharpVk.Arm.ShaderInstrumentationMetricDescription[]);
                uint marshalledDescriptionCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.ShaderInstrumentationMetricDescription* marshalledDescriptions = default(SharpVk.Interop.Arm.ShaderInstrumentationMetricDescription*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Arm.VkPhysicalDeviceEnumerateShaderInstrumentationMetricsDelegate commandDelegate = commandCache.Cache.vkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM;
                Result methodResult = commandDelegate(extendedHandle.handle, &marshalledDescriptionCount, marshalledDescriptions);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledDescriptions = (SharpVk.Interop.Arm.ShaderInstrumentationMetricDescription*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.ShaderInstrumentationMetricDescription>((uint)(marshalledDescriptionCount)));
                commandDelegate(extendedHandle.handle, &marshalledDescriptionCount, marshalledDescriptions);
                if (marshalledDescriptions != null)
                {
                    var fieldPointer = new SharpVk.Arm.ShaderInstrumentationMetricDescription[(uint)(marshalledDescriptionCount)];
                    for(int index = 0; index < (uint)(marshalledDescriptionCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Arm.ShaderInstrumentationMetricDescription.MarshalFrom(&marshalledDescriptions[index]);
                    }
                    result = fieldPointer;
                }
                else
                {
                    result = null;
                }
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
