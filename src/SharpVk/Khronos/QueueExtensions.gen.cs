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
    public static class QueueExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The Queue handle to extend.
        /// </param>
        /// <param name="waitSemaphores">
        /// </param>
        /// <param name="swapchains">
        /// </param>
        /// <param name="imageIndices">
        /// </param>
        /// <param name="results">
        /// </param>
        /// <param name="displayPresentInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="presentRegionsKhr">
        /// Extension struct
        /// </param>
        /// <param name="deviceGroupPresentInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="presentIdKhr">
        /// Extension struct
        /// </param>
        /// <param name="presentId2Khr">
        /// Extension struct
        /// </param>
        /// <param name="presentTimingsInfoExt">
        /// Extension struct
        /// </param>
        /// <param name="presentTimesInfoGoogle">
        /// Extension struct
        /// </param>
        /// <param name="presentFrameTokenGgp">
        /// Extension struct
        /// </param>
        /// <param name="frameBoundaryExt">
        /// Extension struct
        /// </param>
        /// <param name="swapchainPresentFenceInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="swapchainPresentModeInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="setPresentConfigNv">
        /// Extension struct
        /// </param>
        /// <param name="frameBoundaryTensorsArm">
        /// Extension struct
        /// </param>
        public static unsafe Result Present(this SharpVk.Queue extendedHandle, ArrayProxy<SharpVk.Semaphore>? waitSemaphores, ArrayProxy<SharpVk.Khronos.Swapchain>? swapchains, ArrayProxy<uint>? imageIndices, ArrayProxy<SharpVk.Result>? results = null, SharpVk.Khronos.DisplayPresentInfo? displayPresentInfoKhr = null, SharpVk.Khronos.PresentRegions? presentRegionsKhr = null, SharpVk.Khronos.DeviceGroupPresentInfo? deviceGroupPresentInfoKhr = null, SharpVk.Khronos.PresentId? presentIdKhr = null, SharpVk.Khronos.PresentId2? presentId2Khr = null, SharpVk.Multivendor.PresentTimingsInfo? presentTimingsInfoExt = null, SharpVk.Google.PresentTimesInfo? presentTimesInfoGoogle = null, SharpVk.Ggp.PresentFrameToken? presentFrameTokenGgp = null, SharpVk.Multivendor.FrameBoundary? frameBoundaryExt = null, SharpVk.Khronos.SwapchainPresentFenceInfo? swapchainPresentFenceInfoKhr = null, SharpVk.Khronos.SwapchainPresentModeInfo? swapchainPresentModeInfoKhr = null, SharpVk.NVidia.SetPresentConfig? setPresentConfigNv = null, SharpVk.Arm.FrameBoundaryTensors? frameBoundaryTensorsArm = null)
        {
            try
            {
                Result result = default(Result);
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.PresentInfo* marshalledPresentInfo = default(SharpVk.Interop.Khronos.PresentInfo*);
                void* vkPresentInfoKHRNextPointer = default(void*);
                if (displayPresentInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.DisplayPresentInfo* extensionPointer = default(SharpVk.Interop.Khronos.DisplayPresentInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.DisplayPresentInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DisplayPresentInfo>());
                    displayPresentInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkPresentInfoKHRNextPointer;
                    vkPresentInfoKHRNextPointer = extensionPointer;
                }
                if (presentRegionsKhr != null)
                {
                    SharpVk.Interop.Khronos.PresentRegions* extensionPointer = default(SharpVk.Interop.Khronos.PresentRegions*);
                    extensionPointer = (SharpVk.Interop.Khronos.PresentRegions*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PresentRegions>());
                    presentRegionsKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkPresentInfoKHRNextPointer;
                    vkPresentInfoKHRNextPointer = extensionPointer;
                }
                if (deviceGroupPresentInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.DeviceGroupPresentInfo* extensionPointer = default(SharpVk.Interop.Khronos.DeviceGroupPresentInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.DeviceGroupPresentInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.DeviceGroupPresentInfo>());
                    deviceGroupPresentInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkPresentInfoKHRNextPointer;
                    vkPresentInfoKHRNextPointer = extensionPointer;
                }
                if (presentIdKhr != null)
                {
                    SharpVk.Interop.Khronos.PresentId* extensionPointer = default(SharpVk.Interop.Khronos.PresentId*);
                    extensionPointer = (SharpVk.Interop.Khronos.PresentId*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PresentId>());
                    presentIdKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkPresentInfoKHRNextPointer;
                    vkPresentInfoKHRNextPointer = extensionPointer;
                }
                if (presentId2Khr != null)
                {
                    SharpVk.Interop.Khronos.PresentId2* extensionPointer = default(SharpVk.Interop.Khronos.PresentId2*);
                    extensionPointer = (SharpVk.Interop.Khronos.PresentId2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PresentId2>());
                    presentId2Khr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkPresentInfoKHRNextPointer;
                    vkPresentInfoKHRNextPointer = extensionPointer;
                }
                if (presentTimingsInfoExt != null)
                {
                    SharpVk.Interop.Multivendor.PresentTimingsInfo* extensionPointer = default(SharpVk.Interop.Multivendor.PresentTimingsInfo*);
                    extensionPointer = (SharpVk.Interop.Multivendor.PresentTimingsInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.PresentTimingsInfo>());
                    presentTimingsInfoExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkPresentInfoKHRNextPointer;
                    vkPresentInfoKHRNextPointer = extensionPointer;
                }
                if (presentTimesInfoGoogle != null)
                {
                    SharpVk.Interop.Google.PresentTimesInfo* extensionPointer = default(SharpVk.Interop.Google.PresentTimesInfo*);
                    extensionPointer = (SharpVk.Interop.Google.PresentTimesInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Google.PresentTimesInfo>());
                    presentTimesInfoGoogle.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkPresentInfoKHRNextPointer;
                    vkPresentInfoKHRNextPointer = extensionPointer;
                }
                if (presentFrameTokenGgp != null)
                {
                    SharpVk.Interop.Ggp.PresentFrameToken* extensionPointer = default(SharpVk.Interop.Ggp.PresentFrameToken*);
                    extensionPointer = (SharpVk.Interop.Ggp.PresentFrameToken*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Ggp.PresentFrameToken>());
                    presentFrameTokenGgp.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkPresentInfoKHRNextPointer;
                    vkPresentInfoKHRNextPointer = extensionPointer;
                }
                if (frameBoundaryExt != null)
                {
                    SharpVk.Interop.Multivendor.FrameBoundary* extensionPointer = default(SharpVk.Interop.Multivendor.FrameBoundary*);
                    extensionPointer = (SharpVk.Interop.Multivendor.FrameBoundary*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.FrameBoundary>());
                    frameBoundaryExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkPresentInfoKHRNextPointer;
                    vkPresentInfoKHRNextPointer = extensionPointer;
                }
                if (swapchainPresentFenceInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.SwapchainPresentFenceInfo* extensionPointer = default(SharpVk.Interop.Khronos.SwapchainPresentFenceInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.SwapchainPresentFenceInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SwapchainPresentFenceInfo>());
                    swapchainPresentFenceInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkPresentInfoKHRNextPointer;
                    vkPresentInfoKHRNextPointer = extensionPointer;
                }
                if (swapchainPresentModeInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.SwapchainPresentModeInfo* extensionPointer = default(SharpVk.Interop.Khronos.SwapchainPresentModeInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.SwapchainPresentModeInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.SwapchainPresentModeInfo>());
                    swapchainPresentModeInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkPresentInfoKHRNextPointer;
                    vkPresentInfoKHRNextPointer = extensionPointer;
                }
                if (setPresentConfigNv != null)
                {
                    SharpVk.Interop.NVidia.SetPresentConfig* extensionPointer = default(SharpVk.Interop.NVidia.SetPresentConfig*);
                    extensionPointer = (SharpVk.Interop.NVidia.SetPresentConfig*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.SetPresentConfig>());
                    setPresentConfigNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkPresentInfoKHRNextPointer;
                    vkPresentInfoKHRNextPointer = extensionPointer;
                }
                if (frameBoundaryTensorsArm != null)
                {
                    SharpVk.Interop.Arm.FrameBoundaryTensors* extensionPointer = default(SharpVk.Interop.Arm.FrameBoundaryTensors*);
                    extensionPointer = (SharpVk.Interop.Arm.FrameBoundaryTensors*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.FrameBoundaryTensors>());
                    frameBoundaryTensorsArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkPresentInfoKHRNextPointer;
                    vkPresentInfoKHRNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledPresentInfo = (SharpVk.Interop.Khronos.PresentInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PresentInfo>());
                marshalledPresentInfo->SType = StructureType.PresentInfo;
                marshalledPresentInfo->Next = vkPresentInfoKHRNextPointer;
                marshalledPresentInfo->WaitSemaphoreCount = (uint)(Interop.HeapUtil.GetLength(waitSemaphores));
                if (waitSemaphores.IsNull())
                {
                    marshalledPresentInfo->WaitSemaphores = null;
                }
                else
                {
                    if (waitSemaphores.Value.Contents == ProxyContents.Single)
                    {
                        marshalledPresentInfo->WaitSemaphores = (SharpVk.Interop.Semaphore*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Semaphore>());
                        *(SharpVk.Interop.Semaphore*)(marshalledPresentInfo->WaitSemaphores) = waitSemaphores.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.Semaphore);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Semaphore*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Semaphore>(Interop.HeapUtil.GetLength(waitSemaphores.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(waitSemaphores.Value)); index++)
                        {
                            fieldPointer[index] = waitSemaphores.Value[index]?.handle ?? default(SharpVk.Interop.Semaphore);
                        }
                        marshalledPresentInfo->WaitSemaphores = fieldPointer;
                    }
                }
                marshalledPresentInfo->SwapchainCount = (uint)(Interop.HeapUtil.GetLength(swapchains));
                if (swapchains.IsNull())
                {
                    marshalledPresentInfo->Swapchains = null;
                }
                else
                {
                    if (swapchains.Value.Contents == ProxyContents.Single)
                    {
                        marshalledPresentInfo->Swapchains = (SharpVk.Interop.Khronos.Swapchain*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Swapchain>());
                        *(SharpVk.Interop.Khronos.Swapchain*)(marshalledPresentInfo->Swapchains) = swapchains.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.Khronos.Swapchain);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.Swapchain*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.Swapchain>(Interop.HeapUtil.GetLength(swapchains.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(swapchains.Value)); index++)
                        {
                            fieldPointer[index] = swapchains.Value[index]?.handle ?? default(SharpVk.Interop.Khronos.Swapchain);
                        }
                        marshalledPresentInfo->Swapchains = fieldPointer;
                    }
                }
                if (imageIndices.IsNull())
                {
                    marshalledPresentInfo->ImageIndices = null;
                }
                else
                {
                    if (imageIndices.Value.Contents == ProxyContents.Single)
                    {
                        marshalledPresentInfo->ImageIndices = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledPresentInfo->ImageIndices) = imageIndices.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(imageIndices.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(imageIndices.Value)); index++)
                        {
                            fieldPointer[index] = imageIndices.Value[index];
                        }
                        marshalledPresentInfo->ImageIndices = fieldPointer;
                    }
                }
                if (results.IsNull())
                {
                    marshalledPresentInfo->Results = null;
                }
                else
                {
                    if (results.Value.Contents == ProxyContents.Single)
                    {
                        marshalledPresentInfo->Results = (SharpVk.Result*)(Interop.HeapUtil.Allocate<SharpVk.Result>());
                        *(SharpVk.Result*)(marshalledPresentInfo->Results) = results.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Result*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Result>(Interop.HeapUtil.GetLength(results.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(results.Value)); index++)
                        {
                            fieldPointer[index] = results.Value[index];
                        }
                        marshalledPresentInfo->Results = fieldPointer;
                    }
                }
                SharpVk.Interop.Khronos.VkQueuePresentDelegate commandDelegate = commandCache.Cache.vkQueuePresentKHR;
                result = commandDelegate(extendedHandle.handle, marshalledPresentInfo);
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
    }
}
