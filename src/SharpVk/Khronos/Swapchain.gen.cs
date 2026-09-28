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
    public partial class Swapchain
        : IDisposable
    {
        internal readonly SharpVk.Interop.Khronos.Swapchain handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.Device parent; 
        
        /// <summary>
        /// 
        /// </summary>
        public Swapchain(SharpVk.Device parent, SharpVk.Interop.Khronos.Swapchain handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.Khronos.Swapchain RawHandle => this.handle;
        
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
                SharpVk.Interop.Khronos.VkSwapchainKHRDestroyDelegate commandDelegate = commandCache.Cache.vkDestroySwapchainKHR;
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
        public unsafe SharpVk.Image[] GetImages()
        {
            try
            {
                SharpVk.Image[] result = default(SharpVk.Image[]);
                uint marshalledSwapchainImageCount = default(uint);
                SharpVk.Interop.Image* marshalledSwapchainImages = default(SharpVk.Interop.Image*);
                SharpVk.Interop.Khronos.VkSwapchainKHRGetImagesDelegate commandDelegate = commandCache.Cache.vkGetSwapchainImagesKHR;
                Result methodResult = commandDelegate(this.parent.handle, this.handle, &marshalledSwapchainImageCount, marshalledSwapchainImages);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledSwapchainImages = (SharpVk.Interop.Image*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Image>((uint)(marshalledSwapchainImageCount)));
                commandDelegate(this.parent.handle, this.handle, &marshalledSwapchainImageCount, marshalledSwapchainImages);
                if (marshalledSwapchainImages != null)
                {
                    var fieldPointer = new SharpVk.Image[(uint)(marshalledSwapchainImageCount)];
                    for(int index = 0; index < (uint)(marshalledSwapchainImageCount); index++)
                    {
                        fieldPointer[index] = new SharpVk.Image(this.parent, marshalledSwapchainImages[index]);
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
        /// <param name="timeout">
        /// </param>
        /// <param name="semaphore">
        /// </param>
        /// <param name="fence">
        /// </param>
        public unsafe uint AcquireNextImage(ulong timeout, SharpVk.Semaphore semaphore, SharpVk.Fence fence)
        {
            try
            {
                uint result = default(uint);
                uint marshalledImageIndex = default(uint);
                SharpVk.Interop.Khronos.VkSwapchainKHRAcquireNextImageDelegate commandDelegate = commandCache.Cache.vkAcquireNextImageKHR;
                Result methodResult = commandDelegate(this.parent.handle, this.handle, timeout, semaphore?.handle ?? default(SharpVk.Interop.Semaphore), fence?.handle ?? default(SharpVk.Interop.Fence), &marshalledImageIndex);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledImageIndex;
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
        public unsafe Result GetStatus()
        {
            try
            {
                Result result = default(Result);
                SharpVk.Interop.Khronos.VkSwapchainKHRGetStatusDelegate commandDelegate = commandCache.Cache.vkGetSwapchainStatusKHR;
                result = commandDelegate(this.parent.handle, this.handle);
                if (SharpVkException.IsError(result))
                {
                    throw SharpVkException.Create(result);
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
        /// <param name="presentId">
        /// </param>
        /// <param name="timeout">
        /// </param>
        public unsafe Result WaitForPresent(ulong presentId, ulong timeout)
        {
            try
            {
                Result result = default(Result);
                SharpVk.Interop.Khronos.VkSwapchainKHRWaitForPresentDelegate commandDelegate = commandCache.Cache.vkWaitForPresentKHR;
                result = commandDelegate(this.parent.handle, this.handle, presentId, timeout);
                if (SharpVkException.IsError(result))
                {
                    throw SharpVkException.Create(result);
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
        /// <param name="presentWait2Info">
        /// </param>
        public unsafe Result WaitForPresent2(SharpVk.Khronos.PresentWait2Info presentWait2Info)
        {
            try
            {
                Result result = default(Result);
                SharpVk.Interop.Khronos.PresentWait2Info* marshalledPresentWait2Info = default(SharpVk.Interop.Khronos.PresentWait2Info*);
                marshalledPresentWait2Info = (SharpVk.Interop.Khronos.PresentWait2Info*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PresentWait2Info>());
                presentWait2Info.MarshalTo(marshalledPresentWait2Info);
                SharpVk.Interop.Khronos.VkSwapchainKHRWaitForPresent2Delegate commandDelegate = commandCache.Cache.vkWaitForPresent2KHR;
                result = commandDelegate(this.parent.handle, this.handle, marshalledPresentWait2Info);
                if (SharpVkException.IsError(result))
                {
                    throw SharpVkException.Create(result);
                }
                return result;
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
