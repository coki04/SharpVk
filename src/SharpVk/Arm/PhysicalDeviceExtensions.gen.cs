// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2025
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
    }
}
