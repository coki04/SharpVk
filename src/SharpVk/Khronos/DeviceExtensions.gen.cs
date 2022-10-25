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
    public static class DeviceExtensions
    {
        /// <summary>
        /// Create a swapchain.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="flags">
        /// A bitmask indicating parameters of swapchain creation. Bits which
        /// can be set include: + --
        /// </param>
        /// <param name="surface">
        /// </param>
        /// <param name="minImageCount">
        /// </param>
        /// <param name="imageFormat">
        /// </param>
        /// <param name="imageColorSpace">
        /// </param>
        /// <param name="imageExtent">
        /// </param>
        /// <param name="imageArrayLayers">
        /// </param>
        /// <param name="imageUsage">
        /// </param>
        /// <param name="imageSharingMode">
        /// </param>
        /// <param name="queueFamilyIndices">
        /// </param>
        /// <param name="preTransform">
        /// </param>
        /// <param name="compositeAlpha">
        /// </param>
        /// <param name="presentMode">
        /// </param>
        /// <param name="clipped">
        /// </param>
        /// <param name="oldSwapchain">
        /// </param>
        /// <param name="swapchainCounterCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="deviceGroupSwapchainCreateInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="swapchainDisplayNativeHdrCreateInfoAmd">
        /// Extension struct
        /// </param>
        /// <param name="imageFormatListCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="surfaceFullScreenExclusiveInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="surfaceFullScreenExclusiveWin32InfoExt">
        /// Extension struct
        /// </param>
        /// <param name="swapchainPresentBarrierCreateInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="imageCompressionControlExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Khronos.Swapchain CreateSwapchain(this SharpVk.Device extendedHandle, SharpVk.Khronos.Surface surface, uint minImageCount, SharpVk.Format imageFormat, SharpVk.Khronos.ColorSpace imageColorSpace, SharpVk.Extent2D imageExtent, uint imageArrayLayers, SharpVk.ImageUsageFlags imageUsage, SharpVk.SharingMode imageSharingMode, ArrayProxy<uint>? queueFamilyIndices, SharpVk.Khronos.SurfaceTransformFlags preTransform, SharpVk.Khronos.CompositeAlphaFlags compositeAlpha, SharpVk.Khronos.PresentMode presentMode, bool clipped, SharpVk.Khronos.Swapchain oldSwapchain, SharpVk.Khronos.SwapchainCreateFlags? flags = default(SharpVk.Khronos.SwapchainCreateFlags?), SharpVk.Multivendor.SwapchainCounterCreateInfo? swapchainCounterCreateInfoExt = null, SharpVk.Khronos.DeviceGroupSwapchainCreateInfo? deviceGroupSwapchainCreateInfoKhr = null, SharpVk.Amd.SwapchainDisplayNativeHdrCreateInfo? swapchainDisplayNativeHdrCreateInfoAmd = null, SharpVk.ImageFormatListCreateInfo? imageFormatListCreateInfo = null, SharpVk.Multivendor.SurfaceFullScreenExclusiveInfo? surfaceFullScreenExclusiveInfoExt = null, SharpVk.Multivendor.SurfaceFullScreenExclusiveWin32Info? surfaceFullScreenExclusiveWin32InfoExt = null, SharpVk.NVidia.SwapchainPresentBarrierCreateInfo? swapchainPresentBarrierCreateInfoNv = null, SharpVk.Multivendor.ImageCompressionControl? imageCompressionControlExt = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.Swapchain result = default(SharpVk.Khronos.Swapchain);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.SwapchainCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Khronos.SwapchainCreateInfo*);
                void* vkSwapchainCreateInfoKHRNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.Swapchain marshalledSwapchain = default(SharpVk.Interop.Khronos.Swapchain);
                if (swapchainCounterCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.SwapchainCounterCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.SwapchainCounterCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.SwapchainCounterCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.SwapchainCounterCreateInfo>());
                    swapchainCounterCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (deviceGroupSwapchainCreateInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.DeviceGroupSwapchainCreateInfo* extensionPointer = default(SharpVk.Interop.Khronos.DeviceGroupSwapchainCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.DeviceGroupSwapchainCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DeviceGroupSwapchainCreateInfo>());
                    deviceGroupSwapchainCreateInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (swapchainDisplayNativeHdrCreateInfoAmd != null)
                {
                    SharpVk.Interop.Amd.SwapchainDisplayNativeHdrCreateInfo* extensionPointer = default(SharpVk.Interop.Amd.SwapchainDisplayNativeHdrCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Amd.SwapchainDisplayNativeHdrCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amd.SwapchainDisplayNativeHdrCreateInfo>());
                    swapchainDisplayNativeHdrCreateInfoAmd.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (imageFormatListCreateInfo != null)
                {
                    SharpVk.Interop.ImageFormatListCreateInfo* extensionPointer = default(SharpVk.Interop.ImageFormatListCreateInfo*);
                    extensionPointer = (SharpVk.Interop.ImageFormatListCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageFormatListCreateInfo>());
                    imageFormatListCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (surfaceFullScreenExclusiveInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveInfo* extensionPointer = default(SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveInfo>());
                    surfaceFullScreenExclusiveInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (surfaceFullScreenExclusiveWin32InfoExt != null)
                {
                    SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveWin32Info* extensionPointer = default(SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveWin32Info*);
                    extensionPointer = (SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveWin32Info*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveWin32Info>());
                    surfaceFullScreenExclusiveWin32InfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (swapchainPresentBarrierCreateInfoNv != null)
                {
                    SharpVk.Interop.NVidia.SwapchainPresentBarrierCreateInfo* extensionPointer = default(SharpVk.Interop.NVidia.SwapchainPresentBarrierCreateInfo*);
                    extensionPointer = (SharpVk.Interop.NVidia.SwapchainPresentBarrierCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.SwapchainPresentBarrierCreateInfo>());
                    swapchainPresentBarrierCreateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (imageCompressionControlExt != null)
                {
                    SharpVk.Interop.Multivendor.ImageCompressionControl* extensionPointer = default(SharpVk.Interop.Multivendor.ImageCompressionControl*);
                    extensionPointer = (SharpVk.Interop.Multivendor.ImageCompressionControl*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ImageCompressionControl>());
                    imageCompressionControlExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.SwapchainCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SwapchainCreateInfo>());
                marshalledCreateInfo->SType = StructureType.SwapchainCreateInfo;
                marshalledCreateInfo->Next = vkSwapchainCreateInfoKHRNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Khronos.SwapchainCreateFlags);
                }
                marshalledCreateInfo->Surface = surface?.handle ?? default(SharpVk.Interop.Khronos.Surface);
                marshalledCreateInfo->MinImageCount = minImageCount;
                marshalledCreateInfo->ImageFormat = imageFormat;
                marshalledCreateInfo->ImageColorSpace = imageColorSpace;
                marshalledCreateInfo->ImageExtent = imageExtent;
                marshalledCreateInfo->ImageArrayLayers = imageArrayLayers;
                marshalledCreateInfo->ImageUsage = imageUsage;
                marshalledCreateInfo->ImageSharingMode = imageSharingMode;
                marshalledCreateInfo->QueueFamilyIndexCount = (uint)(Interop.HeapUtil.GetLength(queueFamilyIndices));
                if (queueFamilyIndices.IsNull())
                {
                    marshalledCreateInfo->QueueFamilyIndices = null;
                }
                else
                {
                    if (queueFamilyIndices.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfo->QueueFamilyIndices = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledCreateInfo->QueueFamilyIndices) = queueFamilyIndices.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(queueFamilyIndices.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(queueFamilyIndices.Value)); index++)
                        {
                            fieldPointer[index] = queueFamilyIndices.Value[index];
                        }
                        marshalledCreateInfo->QueueFamilyIndices = fieldPointer;
                    }
                }
                marshalledCreateInfo->PreTransform = preTransform;
                marshalledCreateInfo->CompositeAlpha = compositeAlpha;
                marshalledCreateInfo->PresentMode = presentMode;
                marshalledCreateInfo->Clipped = clipped;
                marshalledCreateInfo->OldSwapchain = oldSwapchain?.handle ?? default(SharpVk.Interop.Khronos.Swapchain);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkDeviceCreateSwapchainDelegate commandDelegate = commandCache.Cache.vkCreateSwapchainKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledSwapchain);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.Swapchain(extendedHandle, marshalledSwapchain);
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
        public static unsafe SharpVk.Khronos.DeviceGroupPresentCapabilities GetGroupPresentCapabilities(this SharpVk.Device extendedHandle)
        {
            try
            {
                SharpVk.Khronos.DeviceGroupPresentCapabilities result = default(SharpVk.Khronos.DeviceGroupPresentCapabilities);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.DeviceGroupPresentCapabilities marshalledDeviceGroupPresentCapabilities = default(SharpVk.Interop.Khronos.DeviceGroupPresentCapabilities);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkDeviceGetGroupPresentCapabilitiesDelegate commandDelegate = commandCache.Cache.vkGetDeviceGroupPresentCapabilitiesKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, &marshalledDeviceGroupPresentCapabilities);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Khronos.DeviceGroupPresentCapabilities.MarshalFrom(&marshalledDeviceGroupPresentCapabilities);
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
        /// <param name="surface">
        /// </param>
        public static unsafe SharpVk.Khronos.DeviceGroupPresentModeFlags GetGroupSurfacePresentModes(this SharpVk.Device extendedHandle, SharpVk.Khronos.Surface surface)
        {
            try
            {
                SharpVk.Khronos.DeviceGroupPresentModeFlags result = default(SharpVk.Khronos.DeviceGroupPresentModeFlags);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Khronos.DeviceGroupPresentModeFlags marshalledModes = default(SharpVk.Khronos.DeviceGroupPresentModeFlags);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkDeviceGetGroupSurfacePresentModesDelegate commandDelegate = commandCache.Cache.vkGetDeviceGroupSurfacePresentModesKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, surface?.handle ?? default(SharpVk.Interop.Khronos.Surface), &marshalledModes);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledModes;
                return result;
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// Retrieve the index of the next available presentable image.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="acquireInfo">
        /// </param>
        public static unsafe uint AcquireNextImage2(this SharpVk.Device extendedHandle, SharpVk.Khronos.AcquireNextImageInfo acquireInfo)
        {
            try
            {
                uint result = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.AcquireNextImageInfo* marshalledAcquireInfo = default(SharpVk.Interop.Khronos.AcquireNextImageInfo*);
                uint marshalledImageIndex = default(uint);
                commandCache = extendedHandle.commandCache;
                marshalledAcquireInfo = (SharpVk.Interop.Khronos.AcquireNextImageInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AcquireNextImageInfo>());
                acquireInfo.MarshalTo(marshalledAcquireInfo);
                SharpVk.Interop.Khronos.VkDeviceAcquireNextImage2Delegate commandDelegate = commandCache.Cache.vkAcquireNextImage2KHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledAcquireInfo, &marshalledImageIndex);
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
        /// Create multiple swapchains that share presentable images.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="createInfos">
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Khronos.Swapchain[] CreateSharedSwapchains(this SharpVk.Device extendedHandle, ArrayProxy<SharpVk.Khronos.SwapchainCreateInfo>? createInfos, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.Swapchain[] result = default(SharpVk.Khronos.Swapchain[]);
                CommandCache commandCache = default(CommandCache);
                uint marshalledSwapchainCount = default(uint);
                SharpVk.Interop.Khronos.SwapchainCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.Khronos.SwapchainCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.Swapchain* marshalledSwapchains = default(SharpVk.Interop.Khronos.Swapchain*);
                commandCache = extendedHandle.commandCache;
                marshalledSwapchainCount = (uint)(Interop.HeapUtil.GetLength(createInfos));
                if (createInfos.IsNull())
                {
                    marshalledCreateInfos = null;
                }
                else
                {
                    if (createInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos = (SharpVk.Interop.Khronos.SwapchainCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SwapchainCreateInfo>());
                        createInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Khronos.SwapchainCreateInfo*)(marshalledCreateInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.SwapchainCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.SwapchainCreateInfo>(Interop.HeapUtil.GetLength(createInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(createInfos.Value)); index++)
                        {
                            createInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfos = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                marshalledSwapchains = (SharpVk.Interop.Khronos.Swapchain*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Swapchain>(marshalledSwapchainCount));
                SharpVk.Interop.Khronos.VkDeviceCreateSharedSwapchainsDelegate commandDelegate = commandCache.Cache.vkCreateSharedSwapchainsKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledSwapchainCount, marshalledCreateInfos, marshalledAllocator, marshalledSwapchains);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledSwapchains != null)
                {
                    var fieldPointer = new SharpVk.Khronos.Swapchain[(uint)(marshalledSwapchainCount)];
                    for(int index = 0; index < (uint)(marshalledSwapchainCount); index++)
                    {
                        fieldPointer[index] = new SharpVk.Khronos.Swapchain(extendedHandle, marshalledSwapchains[index]);
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
        /// Create multiple swapchains that share presentable images.
        /// </summary>
        /// <param name="extendedHandle">
        /// The Device handle to extend.
        /// </param>
        /// <param name="flags">
        /// A bitmask indicating parameters of swapchain creation. Bits which
        /// can be set include: + --
        /// </param>
        /// <param name="surface">
        /// </param>
        /// <param name="minImageCount">
        /// </param>
        /// <param name="imageFormat">
        /// </param>
        /// <param name="imageColorSpace">
        /// </param>
        /// <param name="imageExtent">
        /// </param>
        /// <param name="imageArrayLayers">
        /// </param>
        /// <param name="imageUsage">
        /// </param>
        /// <param name="imageSharingMode">
        /// </param>
        /// <param name="queueFamilyIndices">
        /// </param>
        /// <param name="preTransform">
        /// </param>
        /// <param name="compositeAlpha">
        /// </param>
        /// <param name="presentMode">
        /// </param>
        /// <param name="clipped">
        /// </param>
        /// <param name="oldSwapchain">
        /// </param>
        /// <param name="swapchainCounterCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="deviceGroupSwapchainCreateInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="swapchainDisplayNativeHdrCreateInfoAmd">
        /// Extension struct
        /// </param>
        /// <param name="imageFormatListCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="surfaceFullScreenExclusiveInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="surfaceFullScreenExclusiveWin32InfoExt">
        /// Extension struct
        /// </param>
        /// <param name="swapchainPresentBarrierCreateInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="imageCompressionControlExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// An optional AllocationCallbacks instance that controls host memory
        /// allocation.
        /// </param>
        public static unsafe SharpVk.Khronos.Swapchain CreateSharedSwapchain(this SharpVk.Device extendedHandle, SharpVk.Khronos.Surface surface, uint minImageCount, SharpVk.Format imageFormat, SharpVk.Khronos.ColorSpace imageColorSpace, SharpVk.Extent2D imageExtent, uint imageArrayLayers, SharpVk.ImageUsageFlags imageUsage, SharpVk.SharingMode imageSharingMode, ArrayProxy<uint>? queueFamilyIndices, SharpVk.Khronos.SurfaceTransformFlags preTransform, SharpVk.Khronos.CompositeAlphaFlags compositeAlpha, SharpVk.Khronos.PresentMode presentMode, bool clipped, SharpVk.Khronos.Swapchain oldSwapchain, SharpVk.Khronos.SwapchainCreateFlags? flags = default(SharpVk.Khronos.SwapchainCreateFlags?), SharpVk.Multivendor.SwapchainCounterCreateInfo? swapchainCounterCreateInfoExt = null, SharpVk.Khronos.DeviceGroupSwapchainCreateInfo? deviceGroupSwapchainCreateInfoKhr = null, SharpVk.Amd.SwapchainDisplayNativeHdrCreateInfo? swapchainDisplayNativeHdrCreateInfoAmd = null, SharpVk.ImageFormatListCreateInfo? imageFormatListCreateInfo = null, SharpVk.Multivendor.SurfaceFullScreenExclusiveInfo? surfaceFullScreenExclusiveInfoExt = null, SharpVk.Multivendor.SurfaceFullScreenExclusiveWin32Info? surfaceFullScreenExclusiveWin32InfoExt = null, SharpVk.NVidia.SwapchainPresentBarrierCreateInfo? swapchainPresentBarrierCreateInfoNv = null, SharpVk.Multivendor.ImageCompressionControl? imageCompressionControlExt = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.Swapchain result = default(SharpVk.Khronos.Swapchain);
                CommandCache commandCache = default(CommandCache);
                uint marshalledSwapchainCount = default(uint);
                SharpVk.Interop.Khronos.SwapchainCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.Khronos.SwapchainCreateInfo*);
                void* vkSwapchainCreateInfoKHRNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.Swapchain* marshalledSwapchains = default(SharpVk.Interop.Khronos.Swapchain*);
                if (swapchainCounterCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.SwapchainCounterCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.SwapchainCounterCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.SwapchainCounterCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.SwapchainCounterCreateInfo>());
                    swapchainCounterCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (deviceGroupSwapchainCreateInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.DeviceGroupSwapchainCreateInfo* extensionPointer = default(SharpVk.Interop.Khronos.DeviceGroupSwapchainCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.DeviceGroupSwapchainCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DeviceGroupSwapchainCreateInfo>());
                    deviceGroupSwapchainCreateInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (swapchainDisplayNativeHdrCreateInfoAmd != null)
                {
                    SharpVk.Interop.Amd.SwapchainDisplayNativeHdrCreateInfo* extensionPointer = default(SharpVk.Interop.Amd.SwapchainDisplayNativeHdrCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Amd.SwapchainDisplayNativeHdrCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amd.SwapchainDisplayNativeHdrCreateInfo>());
                    swapchainDisplayNativeHdrCreateInfoAmd.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (imageFormatListCreateInfo != null)
                {
                    SharpVk.Interop.ImageFormatListCreateInfo* extensionPointer = default(SharpVk.Interop.ImageFormatListCreateInfo*);
                    extensionPointer = (SharpVk.Interop.ImageFormatListCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ImageFormatListCreateInfo>());
                    imageFormatListCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (surfaceFullScreenExclusiveInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveInfo* extensionPointer = default(SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveInfo>());
                    surfaceFullScreenExclusiveInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (surfaceFullScreenExclusiveWin32InfoExt != null)
                {
                    SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveWin32Info* extensionPointer = default(SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveWin32Info*);
                    extensionPointer = (SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveWin32Info*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.SurfaceFullScreenExclusiveWin32Info>());
                    surfaceFullScreenExclusiveWin32InfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (swapchainPresentBarrierCreateInfoNv != null)
                {
                    SharpVk.Interop.NVidia.SwapchainPresentBarrierCreateInfo* extensionPointer = default(SharpVk.Interop.NVidia.SwapchainPresentBarrierCreateInfo*);
                    extensionPointer = (SharpVk.Interop.NVidia.SwapchainPresentBarrierCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.SwapchainPresentBarrierCreateInfo>());
                    swapchainPresentBarrierCreateInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                if (imageCompressionControlExt != null)
                {
                    SharpVk.Interop.Multivendor.ImageCompressionControl* extensionPointer = default(SharpVk.Interop.Multivendor.ImageCompressionControl*);
                    extensionPointer = (SharpVk.Interop.Multivendor.ImageCompressionControl*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ImageCompressionControl>());
                    imageCompressionControlExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSwapchainCreateInfoKHRNextPointer;
                    vkSwapchainCreateInfoKHRNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledSwapchainCount = 1;
                marshalledCreateInfos = (SharpVk.Interop.Khronos.SwapchainCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SwapchainCreateInfo>());
                marshalledCreateInfos->SType = StructureType.SwapchainCreateInfo;
                marshalledCreateInfos->Next = vkSwapchainCreateInfoKHRNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfos->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfos->Flags = default(SharpVk.Khronos.SwapchainCreateFlags);
                }
                marshalledCreateInfos->Surface = surface?.handle ?? default(SharpVk.Interop.Khronos.Surface);
                marshalledCreateInfos->MinImageCount = minImageCount;
                marshalledCreateInfos->ImageFormat = imageFormat;
                marshalledCreateInfos->ImageColorSpace = imageColorSpace;
                marshalledCreateInfos->ImageExtent = imageExtent;
                marshalledCreateInfos->ImageArrayLayers = imageArrayLayers;
                marshalledCreateInfos->ImageUsage = imageUsage;
                marshalledCreateInfos->ImageSharingMode = imageSharingMode;
                marshalledCreateInfos->QueueFamilyIndexCount = (uint)(Interop.HeapUtil.GetLength(queueFamilyIndices));
                if (queueFamilyIndices.IsNull())
                {
                    marshalledCreateInfos->QueueFamilyIndices = null;
                }
                else
                {
                    if (queueFamilyIndices.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos->QueueFamilyIndices = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledCreateInfos->QueueFamilyIndices) = queueFamilyIndices.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(queueFamilyIndices.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(queueFamilyIndices.Value)); index++)
                        {
                            fieldPointer[index] = queueFamilyIndices.Value[index];
                        }
                        marshalledCreateInfos->QueueFamilyIndices = fieldPointer;
                    }
                }
                marshalledCreateInfos->PreTransform = preTransform;
                marshalledCreateInfos->CompositeAlpha = compositeAlpha;
                marshalledCreateInfos->PresentMode = presentMode;
                marshalledCreateInfos->Clipped = clipped;
                marshalledCreateInfos->OldSwapchain = oldSwapchain?.handle ?? default(SharpVk.Interop.Khronos.Swapchain);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                marshalledSwapchains = (SharpVk.Interop.Khronos.Swapchain*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Swapchain>(1));
                SharpVk.Interop.Khronos.VkDeviceCreateSharedSwapchainsDelegate commandDelegate = commandCache.Cache.vkCreateSharedSwapchainsKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledSwapchainCount, marshalledCreateInfos, marshalledAllocator, marshalledSwapchains);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.Swapchain(extendedHandle, *marshalledSwapchains);
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
        /// <param name="queueFamilyIndex">
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="videoProfile">
        /// </param>
        /// <param name="pictureFormat">
        /// </param>
        /// <param name="maxCodedExtent">
        /// </param>
        /// <param name="referencePictureFormat">
        /// </param>
        /// <param name="maxDpbSlots">
        /// </param>
        /// <param name="maxActiveReferencePictures">
        /// </param>
        /// <param name="stdHeaderVersion">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Khronos.VideoSession CreateVideoSession(this SharpVk.Device extendedHandle, uint queueFamilyIndex, SharpVk.Khronos.VideoProfileInfo videoProfile, SharpVk.Format pictureFormat, SharpVk.Extent2D maxCodedExtent, SharpVk.Format referencePictureFormat, uint maxDpbSlots, uint maxActiveReferencePictures, SharpVk.ExtensionProperties stdHeaderVersion, SharpVk.Khronos.VideoSessionCreateFlags? flags = default(SharpVk.Khronos.VideoSessionCreateFlags?), SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.VideoSession result = default(SharpVk.Khronos.VideoSession);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.VideoSessionCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Khronos.VideoSessionCreateInfo*);
                void* vkVideoSessionCreateInfoKHRNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.VideoSession marshalledVideoSession = default(SharpVk.Interop.Khronos.VideoSession);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.VideoSessionCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoSessionCreateInfo>());
                marshalledCreateInfo->SType = StructureType.VideoSessionCreateInfo;
                marshalledCreateInfo->Next = vkVideoSessionCreateInfoKHRNextPointer;
                marshalledCreateInfo->QueueFamilyIndex = queueFamilyIndex;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Khronos.VideoSessionCreateFlags);
                }
                marshalledCreateInfo->VideoProfile = (SharpVk.Interop.Khronos.VideoProfileInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoProfileInfo>());
                videoProfile.MarshalTo(marshalledCreateInfo->VideoProfile);
                marshalledCreateInfo->PictureFormat = pictureFormat;
                marshalledCreateInfo->MaxCodedExtent = maxCodedExtent;
                marshalledCreateInfo->ReferencePictureFormat = referencePictureFormat;
                marshalledCreateInfo->MaxDpbSlots = maxDpbSlots;
                marshalledCreateInfo->MaxActiveReferencePictures = maxActiveReferencePictures;
                marshalledCreateInfo->StdHeaderVersion = (SharpVk.Interop.ExtensionProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ExtensionProperties>());
                stdHeaderVersion.MarshalTo(marshalledCreateInfo->StdHeaderVersion);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkDeviceCreateVideoSessionDelegate commandDelegate = commandCache.Cache.vkCreateVideoSessionKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledVideoSession);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.VideoSession(extendedHandle, marshalledVideoSession);
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
        /// <param name="flags">
        /// </param>
        /// <param name="videoSessionParametersTemplate">
        /// </param>
        /// <param name="videoSession">
        /// </param>
        /// <param name="videoDecodeH264SessionParametersCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="videoDecodeH265SessionParametersCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="videoEncodeH264SessionParametersCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="videoEncodeH265SessionParametersCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Khronos.VideoSessionParameters CreateVideoSessionParameters(this SharpVk.Device extendedHandle, SharpVk.Khronos.VideoSessionParameters videoSessionParametersTemplate, SharpVk.Khronos.VideoSession videoSession, SharpVk.Khronos.VideoSessionParametersCreateFlags? flags = default(SharpVk.Khronos.VideoSessionParametersCreateFlags?), SharpVk.Multivendor.VideoDecodeH264SessionParametersCreateInfo? videoDecodeH264SessionParametersCreateInfoExt = null, SharpVk.Multivendor.VideoDecodeH265SessionParametersCreateInfo? videoDecodeH265SessionParametersCreateInfoExt = null, SharpVk.Multivendor.VideoEncodeH264SessionParametersCreateInfo? videoEncodeH264SessionParametersCreateInfoExt = null, SharpVk.Multivendor.VideoEncodeH265SessionParametersCreateInfo? videoEncodeH265SessionParametersCreateInfoExt = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.VideoSessionParameters result = default(SharpVk.Khronos.VideoSessionParameters);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.VideoSessionParametersCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Khronos.VideoSessionParametersCreateInfo*);
                void* vkVideoSessionParametersCreateInfoKHRNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.VideoSessionParameters marshalledVideoSessionParameters = default(SharpVk.Interop.Khronos.VideoSessionParameters);
                if (videoDecodeH264SessionParametersCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.VideoDecodeH264SessionParametersCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.VideoDecodeH264SessionParametersCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.VideoDecodeH264SessionParametersCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.VideoDecodeH264SessionParametersCreateInfo>());
                    videoDecodeH264SessionParametersCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoSessionParametersCreateInfoKHRNextPointer;
                    vkVideoSessionParametersCreateInfoKHRNextPointer = extensionPointer;
                }
                if (videoDecodeH265SessionParametersCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.VideoDecodeH265SessionParametersCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.VideoDecodeH265SessionParametersCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.VideoDecodeH265SessionParametersCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.VideoDecodeH265SessionParametersCreateInfo>());
                    videoDecodeH265SessionParametersCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoSessionParametersCreateInfoKHRNextPointer;
                    vkVideoSessionParametersCreateInfoKHRNextPointer = extensionPointer;
                }
                if (videoEncodeH264SessionParametersCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.VideoEncodeH264SessionParametersCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.VideoEncodeH264SessionParametersCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.VideoEncodeH264SessionParametersCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.VideoEncodeH264SessionParametersCreateInfo>());
                    videoEncodeH264SessionParametersCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoSessionParametersCreateInfoKHRNextPointer;
                    vkVideoSessionParametersCreateInfoKHRNextPointer = extensionPointer;
                }
                if (videoEncodeH265SessionParametersCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.VideoEncodeH265SessionParametersCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.VideoEncodeH265SessionParametersCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.VideoEncodeH265SessionParametersCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.VideoEncodeH265SessionParametersCreateInfo>());
                    videoEncodeH265SessionParametersCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoSessionParametersCreateInfoKHRNextPointer;
                    vkVideoSessionParametersCreateInfoKHRNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.VideoSessionParametersCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoSessionParametersCreateInfo>());
                marshalledCreateInfo->SType = StructureType.VideoSessionParametersCreateInfo;
                marshalledCreateInfo->Next = vkVideoSessionParametersCreateInfoKHRNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfo->Flags = default(SharpVk.Khronos.VideoSessionParametersCreateFlags);
                }
                marshalledCreateInfo->VideoSessionParametersTemplate = videoSessionParametersTemplate?.handle ?? default(SharpVk.Interop.Khronos.VideoSessionParameters);
                marshalledCreateInfo->VideoSession = videoSession?.handle ?? default(SharpVk.Interop.Khronos.VideoSession);
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkDeviceCreateVideoSessionParametersDelegate commandDelegate = commandCache.Cache.vkCreateVideoSessionParametersKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledVideoSessionParameters);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.VideoSessionParameters(videoSession, marshalledVideoSessionParameters);
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
        /// <param name="getWin32HandleInfo">
        /// </param>
        public static unsafe IntPtr GetMemoryWin32Handle(this SharpVk.Device extendedHandle, SharpVk.Khronos.MemoryGetWin32HandleInfo getWin32HandleInfo)
        {
            try
            {
                IntPtr result = default(IntPtr);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.MemoryGetWin32HandleInfo* marshalledGetWin32HandleInfo = default(SharpVk.Interop.Khronos.MemoryGetWin32HandleInfo*);
                IntPtr marshalledHandle = default(IntPtr);
                commandCache = extendedHandle.commandCache;
                marshalledGetWin32HandleInfo = (SharpVk.Interop.Khronos.MemoryGetWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.MemoryGetWin32HandleInfo>());
                getWin32HandleInfo.MarshalTo(marshalledGetWin32HandleInfo);
                SharpVk.Interop.Khronos.VkDeviceGetMemoryWin32HandleDelegate commandDelegate = commandCache.Cache.vkGetMemoryWin32HandleKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledGetWin32HandleInfo, &marshalledHandle);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledHandle;
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
        /// <param name="handleType">
        /// </param>
        /// <param name="handle">
        /// </param>
        public static unsafe SharpVk.Khronos.MemoryWin32HandleProperties GetMemoryWin32HandleProperties(this SharpVk.Device extendedHandle, SharpVk.ExternalMemoryHandleTypeFlags handleType, IntPtr handle)
        {
            try
            {
                SharpVk.Khronos.MemoryWin32HandleProperties result = default(SharpVk.Khronos.MemoryWin32HandleProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.MemoryWin32HandleProperties marshalledMemoryWin32HandleProperties = default(SharpVk.Interop.Khronos.MemoryWin32HandleProperties);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkDeviceGetMemoryWin32HandlePropertiesDelegate commandDelegate = commandCache.Cache.vkGetMemoryWin32HandlePropertiesKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, handleType, handle, &marshalledMemoryWin32HandleProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Khronos.MemoryWin32HandleProperties.MarshalFrom(&marshalledMemoryWin32HandleProperties);
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
        /// <param name="getFileDescriptorInfo">
        /// </param>
        public static unsafe int GetMemoryFileDescriptor(this SharpVk.Device extendedHandle, SharpVk.Khronos.MemoryGetFileDescriptorInfo getFileDescriptorInfo)
        {
            try
            {
                int result = default(int);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.MemoryGetFileDescriptorInfo* marshalledGetFileDescriptorInfo = default(SharpVk.Interop.Khronos.MemoryGetFileDescriptorInfo*);
                int marshalledFileDescriptor = default(int);
                commandCache = extendedHandle.commandCache;
                marshalledGetFileDescriptorInfo = (SharpVk.Interop.Khronos.MemoryGetFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.MemoryGetFileDescriptorInfo>());
                getFileDescriptorInfo.MarshalTo(marshalledGetFileDescriptorInfo);
                SharpVk.Interop.Khronos.VkDeviceGetMemoryFileDescriptorDelegate commandDelegate = commandCache.Cache.vkGetMemoryFdKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledGetFileDescriptorInfo, &marshalledFileDescriptor);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledFileDescriptor;
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
        /// <param name="handleType">
        /// </param>
        /// <param name="fileDescriptor">
        /// </param>
        public static unsafe SharpVk.Khronos.MemoryFileDescriptorProperties GetMemoryFileDescriptorProperties(this SharpVk.Device extendedHandle, SharpVk.ExternalMemoryHandleTypeFlags handleType, int fileDescriptor)
        {
            try
            {
                SharpVk.Khronos.MemoryFileDescriptorProperties result = default(SharpVk.Khronos.MemoryFileDescriptorProperties);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.MemoryFileDescriptorProperties marshalledMemoryFileDescriptorProperties = default(SharpVk.Interop.Khronos.MemoryFileDescriptorProperties);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkDeviceGetMemoryFileDescriptorPropertiesDelegate commandDelegate = commandCache.Cache.vkGetMemoryFdPropertiesKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, handleType, fileDescriptor, &marshalledMemoryFileDescriptorProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = SharpVk.Khronos.MemoryFileDescriptorProperties.MarshalFrom(&marshalledMemoryFileDescriptorProperties);
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
        /// <param name="importSemaphoreWin32HandleInfo">
        /// </param>
        public static unsafe void ImportSemaphoreWin32Handle(this SharpVk.Device extendedHandle, SharpVk.Khronos.ImportSemaphoreWin32HandleInfo importSemaphoreWin32HandleInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.ImportSemaphoreWin32HandleInfo* marshalledImportSemaphoreWin32HandleInfo = default(SharpVk.Interop.Khronos.ImportSemaphoreWin32HandleInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledImportSemaphoreWin32HandleInfo = (SharpVk.Interop.Khronos.ImportSemaphoreWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportSemaphoreWin32HandleInfo>());
                importSemaphoreWin32HandleInfo.MarshalTo(marshalledImportSemaphoreWin32HandleInfo);
                SharpVk.Interop.Khronos.VkDeviceImportSemaphoreWin32HandleDelegate commandDelegate = commandCache.Cache.vkImportSemaphoreWin32HandleKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledImportSemaphoreWin32HandleInfo);
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
        /// <param name="getWin32HandleInfo">
        /// </param>
        public static unsafe IntPtr GetSemaphoreWin32Handle(this SharpVk.Device extendedHandle, SharpVk.Khronos.SemaphoreGetWin32HandleInfo getWin32HandleInfo)
        {
            try
            {
                IntPtr result = default(IntPtr);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.SemaphoreGetWin32HandleInfo* marshalledGetWin32HandleInfo = default(SharpVk.Interop.Khronos.SemaphoreGetWin32HandleInfo*);
                IntPtr marshalledHandle = default(IntPtr);
                commandCache = extendedHandle.commandCache;
                marshalledGetWin32HandleInfo = (SharpVk.Interop.Khronos.SemaphoreGetWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SemaphoreGetWin32HandleInfo>());
                getWin32HandleInfo.MarshalTo(marshalledGetWin32HandleInfo);
                SharpVk.Interop.Khronos.VkDeviceGetSemaphoreWin32HandleDelegate commandDelegate = commandCache.Cache.vkGetSemaphoreWin32HandleKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledGetWin32HandleInfo, &marshalledHandle);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledHandle;
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
        /// <param name="importSemaphoreFileDescriptorInfo">
        /// </param>
        public static unsafe void ImportSemaphoreFileDescriptor(this SharpVk.Device extendedHandle, SharpVk.Khronos.ImportSemaphoreFileDescriptorInfo importSemaphoreFileDescriptorInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.ImportSemaphoreFileDescriptorInfo* marshalledImportSemaphoreFileDescriptorInfo = default(SharpVk.Interop.Khronos.ImportSemaphoreFileDescriptorInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledImportSemaphoreFileDescriptorInfo = (SharpVk.Interop.Khronos.ImportSemaphoreFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportSemaphoreFileDescriptorInfo>());
                importSemaphoreFileDescriptorInfo.MarshalTo(marshalledImportSemaphoreFileDescriptorInfo);
                SharpVk.Interop.Khronos.VkDeviceImportSemaphoreFileDescriptorDelegate commandDelegate = commandCache.Cache.vkImportSemaphoreFdKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledImportSemaphoreFileDescriptorInfo);
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
        /// <param name="getFileDescriptorInfo">
        /// </param>
        public static unsafe int GetSemaphoreFileDescriptor(this SharpVk.Device extendedHandle, SharpVk.Khronos.SemaphoreGetFileDescriptorInfo getFileDescriptorInfo)
        {
            try
            {
                int result = default(int);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.SemaphoreGetFileDescriptorInfo* marshalledGetFileDescriptorInfo = default(SharpVk.Interop.Khronos.SemaphoreGetFileDescriptorInfo*);
                int marshalledFileDescriptor = default(int);
                commandCache = extendedHandle.commandCache;
                marshalledGetFileDescriptorInfo = (SharpVk.Interop.Khronos.SemaphoreGetFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SemaphoreGetFileDescriptorInfo>());
                getFileDescriptorInfo.MarshalTo(marshalledGetFileDescriptorInfo);
                SharpVk.Interop.Khronos.VkDeviceGetSemaphoreFileDescriptorDelegate commandDelegate = commandCache.Cache.vkGetSemaphoreFdKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledGetFileDescriptorInfo, &marshalledFileDescriptor);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledFileDescriptor;
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
        /// <param name="importFenceWin32HandleInfo">
        /// </param>
        public static unsafe void ImportFenceWin32Handle(this SharpVk.Device extendedHandle, SharpVk.Khronos.ImportFenceWin32HandleInfo importFenceWin32HandleInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.ImportFenceWin32HandleInfo* marshalledImportFenceWin32HandleInfo = default(SharpVk.Interop.Khronos.ImportFenceWin32HandleInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledImportFenceWin32HandleInfo = (SharpVk.Interop.Khronos.ImportFenceWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportFenceWin32HandleInfo>());
                importFenceWin32HandleInfo.MarshalTo(marshalledImportFenceWin32HandleInfo);
                SharpVk.Interop.Khronos.VkDeviceImportFenceWin32HandleDelegate commandDelegate = commandCache.Cache.vkImportFenceWin32HandleKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledImportFenceWin32HandleInfo);
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
        /// <param name="getWin32HandleInfo">
        /// </param>
        public static unsafe IntPtr GetFenceWin32Handle(this SharpVk.Device extendedHandle, SharpVk.Khronos.FenceGetWin32HandleInfo getWin32HandleInfo)
        {
            try
            {
                IntPtr result = default(IntPtr);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.FenceGetWin32HandleInfo* marshalledGetWin32HandleInfo = default(SharpVk.Interop.Khronos.FenceGetWin32HandleInfo*);
                IntPtr marshalledHandle = default(IntPtr);
                commandCache = extendedHandle.commandCache;
                marshalledGetWin32HandleInfo = (SharpVk.Interop.Khronos.FenceGetWin32HandleInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.FenceGetWin32HandleInfo>());
                getWin32HandleInfo.MarshalTo(marshalledGetWin32HandleInfo);
                SharpVk.Interop.Khronos.VkDeviceGetFenceWin32HandleDelegate commandDelegate = commandCache.Cache.vkGetFenceWin32HandleKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledGetWin32HandleInfo, &marshalledHandle);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledHandle;
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
        /// <param name="importFenceFileDescriptorInfo">
        /// </param>
        public static unsafe void ImportFenceFileDescriptor(this SharpVk.Device extendedHandle, SharpVk.Khronos.ImportFenceFileDescriptorInfo importFenceFileDescriptorInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.ImportFenceFileDescriptorInfo* marshalledImportFenceFileDescriptorInfo = default(SharpVk.Interop.Khronos.ImportFenceFileDescriptorInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledImportFenceFileDescriptorInfo = (SharpVk.Interop.Khronos.ImportFenceFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.ImportFenceFileDescriptorInfo>());
                importFenceFileDescriptorInfo.MarshalTo(marshalledImportFenceFileDescriptorInfo);
                SharpVk.Interop.Khronos.VkDeviceImportFenceFileDescriptorDelegate commandDelegate = commandCache.Cache.vkImportFenceFdKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledImportFenceFileDescriptorInfo);
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
        /// <param name="getFileDescriptorInfo">
        /// </param>
        public static unsafe int GetFenceFileDescriptor(this SharpVk.Device extendedHandle, SharpVk.Khronos.FenceGetFileDescriptorInfo getFileDescriptorInfo)
        {
            try
            {
                int result = default(int);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.FenceGetFileDescriptorInfo* marshalledGetFileDescriptorInfo = default(SharpVk.Interop.Khronos.FenceGetFileDescriptorInfo*);
                int marshalledFileDescriptor = default(int);
                commandCache = extendedHandle.commandCache;
                marshalledGetFileDescriptorInfo = (SharpVk.Interop.Khronos.FenceGetFileDescriptorInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.FenceGetFileDescriptorInfo>());
                getFileDescriptorInfo.MarshalTo(marshalledGetFileDescriptorInfo);
                SharpVk.Interop.Khronos.VkDeviceGetFenceFileDescriptorDelegate commandDelegate = commandCache.Cache.vkGetFenceFdKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledGetFileDescriptorInfo, &marshalledFileDescriptor);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = marshalledFileDescriptor;
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
        public static unsafe void AcquireProfilingLock(this SharpVk.Device extendedHandle, SharpVk.Khronos.AcquireProfilingLockInfo info)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.AcquireProfilingLockInfo* marshalledInfo = default(SharpVk.Interop.Khronos.AcquireProfilingLockInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Khronos.AcquireProfilingLockInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AcquireProfilingLockInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Khronos.VkDeviceAcquireProfilingLockDelegate commandDelegate = commandCache.Cache.vkAcquireProfilingLockKHR;
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
        public static unsafe void ReleaseProfilingLock(this SharpVk.Device extendedHandle)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkDeviceReleaseProfilingLockDelegate commandDelegate = commandCache.Cache.vkReleaseProfilingLockKHR;
                commandDelegate(extendedHandle.handle);
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
        /// <param name="createFlags">
        /// </param>
        /// <param name="buffer">
        /// </param>
        /// <param name="offset">
        /// </param>
        /// <param name="size">
        /// </param>
        /// <param name="type">
        /// </param>
        /// <param name="deviceAddress">
        /// </param>
        /// <param name="accelerationStructureMotionInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Khronos.AccelerationStructure CreateAccelerationStructure(this SharpVk.Device extendedHandle, SharpVk.Buffer buffer, ulong offset, ulong size, SharpVk.Khronos.AccelerationStructureType type, SharpVk.Khronos.AccelerationStructureCreateFlags? createFlags = default(SharpVk.Khronos.AccelerationStructureCreateFlags?), ulong? deviceAddress = default(ulong?), SharpVk.NVidia.AccelerationStructureMotionInfo? accelerationStructureMotionInfoNv = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.AccelerationStructure result = default(SharpVk.Khronos.AccelerationStructure);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.AccelerationStructureCreateInfo* marshalledCreateInfo = default(SharpVk.Interop.Khronos.AccelerationStructureCreateInfo*);
                void* vkAccelerationStructureCreateInfoKHRNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.AccelerationStructure marshalledAccelerationStructure = default(SharpVk.Interop.Khronos.AccelerationStructure);
                if (accelerationStructureMotionInfoNv != null)
                {
                    SharpVk.Interop.NVidia.AccelerationStructureMotionInfo* extensionPointer = default(SharpVk.Interop.NVidia.AccelerationStructureMotionInfo*);
                    extensionPointer = (SharpVk.Interop.NVidia.AccelerationStructureMotionInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.AccelerationStructureMotionInfo>());
                    accelerationStructureMotionInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkAccelerationStructureCreateInfoKHRNextPointer;
                    vkAccelerationStructureCreateInfoKHRNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfo = (SharpVk.Interop.Khronos.AccelerationStructureCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AccelerationStructureCreateInfo>());
                marshalledCreateInfo->SType = StructureType.AccelerationStructureCreateInfoKhr;
                marshalledCreateInfo->Next = vkAccelerationStructureCreateInfoKHRNextPointer;
                if (createFlags != null)
                {
                    marshalledCreateInfo->CreateFlags = createFlags.Value;
                }
                else
                {
                    marshalledCreateInfo->CreateFlags = default(SharpVk.Khronos.AccelerationStructureCreateFlags);
                }
                marshalledCreateInfo->Buffer = buffer?.handle ?? default(SharpVk.Interop.Buffer);
                marshalledCreateInfo->Offset = offset;
                marshalledCreateInfo->Size = size;
                marshalledCreateInfo->Type = type;
                if (deviceAddress != null)
                {
                    marshalledCreateInfo->DeviceAddress = deviceAddress.Value;
                }
                else
                {
                    marshalledCreateInfo->DeviceAddress = default(ulong);
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkDeviceCreateAccelerationStructureDelegate commandDelegate = commandCache.Cache.vkCreateAccelerationStructureKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledCreateInfo, marshalledAllocator, &marshalledAccelerationStructure);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.AccelerationStructure(extendedHandle, marshalledAccelerationStructure);
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
        /// <param name="accelerationStructures">
        /// </param>
        /// <param name="queryType">
        /// </param>
        /// <param name="data">
        /// </param>
        /// <param name="stride">
        /// </param>
        public static unsafe void WriteAccelerationStructuresProperties(this SharpVk.Device extendedHandle, ArrayProxy<SharpVk.Khronos.AccelerationStructure>? accelerationStructures, SharpVk.QueryType queryType, ArrayProxy<byte>? data, HostSize stride)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.AccelerationStructure* marshalledAccelerationStructures = default(SharpVk.Interop.Khronos.AccelerationStructure*);
                byte* marshalledData = default(byte*);
                commandCache = extendedHandle.commandCache;
                if (accelerationStructures.IsNull())
                {
                    marshalledAccelerationStructures = null;
                }
                else
                {
                    if (accelerationStructures.Value.Contents == ProxyContents.Single)
                    {
                        marshalledAccelerationStructures = (SharpVk.Interop.Khronos.AccelerationStructure*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AccelerationStructure>());
                        *(SharpVk.Interop.Khronos.AccelerationStructure*)(marshalledAccelerationStructures) = accelerationStructures.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.Khronos.AccelerationStructure);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.AccelerationStructure*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.AccelerationStructure>(Interop.HeapUtil.GetLength(accelerationStructures.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(accelerationStructures.Value)); index++)
                        {
                            fieldPointer[index] = accelerationStructures.Value[index]?.handle ?? default(SharpVk.Interop.Khronos.AccelerationStructure);
                        }
                        marshalledAccelerationStructures = fieldPointer;
                    }
                }
                if (data.IsNull())
                {
                    marshalledData = null;
                }
                else
                {
                    if (data.Value.Contents == ProxyContents.Single)
                    {
                        marshalledData = (byte*)(Interop.HeapUtil.Allocate<byte>());
                        *(byte*)(marshalledData) = data.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(Interop.HeapUtil.GetLength(data.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(data.Value)); index++)
                        {
                            fieldPointer[index] = data.Value[index];
                        }
                        marshalledData = fieldPointer;
                    }
                }
                SharpVk.Interop.Khronos.VkDeviceWriteAccelerationStructuresPropertiesDelegate commandDelegate = commandCache.Cache.vkWriteAccelerationStructuresPropertiesKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(accelerationStructures)), marshalledAccelerationStructures, queryType, (HostSize)(Interop.HeapUtil.GetLength(data)), marshalledData, stride);
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
        /// <param name="info">
        /// </param>
        public static unsafe SharpVk.DeviceAddress GetAccelerationStructureDeviceAddress(this SharpVk.Device extendedHandle, SharpVk.Khronos.AccelerationStructureDeviceAddressInfo info)
        {
            try
            {
                SharpVk.DeviceAddress result = default(SharpVk.DeviceAddress);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.AccelerationStructureDeviceAddressInfo* marshalledInfo = default(SharpVk.Interop.Khronos.AccelerationStructureDeviceAddressInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Khronos.AccelerationStructureDeviceAddressInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AccelerationStructureDeviceAddressInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Khronos.VkDeviceGetAccelerationStructureDeviceAddressDelegate commandDelegate = commandCache.Cache.vkGetAccelerationStructureDeviceAddressKHR;
                result = commandDelegate(extendedHandle.handle, marshalledInfo);
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
        /// <param name="versionInfo">
        /// </param>
        public static unsafe SharpVk.Khronos.AccelerationStructureCompatibility GetAccelerationStructureCompatibility(this SharpVk.Device extendedHandle, SharpVk.Khronos.AccelerationStructureVersionInfo versionInfo)
        {
            try
            {
                SharpVk.Khronos.AccelerationStructureCompatibility result = default(SharpVk.Khronos.AccelerationStructureCompatibility);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.AccelerationStructureVersionInfo* marshalledVersionInfo = default(SharpVk.Interop.Khronos.AccelerationStructureVersionInfo*);
                SharpVk.Khronos.AccelerationStructureCompatibility marshalledCompatibility = default(SharpVk.Khronos.AccelerationStructureCompatibility);
                commandCache = extendedHandle.commandCache;
                marshalledVersionInfo = (SharpVk.Interop.Khronos.AccelerationStructureVersionInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AccelerationStructureVersionInfo>());
                versionInfo.MarshalTo(marshalledVersionInfo);
                SharpVk.Interop.Khronos.VkDeviceGetAccelerationStructureCompatibilityDelegate commandDelegate = commandCache.Cache.vkGetDeviceAccelerationStructureCompatibilityKHR;
                commandDelegate(extendedHandle.handle, marshalledVersionInfo, &marshalledCompatibility);
                result = marshalledCompatibility;
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
        /// <param name="buildType">
        /// </param>
        /// <param name="buildInfo">
        /// </param>
        /// <param name="maxPrimitiveCounts">
        /// </param>
        public static unsafe SharpVk.Khronos.AccelerationStructureBuildSizesInfo GetAccelerationStructureBuildSizes(this SharpVk.Device extendedHandle, SharpVk.Khronos.AccelerationStructureBuildType buildType, SharpVk.Khronos.AccelerationStructureBuildGeometryInfo buildInfo, ArrayProxy<uint>? maxPrimitiveCounts = null)
        {
            try
            {
                SharpVk.Khronos.AccelerationStructureBuildSizesInfo result = default(SharpVk.Khronos.AccelerationStructureBuildSizesInfo);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo* marshalledBuildInfo = default(SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo*);
                uint* marshalledMaxPrimitiveCounts = default(uint*);
                SharpVk.Interop.Khronos.AccelerationStructureBuildSizesInfo marshalledSizeInfo = default(SharpVk.Interop.Khronos.AccelerationStructureBuildSizesInfo);
                marshalledSizeInfo.SType = StructureType.AccelerationStructureBuildSizesInfo;
                marshalledSizeInfo.Next = null;
                commandCache = extendedHandle.commandCache;
                marshalledBuildInfo = (SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo>());
                buildInfo.MarshalTo(marshalledBuildInfo);
                if (maxPrimitiveCounts.IsNull())
                {
                    marshalledMaxPrimitiveCounts = null;
                }
                else
                {
                    if (maxPrimitiveCounts.Value.Contents == ProxyContents.Single)
                    {
                        marshalledMaxPrimitiveCounts = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledMaxPrimitiveCounts) = maxPrimitiveCounts.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(maxPrimitiveCounts.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(maxPrimitiveCounts.Value)); index++)
                        {
                            fieldPointer[index] = maxPrimitiveCounts.Value[index];
                        }
                        marshalledMaxPrimitiveCounts = fieldPointer;
                    }
                }
                SharpVk.Interop.Khronos.VkDeviceGetAccelerationStructureBuildSizesDelegate commandDelegate = commandCache.Cache.vkGetAccelerationStructureBuildSizesKHR;
                commandDelegate(extendedHandle.handle, buildType, marshalledBuildInfo, marshalledMaxPrimitiveCounts, &marshalledSizeInfo);
                result = SharpVk.Khronos.AccelerationStructureBuildSizesInfo.MarshalFrom(&marshalledSizeInfo);
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
        /// <param name="deferredOperation">
        /// </param>
        /// <param name="pipelineCache">
        /// </param>
        /// <param name="createInfos">
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Pipeline[] CreateRayTracingPipelines(this SharpVk.Device extendedHandle, SharpVk.Khronos.DeferredOperation deferredOperation, SharpVk.PipelineCache pipelineCache, ArrayProxy<SharpVk.Khronos.RayTracingPipelineCreateInfo>? createInfos, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Pipeline[] result = default(SharpVk.Pipeline[]);
                CommandCache commandCache = default(CommandCache);
                uint marshalledCreateInfoCount = default(uint);
                SharpVk.Interop.Khronos.RayTracingPipelineCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.Khronos.RayTracingPipelineCreateInfo*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Pipeline* marshalledPipelines = default(SharpVk.Interop.Pipeline*);
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfoCount = (uint)(Interop.HeapUtil.GetLength(createInfos));
                if (createInfos.IsNull())
                {
                    marshalledCreateInfos = null;
                }
                else
                {
                    if (createInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos = (SharpVk.Interop.Khronos.RayTracingPipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.RayTracingPipelineCreateInfo>());
                        createInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Khronos.RayTracingPipelineCreateInfo*)(marshalledCreateInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.RayTracingPipelineCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.RayTracingPipelineCreateInfo>(Interop.HeapUtil.GetLength(createInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(createInfos.Value)); index++)
                        {
                            createInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfos = fieldPointer;
                    }
                }
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                marshalledPipelines = (SharpVk.Interop.Pipeline*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Pipeline>(marshalledCreateInfoCount));
                SharpVk.Interop.Khronos.VkDeviceCreateRayTracingPipelinesDelegate commandDelegate = commandCache.Cache.vkCreateRayTracingPipelinesKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, deferredOperation?.handle ?? default(SharpVk.Interop.Khronos.DeferredOperation), pipelineCache?.handle ?? default(SharpVk.Interop.PipelineCache), marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                if (marshalledPipelines != null)
                {
                    var fieldPointer = new SharpVk.Pipeline[(uint)(marshalledCreateInfoCount)];
                    for(int index = 0; index < (uint)(marshalledCreateInfoCount); index++)
                    {
                        fieldPointer[index] = new SharpVk.Pipeline(extendedHandle, marshalledPipelines[index]);
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="deferredOperation">
        /// </param>
        /// <param name="pipelineCache">
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="stages">
        /// </param>
        /// <param name="groups">
        /// </param>
        /// <param name="maxPipelineRayRecursionDepth">
        /// </param>
        /// <param name="libraryInfo">
        /// </param>
        /// <param name="libraryInterface">
        /// </param>
        /// <param name="dynamicState">
        /// </param>
        /// <param name="layout">
        /// </param>
        /// <param name="basePipelineHandle">
        /// </param>
        /// <param name="basePipelineIndex">
        /// </param>
        /// <param name="pipelineCreationFeedbackCreateInfo">
        /// Extension struct
        /// </param>
        /// <param name="pipelineRobustnessCreateInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Pipeline CreateRayTracingPipeline(this SharpVk.Device extendedHandle, SharpVk.Khronos.DeferredOperation deferredOperation, SharpVk.PipelineCache pipelineCache, ArrayProxy<SharpVk.PipelineShaderStageCreateInfo>? stages, ArrayProxy<SharpVk.Khronos.RayTracingShaderGroupCreateInfo>? groups, uint maxPipelineRayRecursionDepth, SharpVk.PipelineLayout layout, SharpVk.Pipeline basePipelineHandle, int basePipelineIndex, SharpVk.PipelineCreateFlags? flags = default(SharpVk.PipelineCreateFlags?), SharpVk.Khronos.PipelineLibraryCreateInfo? libraryInfo = default(SharpVk.Khronos.PipelineLibraryCreateInfo?), SharpVk.Khronos.RayTracingPipelineInterfaceCreateInfo? libraryInterface = default(SharpVk.Khronos.RayTracingPipelineInterfaceCreateInfo?), SharpVk.PipelineDynamicStateCreateInfo? dynamicState = default(SharpVk.PipelineDynamicStateCreateInfo?), SharpVk.PipelineCreationFeedbackCreateInfo? pipelineCreationFeedbackCreateInfo = null, SharpVk.Multivendor.PipelineRobustnessCreateInfo? pipelineRobustnessCreateInfoExt = null, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Pipeline result = default(SharpVk.Pipeline);
                CommandCache commandCache = default(CommandCache);
                uint marshalledCreateInfoCount = default(uint);
                SharpVk.Interop.Khronos.RayTracingPipelineCreateInfo* marshalledCreateInfos = default(SharpVk.Interop.Khronos.RayTracingPipelineCreateInfo*);
                void* vkRayTracingPipelineCreateInfoKHRNextPointer = default(void*);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Pipeline* marshalledPipelines = default(SharpVk.Interop.Pipeline*);
                if (pipelineCreationFeedbackCreateInfo != null)
                {
                    SharpVk.Interop.PipelineCreationFeedbackCreateInfo* extensionPointer = default(SharpVk.Interop.PipelineCreationFeedbackCreateInfo*);
                    extensionPointer = (SharpVk.Interop.PipelineCreationFeedbackCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineCreationFeedbackCreateInfo>());
                    pipelineCreationFeedbackCreateInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRayTracingPipelineCreateInfoKHRNextPointer;
                    vkRayTracingPipelineCreateInfoKHRNextPointer = extensionPointer;
                }
                if (pipelineRobustnessCreateInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.PipelineRobustnessCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.PipelineRobustnessCreateInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PipelineRobustnessCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PipelineRobustnessCreateInfo>());
                    pipelineRobustnessCreateInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkRayTracingPipelineCreateInfoKHRNextPointer;
                    vkRayTracingPipelineCreateInfoKHRNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledCreateInfoCount = 1;
                marshalledCreateInfos = (SharpVk.Interop.Khronos.RayTracingPipelineCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.RayTracingPipelineCreateInfo>());
                marshalledCreateInfos->SType = StructureType.RayTracingPipelineCreateInfoKhr;
                marshalledCreateInfos->Next = vkRayTracingPipelineCreateInfoKHRNextPointer;
                if (flags != null)
                {
                    marshalledCreateInfos->Flags = flags.Value;
                }
                else
                {
                    marshalledCreateInfos->Flags = default(SharpVk.PipelineCreateFlags);
                }
                marshalledCreateInfos->StageCount = (uint)(Interop.HeapUtil.GetLength(stages));
                if (stages.IsNull())
                {
                    marshalledCreateInfos->Stages = null;
                }
                else
                {
                    if (stages.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos->Stages = (SharpVk.Interop.PipelineShaderStageCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineShaderStageCreateInfo>());
                        stages.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.PipelineShaderStageCreateInfo*)(marshalledCreateInfos->Stages));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.PipelineShaderStageCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.PipelineShaderStageCreateInfo>(Interop.HeapUtil.GetLength(stages.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(stages.Value)); index++)
                        {
                            stages.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfos->Stages = fieldPointer;
                    }
                }
                marshalledCreateInfos->GroupCount = (uint)(Interop.HeapUtil.GetLength(groups));
                if (groups.IsNull())
                {
                    marshalledCreateInfos->Groups = null;
                }
                else
                {
                    if (groups.Value.Contents == ProxyContents.Single)
                    {
                        marshalledCreateInfos->Groups = (SharpVk.Interop.Khronos.RayTracingShaderGroupCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.RayTracingShaderGroupCreateInfo>());
                        groups.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Khronos.RayTracingShaderGroupCreateInfo*)(marshalledCreateInfos->Groups));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.RayTracingShaderGroupCreateInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.RayTracingShaderGroupCreateInfo>(Interop.HeapUtil.GetLength(groups.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(groups.Value)); index++)
                        {
                            groups.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledCreateInfos->Groups = fieldPointer;
                    }
                }
                marshalledCreateInfos->MaxPipelineRayRecursionDepth = maxPipelineRayRecursionDepth;
                if (libraryInfo != null)
                {
                    marshalledCreateInfos->LibraryInfo = (SharpVk.Interop.Khronos.PipelineLibraryCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PipelineLibraryCreateInfo>());
                    libraryInfo.Value.MarshalTo(marshalledCreateInfos->LibraryInfo);
                }
                else
                {
                    marshalledCreateInfos->LibraryInfo = default(SharpVk.Interop.Khronos.PipelineLibraryCreateInfo*);
                }
                if (libraryInterface != null)
                {
                    marshalledCreateInfos->LibraryInterface = (SharpVk.Interop.Khronos.RayTracingPipelineInterfaceCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.RayTracingPipelineInterfaceCreateInfo>());
                    libraryInterface.Value.MarshalTo(marshalledCreateInfos->LibraryInterface);
                }
                else
                {
                    marshalledCreateInfos->LibraryInterface = default(SharpVk.Interop.Khronos.RayTracingPipelineInterfaceCreateInfo*);
                }
                if (dynamicState != null)
                {
                    marshalledCreateInfos->DynamicState = (SharpVk.Interop.PipelineDynamicStateCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.PipelineDynamicStateCreateInfo>());
                    dynamicState.Value.MarshalTo(marshalledCreateInfos->DynamicState);
                }
                else
                {
                    marshalledCreateInfos->DynamicState = default(SharpVk.Interop.PipelineDynamicStateCreateInfo*);
                }
                marshalledCreateInfos->Layout = layout?.handle ?? default(SharpVk.Interop.PipelineLayout);
                marshalledCreateInfos->BasePipelineHandle = basePipelineHandle?.handle ?? default(SharpVk.Interop.Pipeline);
                marshalledCreateInfos->BasePipelineIndex = basePipelineIndex;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                marshalledPipelines = (SharpVk.Interop.Pipeline*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Pipeline>(1));
                SharpVk.Interop.Khronos.VkDeviceCreateRayTracingPipelinesDelegate commandDelegate = commandCache.Cache.vkCreateRayTracingPipelinesKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, deferredOperation?.handle ?? default(SharpVk.Interop.Khronos.DeferredOperation), pipelineCache?.handle ?? default(SharpVk.Interop.PipelineCache), marshalledCreateInfoCount, marshalledCreateInfos, marshalledAllocator, marshalledPipelines);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Pipeline(extendedHandle, *marshalledPipelines);
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
        /// <param name="allocator">
        /// </param>
        public static unsafe SharpVk.Khronos.DeferredOperation CreateDeferredOperation(this SharpVk.Device extendedHandle, SharpVk.AllocationCallbacks? allocator = default(SharpVk.AllocationCallbacks?))
        {
            try
            {
                SharpVk.Khronos.DeferredOperation result = default(SharpVk.Khronos.DeferredOperation);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.AllocationCallbacks* marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                SharpVk.Interop.Khronos.DeferredOperation marshalledDeferredOperation = default(SharpVk.Interop.Khronos.DeferredOperation);
                commandCache = extendedHandle.commandCache;
                if (allocator != null)
                {
                    marshalledAllocator = (SharpVk.Interop.AllocationCallbacks*)(Interop.HeapUtil.Allocate<SharpVk.Interop.AllocationCallbacks>());
                    allocator.Value.MarshalTo(marshalledAllocator);
                }
                else
                {
                    marshalledAllocator = default(SharpVk.Interop.AllocationCallbacks*);
                }
                SharpVk.Interop.Khronos.VkDeviceCreateDeferredOperationDelegate commandDelegate = commandCache.Cache.vkCreateDeferredOperationKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledAllocator, &marshalledDeferredOperation);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                result = new SharpVk.Khronos.DeferredOperation(extendedHandle, marshalledDeferredOperation);
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
        /// <param name="pipelineInfo">
        /// </param>
        public static unsafe SharpVk.Khronos.PipelineExecutableProperties[] GetPipelineExecutableProperties(this SharpVk.Device extendedHandle, SharpVk.Khronos.PipelineInfo pipelineInfo)
        {
            try
            {
                SharpVk.Khronos.PipelineExecutableProperties[] result = default(SharpVk.Khronos.PipelineExecutableProperties[]);
                uint marshalledExecutableCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.PipelineInfo* marshalledPipelineInfo = default(SharpVk.Interop.Khronos.PipelineInfo*);
                SharpVk.Interop.Khronos.PipelineExecutableProperties* marshalledProperties = default(SharpVk.Interop.Khronos.PipelineExecutableProperties*);
                commandCache = extendedHandle.commandCache;
                marshalledPipelineInfo = (SharpVk.Interop.Khronos.PipelineInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PipelineInfo>());
                pipelineInfo.MarshalTo(marshalledPipelineInfo);
                SharpVk.Interop.Khronos.VkDeviceGetPipelineExecutablePropertiesDelegate commandDelegate = commandCache.Cache.vkGetPipelineExecutablePropertiesKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledPipelineInfo, &marshalledExecutableCount, marshalledProperties);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledProperties = (SharpVk.Interop.Khronos.PipelineExecutableProperties*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PipelineExecutableProperties>((uint)(marshalledExecutableCount)));
                commandDelegate(extendedHandle.handle, marshalledPipelineInfo, &marshalledExecutableCount, marshalledProperties);
                if (marshalledProperties != null)
                {
                    var fieldPointer = new SharpVk.Khronos.PipelineExecutableProperties[(uint)(marshalledExecutableCount)];
                    for(int index = 0; index < (uint)(marshalledExecutableCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Khronos.PipelineExecutableProperties.MarshalFrom(&marshalledProperties[index]);
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="executableInfo">
        /// </param>
        public static unsafe SharpVk.Khronos.PipelineExecutableStatistic[] GetPipelineExecutableStatistics(this SharpVk.Device extendedHandle, SharpVk.Khronos.PipelineExecutableInfo executableInfo)
        {
            try
            {
                SharpVk.Khronos.PipelineExecutableStatistic[] result = default(SharpVk.Khronos.PipelineExecutableStatistic[]);
                uint marshalledStatisticCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.PipelineExecutableInfo* marshalledExecutableInfo = default(SharpVk.Interop.Khronos.PipelineExecutableInfo*);
                SharpVk.Interop.Khronos.PipelineExecutableStatistic* marshalledStatistics = default(SharpVk.Interop.Khronos.PipelineExecutableStatistic*);
                commandCache = extendedHandle.commandCache;
                marshalledExecutableInfo = (SharpVk.Interop.Khronos.PipelineExecutableInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PipelineExecutableInfo>());
                executableInfo.MarshalTo(marshalledExecutableInfo);
                SharpVk.Interop.Khronos.VkDeviceGetPipelineExecutableStatisticsDelegate commandDelegate = commandCache.Cache.vkGetPipelineExecutableStatisticsKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledExecutableInfo, &marshalledStatisticCount, marshalledStatistics);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledStatistics = (SharpVk.Interop.Khronos.PipelineExecutableStatistic*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PipelineExecutableStatistic>((uint)(marshalledStatisticCount)));
                commandDelegate(extendedHandle.handle, marshalledExecutableInfo, &marshalledStatisticCount, marshalledStatistics);
                if (marshalledStatistics != null)
                {
                    var fieldPointer = new SharpVk.Khronos.PipelineExecutableStatistic[(uint)(marshalledStatisticCount)];
                    for(int index = 0; index < (uint)(marshalledStatisticCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Khronos.PipelineExecutableStatistic.MarshalFrom(&marshalledStatistics[index]);
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
        /// The Device handle to extend.
        /// </param>
        /// <param name="executableInfo">
        /// </param>
        public static unsafe SharpVk.Khronos.PipelineExecutableInternalRepresentation[] GetPipelineExecutableInternalRepresentations(this SharpVk.Device extendedHandle, SharpVk.Khronos.PipelineExecutableInfo executableInfo)
        {
            try
            {
                SharpVk.Khronos.PipelineExecutableInternalRepresentation[] result = default(SharpVk.Khronos.PipelineExecutableInternalRepresentation[]);
                uint marshalledInternalRepresentationCount = default(uint);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.PipelineExecutableInfo* marshalledExecutableInfo = default(SharpVk.Interop.Khronos.PipelineExecutableInfo*);
                SharpVk.Interop.Khronos.PipelineExecutableInternalRepresentation* marshalledInternalRepresentations = default(SharpVk.Interop.Khronos.PipelineExecutableInternalRepresentation*);
                commandCache = extendedHandle.commandCache;
                marshalledExecutableInfo = (SharpVk.Interop.Khronos.PipelineExecutableInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PipelineExecutableInfo>());
                executableInfo.MarshalTo(marshalledExecutableInfo);
                SharpVk.Interop.Khronos.VkDeviceGetPipelineExecutableInternalRepresentationsDelegate commandDelegate = commandCache.Cache.vkGetPipelineExecutableInternalRepresentationsKHR;
                Result methodResult = commandDelegate(extendedHandle.handle, marshalledExecutableInfo, &marshalledInternalRepresentationCount, marshalledInternalRepresentations);
                if (SharpVkException.IsError(methodResult))
                {
                    throw SharpVkException.Create(methodResult);
                }
                marshalledInternalRepresentations = (SharpVk.Interop.Khronos.PipelineExecutableInternalRepresentation*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PipelineExecutableInternalRepresentation>((uint)(marshalledInternalRepresentationCount)));
                commandDelegate(extendedHandle.handle, marshalledExecutableInfo, &marshalledInternalRepresentationCount, marshalledInternalRepresentations);
                if (marshalledInternalRepresentations != null)
                {
                    var fieldPointer = new SharpVk.Khronos.PipelineExecutableInternalRepresentation[(uint)(marshalledInternalRepresentationCount)];
                    for(int index = 0; index < (uint)(marshalledInternalRepresentationCount); index++)
                    {
                        fieldPointer[index] = SharpVk.Khronos.PipelineExecutableInternalRepresentation.MarshalFrom(&marshalledInternalRepresentations[index]);
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
