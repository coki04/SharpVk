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
        /// <param name="queueFamilyIndex">
        /// </param>
        public static unsafe SharpVk.Arm.QueueFamilyDataGraphProperties[] GetQueueFamilyDataGraphProperties(this SharpVk.PhysicalDevice extendedHandle, uint queueFamilyIndex)
        {
            try
            {
                SharpVk.Arm.QueueFamilyDataGraphProperties[] result = default(SharpVk.Arm.QueueFamilyDataGraphProperties[]);
                uint marshalledQueueFamilyDataGraphPropertyCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.QueueFamilyDataGraphProperties* marshalledQueueFamilyDataGraphProperties = default(SharpVk.Interop.Arm.QueueFamilyDataGraphProperties*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Arm.VkPhysicalDeviceGetQueueFamilyDataGraphPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM;
                Result methodResult = commandDelegate(extendedHandle.handle, queueFamilyIndex, &marshalledQueueFamilyDataGraphPropertyCount, marshalledQueueFamilyDataGraphProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledQueueFamilyDataGraphProperties = (SharpVk.Interop.Arm.QueueFamilyDataGraphProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.QueueFamilyDataGraphProperties>((uint)(marshalledQueueFamilyDataGraphPropertyCount)));
                commandDelegate(extendedHandle.handle, queueFamilyIndex, &marshalledQueueFamilyDataGraphPropertyCount, marshalledQueueFamilyDataGraphProperties);
                if (marshalledQueueFamilyDataGraphProperties != null)
                {
                    var fieldPointer = new SharpVk.Arm.QueueFamilyDataGraphProperties[(uint)(marshalledQueueFamilyDataGraphPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledQueueFamilyDataGraphPropertyCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Arm.QueueFamilyDataGraphProperties.MarshalFrom(&marshalledQueueFamilyDataGraphProperties[index]);
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
        /// <param name="queueFamilyDataGraphProperties">
        /// </param>
        public static unsafe SharpVk.BaseOutStructure GetQueueFamilyDataGraphEngineOperationProperties(this SharpVk.PhysicalDevice extendedHandle, uint queueFamilyIndex, SharpVk.Arm.QueueFamilyDataGraphProperties queueFamilyDataGraphProperties)
        {
            try
            {
                SharpVk.BaseOutStructure result = default(SharpVk.BaseOutStructure);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.QueueFamilyDataGraphProperties* marshalledQueueFamilyDataGraphProperties = default(SharpVk.Interop.Arm.QueueFamilyDataGraphProperties*);
                SharpVk.Interop.BaseOutStructure marshalledProperties = default(SharpVk.Interop.BaseOutStructure);
                commandCache = extendedHandle.commandCache;
                marshalledQueueFamilyDataGraphProperties = (SharpVk.Interop.Arm.QueueFamilyDataGraphProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.QueueFamilyDataGraphProperties>());
                queueFamilyDataGraphProperties.MarshalTo(marshalledQueueFamilyDataGraphProperties);
                SharpVk.Interop.Arm.VkPhysicalDeviceGetQueueFamilyDataGraphEngineOperationPropertiesDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM;
                Result methodResult = commandDelegate(extendedHandle.handle, queueFamilyIndex, marshalledQueueFamilyDataGraphProperties, &marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.BaseOutStructure.MarshalFrom(&marshalledProperties);
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
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The PhysicalDevice handle to extend.
        /// </param>
        /// <param name="queueFamilyIndex">
        /// </param>
        /// <param name="queueFamilyDataGraphProperties">
        /// </param>
        /// <param name="opticalFlowImageFormatInfo">
        /// </param>
        public static unsafe SharpVk.Arm.DataGraphOpticalFlowImageFormatProperties[] GetQueueFamilyDataGraphOpticalFlowImageFormats(this SharpVk.PhysicalDevice extendedHandle, uint queueFamilyIndex, SharpVk.Arm.QueueFamilyDataGraphProperties queueFamilyDataGraphProperties, SharpVk.Arm.DataGraphOpticalFlowImageFormatInfo opticalFlowImageFormatInfo)
        {
            try
            {
                SharpVk.Arm.DataGraphOpticalFlowImageFormatProperties[] result = default(SharpVk.Arm.DataGraphOpticalFlowImageFormatProperties[]);
                uint marshalledFormatCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Arm.QueueFamilyDataGraphProperties* marshalledQueueFamilyDataGraphProperties = default(SharpVk.Interop.Arm.QueueFamilyDataGraphProperties*);
                SharpVk.Interop.Arm.DataGraphOpticalFlowImageFormatInfo* marshalledOpticalFlowImageFormatInfo = default(SharpVk.Interop.Arm.DataGraphOpticalFlowImageFormatInfo*);
                SharpVk.Interop.Arm.DataGraphOpticalFlowImageFormatProperties* marshalledImageFormatProperties = default(SharpVk.Interop.Arm.DataGraphOpticalFlowImageFormatProperties*);
                commandCache = extendedHandle.commandCache;
                marshalledQueueFamilyDataGraphProperties = (SharpVk.Interop.Arm.QueueFamilyDataGraphProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.QueueFamilyDataGraphProperties>());
                queueFamilyDataGraphProperties.MarshalTo(marshalledQueueFamilyDataGraphProperties);
                marshalledOpticalFlowImageFormatInfo = (SharpVk.Interop.Arm.DataGraphOpticalFlowImageFormatInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphOpticalFlowImageFormatInfo>());
                opticalFlowImageFormatInfo.MarshalTo(marshalledOpticalFlowImageFormatInfo);
                SharpVk.Interop.Arm.VkPhysicalDeviceGetQueueFamilyDataGraphOpticalFlowImageFormatsDelegate commandDelegate = commandCache.Cache.vkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM;
                Result methodResult = commandDelegate(extendedHandle.handle, queueFamilyIndex, marshalledQueueFamilyDataGraphProperties, marshalledOpticalFlowImageFormatInfo, &marshalledFormatCount, marshalledImageFormatProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledImageFormatProperties = (SharpVk.Interop.Arm.DataGraphOpticalFlowImageFormatProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.DataGraphOpticalFlowImageFormatProperties>((uint)(marshalledFormatCount)));
                commandDelegate(extendedHandle.handle, queueFamilyIndex, marshalledQueueFamilyDataGraphProperties, marshalledOpticalFlowImageFormatInfo, &marshalledFormatCount, marshalledImageFormatProperties);
                if (marshalledImageFormatProperties != null)
                {
                    var fieldPointer = new SharpVk.Arm.DataGraphOpticalFlowImageFormatProperties[(uint)(marshalledFormatCount)];
                    for(int index = 0; index < (uint)(marshalledFormatCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Arm.DataGraphOpticalFlowImageFormatProperties.MarshalFrom(&marshalledImageFormatProperties[index]);
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
