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
    public partial class VideoSession
        : IDisposable
    {
        internal readonly SharpVk.Interop.Khronos.VideoSession handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.Device parent; 
        
        /// <summary>
        /// 
        /// </summary>
        public VideoSession(SharpVk.Device parent, SharpVk.Interop.Khronos.VideoSession handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.Khronos.VideoSession RawHandle => this.handle;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="allocator">
        /// </param>
        public unsafe void Destroy(SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkVideoSessionKHRDestroyDelegate commandDelegate = commandCache.Cache.vkDestroyVideoSessionKHR;
                commandDelegate(this.parent.handle, this.handle, marshalledAllocator);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe SharpVk.Khronos.VideoSessionMemoryRequirements[] GetMemoryRequirements()
        {
            try
            {
                SharpVk.Khronos.VideoSessionMemoryRequirements[] result = default(SharpVk.Khronos.VideoSessionMemoryRequirements[]);
                uint marshalledMemoryRequirementsCount = default(uint);
                SharpVk.Interop.Khronos.VideoSessionMemoryRequirements* marshalledMemoryRequirements = default(SharpVk.Interop.Khronos.VideoSessionMemoryRequirements*);
                SharpVk.Interop.Khronos.VkVideoSessionKHRGetMemoryRequirementsDelegate commandDelegate = commandCache.Cache.vkGetVideoSessionMemoryRequirementsKHR;
                Result methodResult = commandDelegate(this.parent.handle, this.handle, &marshalledMemoryRequirementsCount, marshalledMemoryRequirements);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledMemoryRequirements = (SharpVk.Interop.Khronos.VideoSessionMemoryRequirements*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoSessionMemoryRequirements>((uint)(marshalledMemoryRequirementsCount)));
                commandDelegate(this.parent.handle, this.handle, &marshalledMemoryRequirementsCount, marshalledMemoryRequirements);
                if (marshalledMemoryRequirements != null)
                {
                    var fieldPointer = new SharpVk.Khronos.VideoSessionMemoryRequirements[(uint)(marshalledMemoryRequirementsCount)];
                    for(int index = 0; index < (uint)(marshalledMemoryRequirementsCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Khronos.VideoSessionMemoryRequirements.MarshalFrom(&marshalledMemoryRequirements[index]);
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
        /// <param name="bindSessionMemoryInfos">
        /// </param>
        public unsafe void BindMemory(ArrayProxy<SharpVk.Khronos.BindVideoSessionMemoryInfo>? bindSessionMemoryInfos)
        {
            try
            {
                SharpVk.Interop.Khronos.BindVideoSessionMemoryInfo* marshalledBindSessionMemoryInfos = default(SharpVk.Interop.Khronos.BindVideoSessionMemoryInfo*);
                if (bindSessionMemoryInfos.IsNull())
                {
                    marshalledBindSessionMemoryInfos = null;
                }
                else
                {
                    if (bindSessionMemoryInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBindSessionMemoryInfos = (SharpVk.Interop.Khronos.BindVideoSessionMemoryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.BindVideoSessionMemoryInfo>());
                        bindSessionMemoryInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Khronos.BindVideoSessionMemoryInfo*)(marshalledBindSessionMemoryInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.BindVideoSessionMemoryInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.BindVideoSessionMemoryInfo>(Interop.HeapUtil.GetLength(bindSessionMemoryInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(bindSessionMemoryInfos.Value)); index++)
                        {
                            bindSessionMemoryInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledBindSessionMemoryInfos = fieldPointer;
                    }
                }
                SharpVk.Interop.Khronos.VkVideoSessionKHRBindMemoryDelegate commandDelegate = commandCache.Cache.vkBindVideoSessionMemoryKHR;
                Result methodResult = commandDelegate(this.parent.handle, this.handle, (uint)(Interop.HeapUtil.GetLength(bindSessionMemoryInfos)), marshalledBindSessionMemoryInfos);
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
        /// Destroys the handles and releases any unmanaged resources
        /// associated with it.
        /// </summary>
        public void Dispose()
        {
            this.Destroy();
        }
    }
}
