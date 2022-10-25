// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2022
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
    public partial class VideoSessionParameters
        : IDisposable
    {
        internal readonly SharpVk.Interop.Khronos.VideoSessionParameters handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.Khronos.VideoSession parent; 
        
        internal VideoSessionParameters(SharpVk.Khronos.VideoSession parent, SharpVk.Interop.Khronos.VideoSessionParameters handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.Khronos.VideoSessionParameters RawHandle => this.handle;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="updateSequenceCount">
        /// </param>
        /// <param name="videoDecodeH264SessionParametersAddInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="videoDecodeH265SessionParametersAddInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="videoEncodeH264SessionParametersAddInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="videoEncodeH265SessionParametersAddInfoExt">
        /// Extension struct
        /// </param>
        public unsafe void Update(uint updateSequenceCount, SharpVk.Multivendor.VideoDecodeH264SessionParametersAddInfo? videoDecodeH264SessionParametersAddInfoExt = null, SharpVk.Multivendor.VideoDecodeH265SessionParametersAddInfo? videoDecodeH265SessionParametersAddInfoExt = null, SharpVk.Multivendor.VideoEncodeH264SessionParametersAddInfo? videoEncodeH264SessionParametersAddInfoExt = null, SharpVk.Multivendor.VideoEncodeH265SessionParametersAddInfo? videoEncodeH265SessionParametersAddInfoExt = null)
        {
            try
            {
                SharpVk.Interop.Khronos.VideoSessionParametersUpdateInfo* marshalledUpdateInfo = default(SharpVk.Interop.Khronos.VideoSessionParametersUpdateInfo*);
                void* vkVideoSessionParametersUpdateInfoKHRNextPointer = default(void*);
                if (videoDecodeH264SessionParametersAddInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.VideoDecodeH264SessionParametersAddInfo* extensionPointer = default(SharpVk.Interop.Multivendor.VideoDecodeH264SessionParametersAddInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.VideoDecodeH264SessionParametersAddInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.VideoDecodeH264SessionParametersAddInfo>());
                    videoDecodeH264SessionParametersAddInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoSessionParametersUpdateInfoKHRNextPointer;
                    vkVideoSessionParametersUpdateInfoKHRNextPointer = extensionPointer;
                }
                if (videoDecodeH265SessionParametersAddInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.VideoDecodeH265SessionParametersAddInfo* extensionPointer = default(SharpVk.Interop.Multivendor.VideoDecodeH265SessionParametersAddInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.VideoDecodeH265SessionParametersAddInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.VideoDecodeH265SessionParametersAddInfo>());
                    videoDecodeH265SessionParametersAddInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoSessionParametersUpdateInfoKHRNextPointer;
                    vkVideoSessionParametersUpdateInfoKHRNextPointer = extensionPointer;
                }
                if (videoEncodeH264SessionParametersAddInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.VideoEncodeH264SessionParametersAddInfo* extensionPointer = default(SharpVk.Interop.Multivendor.VideoEncodeH264SessionParametersAddInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.VideoEncodeH264SessionParametersAddInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.VideoEncodeH264SessionParametersAddInfo>());
                    videoEncodeH264SessionParametersAddInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoSessionParametersUpdateInfoKHRNextPointer;
                    vkVideoSessionParametersUpdateInfoKHRNextPointer = extensionPointer;
                }
                if (videoEncodeH265SessionParametersAddInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.VideoEncodeH265SessionParametersAddInfo* extensionPointer = default(SharpVk.Interop.Multivendor.VideoEncodeH265SessionParametersAddInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.VideoEncodeH265SessionParametersAddInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.VideoEncodeH265SessionParametersAddInfo>());
                    videoEncodeH265SessionParametersAddInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoSessionParametersUpdateInfoKHRNextPointer;
                    vkVideoSessionParametersUpdateInfoKHRNextPointer = extensionPointer;
                }
                marshalledUpdateInfo = (SharpVk.Interop.Khronos.VideoSessionParametersUpdateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoSessionParametersUpdateInfo>());
                marshalledUpdateInfo->SType = StructureType.VideoSessionParametersUpdateInfo;
                marshalledUpdateInfo->Next = vkVideoSessionParametersUpdateInfoKHRNextPointer;
                marshalledUpdateInfo->UpdateSequenceCount = updateSequenceCount;
                SharpVk.Interop.Khronos.VkVideoSessionParametersKHRUpdateDelegate commandDelegate = commandCache.Cache.vkUpdateVideoSessionParametersKHR;
                Result methodResult = commandDelegate(default(Device).handle, this.handle, marshalledUpdateInfo);
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
                SharpVk.Interop.Khronos.VkVideoSessionParametersKHRDestroyDelegate commandDelegate = commandCache.Cache.vkDestroyVideoSessionParametersKHR;
                commandDelegate(default(Device).handle, this.handle, marshalledAllocator);
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
