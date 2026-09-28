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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Display
    {
        internal readonly SharpVk.Interop.Khronos.Display handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.PhysicalDevice parent; 
        
        /// <summary>
        /// 
        /// </summary>
        public Display(SharpVk.PhysicalDevice parent, SharpVk.Interop.Khronos.Display handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.Khronos.Display RawHandle => this.handle;
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe SharpVk.Khronos.DisplayModeProperties[] GetModeProperties()
        {
            try
            {
                SharpVk.Khronos.DisplayModeProperties[] result = default(SharpVk.Khronos.DisplayModeProperties[]);
                uint marshalledPropertyCount = default(uint);
                SharpVk.Interop.Khronos.DisplayModeProperties* marshalledProperties = default(SharpVk.Interop.Khronos.DisplayModeProperties*);
                SharpVk.Interop.Khronos.VkDisplayKHRGetModePropertiesDelegate commandDelegate = commandCache.Cache.vkGetDisplayModePropertiesKHR;
                Result methodResult = commandDelegate(this.parent.handle, this.handle, &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.Khronos.DisplayModeProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayModeProperties>((uint)(marshalledPropertyCount)));
                commandDelegate(this.parent.handle, this.handle, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.Khronos.DisplayModeProperties[(uint)(marshalledPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledPropertyCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Khronos.DisplayModeProperties.MarshalFrom(&marshalledProperties[index]);
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
        /// <param name="flags">
        /// Reserved for future use, and must be zero.
        /// </param>
        /// <param name="parameters">
        /// A DisplayModeParametersKHR structure describing the display
        /// parameters to use in creating the new mode. If the parameters are
        /// not compatible with the specified display, the implementation must
        /// return Result.ErrorINITIALIZATION_FAILED.
        /// </param>
        /// <param name="allocator">
        /// </param>
        public unsafe SharpVk.Khronos.DisplayMode CreateMode(SharpVk.Khronos.DisplayModeParameters parameters, SharpVk.Khronos.DisplayModeCreateFlags? flags = default(SharpVk.Khronos.DisplayModeCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.DisplayMode result = default(SharpVk.Khronos.DisplayMode);
                SharpVk.Interop.Khronos.DisplayModeCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Khronos.DisplayModeCreateInfo*);
                void* vkDisplayModeCreateInfoKHRNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.DisplayMode marshalledMode = default(SharpVk.Interop.Khronos.DisplayMode);
                marshalledCreateInfo = (SharpVk.Interop.Khronos.DisplayModeCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayModeCreateInfo>());
                marshalledCreateInfo->SType = StructureType.DisplayModeCreateInfo;
                marshalledCreateInfo->Next = vkDisplayModeCreateInfoKHRNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Khronos.DisplayModeCreateFlags);
                }
                marshalledCreateInfo->Parameters = parameters;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkDisplayKHRCreateModeDelegate commandDelegate = commandCache.Cache.vkCreateDisplayModeKHR;
                Result methodResult = commandDelegate(this.parent.handle, this.handle, marshalledCreateInfo, marshalledAllocator, &marshalledMode);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.DisplayMode(this, marshalledMode);
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
        public unsafe SharpVk.Khronos.DisplayModeProperties2[] GetModeProperties2()
        {
            try
            {
                SharpVk.Khronos.DisplayModeProperties2[] result = default(SharpVk.Khronos.DisplayModeProperties2[]);
                uint marshalledPropertyCount = default(uint);
                SharpVk.Interop.Khronos.DisplayModeProperties2* marshalledProperties = default(SharpVk.Interop.Khronos.DisplayModeProperties2*);
                SharpVk.Interop.Khronos.VkDisplayKHRGetModeProperties2Delegate commandDelegate = commandCache.Cache.vkGetDisplayModeProperties2KHR;
                Result methodResult = commandDelegate(this.parent.handle, this.handle, &marshalledPropertyCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.Khronos.DisplayModeProperties2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayModeProperties2>((uint)(marshalledPropertyCount)));
                commandDelegate(this.parent.handle, this.handle, &marshalledPropertyCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.Khronos.DisplayModeProperties2[(uint)(marshalledPropertyCount)];
                    for(int index = 0; index < (uint)(marshalledPropertyCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Khronos.DisplayModeProperties2.MarshalFrom(&marshalledProperties[index]);
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
