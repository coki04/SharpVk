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

namespace SharpVk.Valve
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
        /// <param name="bindingReference">
        /// </param>
        public static unsafe SharpVk.Valve.DescriptorSetLayoutHostMappingInfo GetDescriptorSetLayoutHostMappingInfo(this SharpVk.Device extendedHandle, SharpVk.Valve.DescriptorSetBindingReference bindingReference)
        {
            try
            {
                SharpVk.Valve.DescriptorSetLayoutHostMappingInfo result = default(SharpVk.Valve.DescriptorSetLayoutHostMappingInfo);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Valve.DescriptorSetBindingReference* marshalledBindingReference = default(SharpVk.Interop.Valve.DescriptorSetBindingReference*);
                SharpVk.Interop.Valve.DescriptorSetLayoutHostMappingInfo marshalledHostMapping = default(SharpVk.Interop.Valve.DescriptorSetLayoutHostMappingInfo);
                commandCache = extendedHandle.commandCache;
                marshalledBindingReference = (SharpVk.Interop.Valve.DescriptorSetBindingReference*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Valve.DescriptorSetBindingReference>());
                bindingReference.MarshalTo(marshalledBindingReference);
                SharpVk.Interop.Valve.VkDeviceGetDescriptorSetLayoutHostMappingInfoDelegate commandDelegate = commandCache.Cache.vkGetDescriptorSetLayoutHostMappingInfoVALVE;
                commandDelegate(extendedHandle.handle, marshalledBindingReference, &marshalledHostMapping);
                result = SharpVk.Valve.DescriptorSetLayoutHostMappingInfo.MarshalFrom(&marshalledHostMapping);
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
        /// <param name="descriptorSet">
        /// </param>
        public static unsafe IntPtr GetDescriptorSetHostMapping(this SharpVk.Device extendedHandle, SharpVk.DescriptorSet descriptorSet)
        {
            try
            {
                IntPtr result = default(IntPtr);
                CommandCache commandCache = default(CommandCache);
                void* marshalledData = default(void*);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Valve.VkDeviceGetDescriptorSetHostMappingDelegate commandDelegate = commandCache.Cache.vkGetDescriptorSetHostMappingVALVE;
                commandDelegate(extendedHandle.handle, descriptorSet?.handle ?? default(SharpVk.Interop.DescriptorSet), &marshalledData);
                result = new IntPtr(marshalledData);
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
