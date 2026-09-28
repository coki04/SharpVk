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

namespace SharpVk
{
    /// <summary>
    /// Opaque handle to a queue object.
    /// </summary>
    public partial class Queue
    {
        internal readonly SharpVk.Interop.Queue handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.Device parent; 
        
        /// <summary>
        /// 
        /// </summary>
        public Queue(SharpVk.Device parent, SharpVk.Interop.Queue handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.Queue RawHandle => this.handle;
        
        /// <summary>
        /// Submits a sequence of semaphores or command buffers to a queue.
        /// </summary>
        /// <param name="submits">
        /// </param>
        /// <param name="fence">
        /// </param>
        public unsafe void Submit(ArrayProxy<SharpVk.SubmitInfo>? submits, SharpVk.Fence fence)
        {
            try
            {
                SharpVk.Interop.SubmitInfo* marshalledSubmits = default(SharpVk.Interop.SubmitInfo*);
                if (submits.IsNull())
                {
                    marshalledSubmits = null;
                }
                else
                {
                    if (submits.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSubmits = (SharpVk.Interop.SubmitInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SubmitInfo>());
                        submits.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.SubmitInfo*)(marshalledSubmits));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.SubmitInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.SubmitInfo>(Interop.HeapUtil.GetLength(submits.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(submits.Value)); index++)
                        {
                            submits.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledSubmits = fieldPointer;
                    }
                }
                SharpVk.Interop.VkQueueSubmitDelegate commandDelegate = commandCache.Cache.vkQueueSubmit;
                Result methodResult = commandDelegate(this.handle, (uint)(Interop.HeapUtil.GetLength(submits)), marshalledSubmits, fence?.handle ?? default(SharpVk.Interop.Fence));
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
        /// Submits a sequence of semaphores or command buffers to a queue.
        /// </summary>
        /// <param name="waitSemaphores">
        /// </param>
        /// <param name="waitDestinationStageMask">
        /// </param>
        /// <param name="commandBuffers">
        /// </param>
        /// <param name="signalSemaphores">
        /// </param>
        /// <param name="win32KeyedMutexAcquireReleaseInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="win32KeyedMutexAcquireReleaseInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="d3D12FenceSubmitInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="deviceGroupSubmitInfo">
        /// Extension struct
        /// </param>
        /// <param name="protectedSubmitInfo">
        /// Extension struct
        /// </param>
        /// <param name="timelineSemaphoreSubmitInfo">
        /// Extension struct
        /// </param>
        /// <param name="performanceQuerySubmitInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="amigoProfilingSubmitInfoSec">
        /// Extension struct
        /// </param>
        /// <param name="frameBoundaryExt">
        /// Extension struct
        /// </param>
        /// <param name="latencySubmissionPresentIdNv">
        /// Extension struct
        /// </param>
        /// <param name="throttleHintSubmitInfoSec">
        /// Extension struct
        /// </param>
        /// <param name="frameBoundaryTensorsArm">
        /// Extension struct
        /// </param>
        /// <param name="fence">
        /// </param>
        public unsafe void Submit(ArrayProxy<SharpVk.Semaphore>? waitSemaphores, ArrayProxy<SharpVk.PipelineStageFlags>? waitDestinationStageMask, ArrayProxy<SharpVk.CommandBuffer>? commandBuffers, ArrayProxy<SharpVk.Semaphore>? signalSemaphores, SharpVk.Fence fence, SharpVk.NVidia.Win32KeyedMutexAcquireReleaseInfo? win32KeyedMutexAcquireReleaseInfoNv = null, SharpVk.Khronos.Win32KeyedMutexAcquireReleaseInfo? win32KeyedMutexAcquireReleaseInfoKhr = null, SharpVk.Khronos.D3D12FenceSubmitInfo? d3D12FenceSubmitInfoKhr = null, SharpVk.DeviceGroupSubmitInfo? deviceGroupSubmitInfo = null, SharpVk.ProtectedSubmitInfo? protectedSubmitInfo = null, SharpVk.TimelineSemaphoreSubmitInfo? timelineSemaphoreSubmitInfo = null, SharpVk.Khronos.PerformanceQuerySubmitInfo? performanceQuerySubmitInfoKhr = null, SharpVk.Sec.AmigoProfilingSubmitInfo? amigoProfilingSubmitInfoSec = null, SharpVk.Multivendor.FrameBoundary? frameBoundaryExt = null, SharpVk.NVidia.LatencySubmissionPresentId? latencySubmissionPresentIdNv = null, SharpVk.Sec.ThrottleHintSubmitInfo? throttleHintSubmitInfoSec = null, SharpVk.Arm.FrameBoundaryTensors? frameBoundaryTensorsArm = null)
        {
            try
            {
                SharpVk.Interop.SubmitInfo* marshalledSubmits = default(SharpVk.Interop.SubmitInfo*);
                void* vkSubmitInfoNextPointer = default(void*);
                if (win32KeyedMutexAcquireReleaseInfoNv != null)
                {
                    SharpVk.Interop.NVidia.Win32KeyedMutexAcquireReleaseInfo* extensionPointer = default(SharpVk.Interop.NVidia.Win32KeyedMutexAcquireReleaseInfo*);
                    extensionPointer = (SharpVk.Interop.NVidia.Win32KeyedMutexAcquireReleaseInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.Win32KeyedMutexAcquireReleaseInfo>());
                    win32KeyedMutexAcquireReleaseInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSubmitInfoNextPointer;
                    vkSubmitInfoNextPointer = extensionPointer;
                }
                if (win32KeyedMutexAcquireReleaseInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.Win32KeyedMutexAcquireReleaseInfo* extensionPointer = default(SharpVk.Interop.Khronos.Win32KeyedMutexAcquireReleaseInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.Win32KeyedMutexAcquireReleaseInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Win32KeyedMutexAcquireReleaseInfo>());
                    win32KeyedMutexAcquireReleaseInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSubmitInfoNextPointer;
                    vkSubmitInfoNextPointer = extensionPointer;
                }
                if (d3D12FenceSubmitInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.D3D12FenceSubmitInfo* extensionPointer = default(SharpVk.Interop.Khronos.D3D12FenceSubmitInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.D3D12FenceSubmitInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.D3D12FenceSubmitInfo>());
                    d3D12FenceSubmitInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSubmitInfoNextPointer;
                    vkSubmitInfoNextPointer = extensionPointer;
                }
                if (deviceGroupSubmitInfo != null)
                {
                    SharpVk.Interop.DeviceGroupSubmitInfo* extensionPointer = default(SharpVk.Interop.DeviceGroupSubmitInfo*);
                    extensionPointer = (SharpVk.Interop.DeviceGroupSubmitInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.DeviceGroupSubmitInfo>());
                    deviceGroupSubmitInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSubmitInfoNextPointer;
                    vkSubmitInfoNextPointer = extensionPointer;
                }
                if (protectedSubmitInfo != null)
                {
                    SharpVk.Interop.ProtectedSubmitInfo* extensionPointer = default(SharpVk.Interop.ProtectedSubmitInfo*);
                    extensionPointer = (SharpVk.Interop.ProtectedSubmitInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ProtectedSubmitInfo>());
                    protectedSubmitInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSubmitInfoNextPointer;
                    vkSubmitInfoNextPointer = extensionPointer;
                }
                if (timelineSemaphoreSubmitInfo != null)
                {
                    SharpVk.Interop.TimelineSemaphoreSubmitInfo* extensionPointer = default(SharpVk.Interop.TimelineSemaphoreSubmitInfo*);
                    extensionPointer = (SharpVk.Interop.TimelineSemaphoreSubmitInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.TimelineSemaphoreSubmitInfo>());
                    timelineSemaphoreSubmitInfo.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSubmitInfoNextPointer;
                    vkSubmitInfoNextPointer = extensionPointer;
                }
                if (performanceQuerySubmitInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.PerformanceQuerySubmitInfo* extensionPointer = default(SharpVk.Interop.Khronos.PerformanceQuerySubmitInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.PerformanceQuerySubmitInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PerformanceQuerySubmitInfo>());
                    performanceQuerySubmitInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSubmitInfoNextPointer;
                    vkSubmitInfoNextPointer = extensionPointer;
                }
                if (amigoProfilingSubmitInfoSec != null)
                {
                    SharpVk.Interop.Sec.AmigoProfilingSubmitInfo* extensionPointer = default(SharpVk.Interop.Sec.AmigoProfilingSubmitInfo*);
                    extensionPointer = (SharpVk.Interop.Sec.AmigoProfilingSubmitInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Sec.AmigoProfilingSubmitInfo>());
                    amigoProfilingSubmitInfoSec.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSubmitInfoNextPointer;
                    vkSubmitInfoNextPointer = extensionPointer;
                }
                if (frameBoundaryExt != null)
                {
                    SharpVk.Interop.Multivendor.FrameBoundary* extensionPointer = default(SharpVk.Interop.Multivendor.FrameBoundary*);
                    extensionPointer = (SharpVk.Interop.Multivendor.FrameBoundary*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.FrameBoundary>());
                    frameBoundaryExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSubmitInfoNextPointer;
                    vkSubmitInfoNextPointer = extensionPointer;
                }
                if (latencySubmissionPresentIdNv != null)
                {
                    SharpVk.Interop.NVidia.LatencySubmissionPresentId* extensionPointer = default(SharpVk.Interop.NVidia.LatencySubmissionPresentId*);
                    extensionPointer = (SharpVk.Interop.NVidia.LatencySubmissionPresentId*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.LatencySubmissionPresentId>());
                    latencySubmissionPresentIdNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSubmitInfoNextPointer;
                    vkSubmitInfoNextPointer = extensionPointer;
                }
                if (throttleHintSubmitInfoSec != null)
                {
                    SharpVk.Interop.Sec.ThrottleHintSubmitInfo* extensionPointer = default(SharpVk.Interop.Sec.ThrottleHintSubmitInfo*);
                    extensionPointer = (SharpVk.Interop.Sec.ThrottleHintSubmitInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Sec.ThrottleHintSubmitInfo>());
                    throttleHintSubmitInfoSec.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSubmitInfoNextPointer;
                    vkSubmitInfoNextPointer = extensionPointer;
                }
                if (frameBoundaryTensorsArm != null)
                {
                    SharpVk.Interop.Arm.FrameBoundaryTensors* extensionPointer = default(SharpVk.Interop.Arm.FrameBoundaryTensors*);
                    extensionPointer = (SharpVk.Interop.Arm.FrameBoundaryTensors*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.FrameBoundaryTensors>());
                    frameBoundaryTensorsArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSubmitInfoNextPointer;
                    vkSubmitInfoNextPointer = extensionPointer;
                }
                marshalledSubmits = (SharpVk.Interop.SubmitInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SubmitInfo>());
                marshalledSubmits->SType = StructureType.SubmitInfo;
                marshalledSubmits->Next = vkSubmitInfoNextPointer;
                marshalledSubmits->WaitSemaphoreCount = (uint)(Interop.HeapUtil.GetLength(waitSemaphores));
                if (waitSemaphores.IsNull())
                {
                    marshalledSubmits->WaitSemaphores = null;
                }
                else
                {
                    if (waitSemaphores.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSubmits->WaitSemaphores = (SharpVk.Interop.Semaphore*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Semaphore>());
                        *(SharpVk.Interop.Semaphore*)(marshalledSubmits->WaitSemaphores) = waitSemaphores.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.Semaphore);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Semaphore*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Semaphore>(Interop.HeapUtil.GetLength(waitSemaphores.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(waitSemaphores.Value)); index++)
                        {
                            fieldPointer[index] = waitSemaphores.Value[index]?.handle ?? default(SharpVk.Interop.Semaphore);
                        }
                        marshalledSubmits->WaitSemaphores = fieldPointer;
                    }
                }
                if (waitDestinationStageMask.IsNull())
                {
                    marshalledSubmits->WaitDestinationStageMask = null;
                }
                else
                {
                    if (waitDestinationStageMask.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSubmits->WaitDestinationStageMask = (SharpVk.PipelineStageFlags*)(Interop.HeapUtil.Allocate<SharpVk.PipelineStageFlags>());
                        *(SharpVk.PipelineStageFlags*)(marshalledSubmits->WaitDestinationStageMask) = waitDestinationStageMask.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.PipelineStageFlags*)(Interop.HeapUtil.AllocateAndClear<SharpVk.PipelineStageFlags>(Interop.HeapUtil.GetLength(waitDestinationStageMask.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(waitDestinationStageMask.Value)); index++)
                        {
                            fieldPointer[index] = waitDestinationStageMask.Value[index];
                        }
                        marshalledSubmits->WaitDestinationStageMask = fieldPointer;
                    }
                }
                marshalledSubmits->CommandBufferCount = (uint)(Interop.HeapUtil.GetLength(commandBuffers));
                if (commandBuffers.IsNull())
                {
                    marshalledSubmits->CommandBuffers = null;
                }
                else
                {
                    if (commandBuffers.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSubmits->CommandBuffers = (SharpVk.Interop.CommandBuffer*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CommandBuffer>());
                        *(SharpVk.Interop.CommandBuffer*)(marshalledSubmits->CommandBuffers) = commandBuffers.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.CommandBuffer);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.CommandBuffer*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.CommandBuffer>(Interop.HeapUtil.GetLength(commandBuffers.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(commandBuffers.Value)); index++)
                        {
                            fieldPointer[index] = commandBuffers.Value[index]?.handle ?? default(SharpVk.Interop.CommandBuffer);
                        }
                        marshalledSubmits->CommandBuffers = fieldPointer;
                    }
                }
                marshalledSubmits->SignalSemaphoreCount = (uint)(Interop.HeapUtil.GetLength(signalSemaphores));
                if (signalSemaphores.IsNull())
                {
                    marshalledSubmits->SignalSemaphores = null;
                }
                else
                {
                    if (signalSemaphores.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSubmits->SignalSemaphores = (SharpVk.Interop.Semaphore*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Semaphore>());
                        *(SharpVk.Interop.Semaphore*)(marshalledSubmits->SignalSemaphores) = signalSemaphores.Value.GetSingleValue()?.handle ?? default(SharpVk.Interop.Semaphore);
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Semaphore*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Semaphore>(Interop.HeapUtil.GetLength(signalSemaphores.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(signalSemaphores.Value)); index++)
                        {
                            fieldPointer[index] = signalSemaphores.Value[index]?.handle ?? default(SharpVk.Interop.Semaphore);
                        }
                        marshalledSubmits->SignalSemaphores = fieldPointer;
                    }
                }
                SharpVk.Interop.VkQueueSubmitDelegate commandDelegate = commandCache.Cache.vkQueueSubmit;
                Result methodResult = commandDelegate(this.handle, 1, marshalledSubmits, fence?.handle ?? default(SharpVk.Interop.Fence));
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
        /// Wait for a queue to become idle.
        /// </summary>
        public unsafe void WaitIdle()
        {
            try
            {
                SharpVk.Interop.VkQueueWaitIdleDelegate commandDelegate = commandCache.Cache.vkQueueWaitIdle;
                Result methodResult = commandDelegate(this.handle);
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
        /// Bind device memory to a sparse resource object.
        /// </summary>
        /// <param name="bindInfo">
        /// </param>
        /// <param name="fence">
        /// </param>
        public unsafe void BindSparse(ArrayProxy<SharpVk.BindSparseInfo>? bindInfo, SharpVk.Fence fence)
        {
            try
            {
                SharpVk.Interop.BindSparseInfo* marshalledBindInfo = default(SharpVk.Interop.BindSparseInfo*);
                if (bindInfo.IsNull())
                {
                    marshalledBindInfo = null;
                }
                else
                {
                    if (bindInfo.Value.Contents == ProxyContents.Single)
                    {
                        marshalledBindInfo = (SharpVk.Interop.BindSparseInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.BindSparseInfo>());
                        bindInfo.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.BindSparseInfo*)(marshalledBindInfo));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.BindSparseInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.BindSparseInfo>(Interop.HeapUtil.GetLength(bindInfo.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(bindInfo.Value)); index++)
                        {
                            bindInfo.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledBindInfo = fieldPointer;
                    }
                }
                SharpVk.Interop.VkQueueBindSparseDelegate commandDelegate = commandCache.Cache.vkQueueBindSparse;
                Result methodResult = commandDelegate(this.handle, (uint)(Interop.HeapUtil.GetLength(bindInfo)), marshalledBindInfo, fence?.handle ?? default(SharpVk.Interop.Fence));
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
        /// <param name="submits">
        /// </param>
        /// <param name="fence">
        /// </param>
        public unsafe void Submit2(ArrayProxy<SharpVk.SubmitInfo2>? submits, SharpVk.Fence fence)
        {
            try
            {
                SharpVk.Interop.SubmitInfo2* marshalledSubmits = default(SharpVk.Interop.SubmitInfo2*);
                if (submits.IsNull())
                {
                    marshalledSubmits = null;
                }
                else
                {
                    if (submits.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSubmits = (SharpVk.Interop.SubmitInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SubmitInfo2>());
                        submits.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.SubmitInfo2*)(marshalledSubmits));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.SubmitInfo2*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.SubmitInfo2>(Interop.HeapUtil.GetLength(submits.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(submits.Value)); index++)
                        {
                            submits.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledSubmits = fieldPointer;
                    }
                }
                SharpVk.Interop.VkQueueSubmit2Delegate commandDelegate = commandCache.Cache.vkQueueSubmit2;
                Result methodResult = commandDelegate(this.handle, (uint)(Interop.HeapUtil.GetLength(submits)), marshalledSubmits, fence?.handle ?? default(SharpVk.Interop.Fence));
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
        /// <param name="flags">
        /// </param>
        /// <param name="waitSemaphoreInfos">
        /// </param>
        /// <param name="commandBufferInfos">
        /// </param>
        /// <param name="signalSemaphoreInfos">
        /// </param>
        /// <param name="win32KeyedMutexAcquireReleaseInfoNv">
        /// Extension struct
        /// </param>
        /// <param name="win32KeyedMutexAcquireReleaseInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="performanceQuerySubmitInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="frameBoundaryExt">
        /// Extension struct
        /// </param>
        /// <param name="latencySubmissionPresentIdNv">
        /// Extension struct
        /// </param>
        /// <param name="frameBoundaryTensorsArm">
        /// Extension struct
        /// </param>
        /// <param name="fence">
        /// </param>
        public unsafe void Submit2(ArrayProxy<SharpVk.SemaphoreSubmitInfo>? waitSemaphoreInfos, ArrayProxy<SharpVk.CommandBufferSubmitInfo>? commandBufferInfos, ArrayProxy<SharpVk.SemaphoreSubmitInfo>? signalSemaphoreInfos, SharpVk.Fence fence, SharpVk.SubmitFlags? flags = default(SharpVk.SubmitFlags?), SharpVk.NVidia.Win32KeyedMutexAcquireReleaseInfo? win32KeyedMutexAcquireReleaseInfoNv = null, SharpVk.Khronos.Win32KeyedMutexAcquireReleaseInfo? win32KeyedMutexAcquireReleaseInfoKhr = null, SharpVk.Khronos.PerformanceQuerySubmitInfo? performanceQuerySubmitInfoKhr = null, SharpVk.Multivendor.FrameBoundary? frameBoundaryExt = null, SharpVk.NVidia.LatencySubmissionPresentId? latencySubmissionPresentIdNv = null, SharpVk.Arm.FrameBoundaryTensors? frameBoundaryTensorsArm = null)
        {
            try
            {
                SharpVk.Interop.SubmitInfo2* marshalledSubmits = default(SharpVk.Interop.SubmitInfo2*);
                void* vkSubmitInfo2NextPointer = default(void*);
                if (win32KeyedMutexAcquireReleaseInfoNv != null)
                {
                    SharpVk.Interop.NVidia.Win32KeyedMutexAcquireReleaseInfo* extensionPointer = default(SharpVk.Interop.NVidia.Win32KeyedMutexAcquireReleaseInfo*);
                    extensionPointer = (SharpVk.Interop.NVidia.Win32KeyedMutexAcquireReleaseInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.Win32KeyedMutexAcquireReleaseInfo>());
                    win32KeyedMutexAcquireReleaseInfoNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSubmitInfo2NextPointer;
                    vkSubmitInfo2NextPointer = extensionPointer;
                }
                if (win32KeyedMutexAcquireReleaseInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.Win32KeyedMutexAcquireReleaseInfo* extensionPointer = default(SharpVk.Interop.Khronos.Win32KeyedMutexAcquireReleaseInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.Win32KeyedMutexAcquireReleaseInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.Win32KeyedMutexAcquireReleaseInfo>());
                    win32KeyedMutexAcquireReleaseInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSubmitInfo2NextPointer;
                    vkSubmitInfo2NextPointer = extensionPointer;
                }
                if (performanceQuerySubmitInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.PerformanceQuerySubmitInfo* extensionPointer = default(SharpVk.Interop.Khronos.PerformanceQuerySubmitInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.PerformanceQuerySubmitInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.PerformanceQuerySubmitInfo>());
                    performanceQuerySubmitInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSubmitInfo2NextPointer;
                    vkSubmitInfo2NextPointer = extensionPointer;
                }
                if (frameBoundaryExt != null)
                {
                    SharpVk.Interop.Multivendor.FrameBoundary* extensionPointer = default(SharpVk.Interop.Multivendor.FrameBoundary*);
                    extensionPointer = (SharpVk.Interop.Multivendor.FrameBoundary*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.FrameBoundary>());
                    frameBoundaryExt.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSubmitInfo2NextPointer;
                    vkSubmitInfo2NextPointer = extensionPointer;
                }
                if (latencySubmissionPresentIdNv != null)
                {
                    SharpVk.Interop.NVidia.LatencySubmissionPresentId* extensionPointer = default(SharpVk.Interop.NVidia.LatencySubmissionPresentId*);
                    extensionPointer = (SharpVk.Interop.NVidia.LatencySubmissionPresentId*)(Interop.HeapUtil.Allocate<SharpVk.Interop.NVidia.LatencySubmissionPresentId>());
                    latencySubmissionPresentIdNv.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSubmitInfo2NextPointer;
                    vkSubmitInfo2NextPointer = extensionPointer;
                }
                if (frameBoundaryTensorsArm != null)
                {
                    SharpVk.Interop.Arm.FrameBoundaryTensors* extensionPointer = default(SharpVk.Interop.Arm.FrameBoundaryTensors*);
                    extensionPointer = (SharpVk.Interop.Arm.FrameBoundaryTensors*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Arm.FrameBoundaryTensors>());
                    frameBoundaryTensorsArm.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkSubmitInfo2NextPointer;
                    vkSubmitInfo2NextPointer = extensionPointer;
                }
                marshalledSubmits = (SharpVk.Interop.SubmitInfo2*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SubmitInfo2>());
                marshalledSubmits->SType = StructureType.SubmitInfo2Base;
                marshalledSubmits->Next = vkSubmitInfo2NextPointer;
                if (flags != null)
                {
                    marshalledSubmits->Flags = flags.Value;
                }
                else
                {
                    marshalledSubmits->Flags = default(SharpVk.SubmitFlags);
                }
                marshalledSubmits->WaitSemaphoreInfoCount = (uint)(Interop.HeapUtil.GetLength(waitSemaphoreInfos));
                if (waitSemaphoreInfos.IsNull())
                {
                    marshalledSubmits->WaitSemaphoreInfos = null;
                }
                else
                {
                    if (waitSemaphoreInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSubmits->WaitSemaphoreInfos = (SharpVk.Interop.SemaphoreSubmitInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SemaphoreSubmitInfo>());
                        waitSemaphoreInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.SemaphoreSubmitInfo*)(marshalledSubmits->WaitSemaphoreInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.SemaphoreSubmitInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.SemaphoreSubmitInfo>(Interop.HeapUtil.GetLength(waitSemaphoreInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(waitSemaphoreInfos.Value)); index++)
                        {
                            waitSemaphoreInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledSubmits->WaitSemaphoreInfos = fieldPointer;
                    }
                }
                marshalledSubmits->CommandBufferInfoCount = (uint)(Interop.HeapUtil.GetLength(commandBufferInfos));
                if (commandBufferInfos.IsNull())
                {
                    marshalledSubmits->CommandBufferInfos = null;
                }
                else
                {
                    if (commandBufferInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSubmits->CommandBufferInfos = (SharpVk.Interop.CommandBufferSubmitInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.CommandBufferSubmitInfo>());
                        commandBufferInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.CommandBufferSubmitInfo*)(marshalledSubmits->CommandBufferInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.CommandBufferSubmitInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.CommandBufferSubmitInfo>(Interop.HeapUtil.GetLength(commandBufferInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(commandBufferInfos.Value)); index++)
                        {
                            commandBufferInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledSubmits->CommandBufferInfos = fieldPointer;
                    }
                }
                marshalledSubmits->SignalSemaphoreInfoCount = (uint)(Interop.HeapUtil.GetLength(signalSemaphoreInfos));
                if (signalSemaphoreInfos.IsNull())
                {
                    marshalledSubmits->SignalSemaphoreInfos = null;
                }
                else
                {
                    if (signalSemaphoreInfos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledSubmits->SignalSemaphoreInfos = (SharpVk.Interop.SemaphoreSubmitInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.SemaphoreSubmitInfo>());
                        signalSemaphoreInfos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.SemaphoreSubmitInfo*)(marshalledSubmits->SignalSemaphoreInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.SemaphoreSubmitInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.SemaphoreSubmitInfo>(Interop.HeapUtil.GetLength(signalSemaphoreInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(signalSemaphoreInfos.Value)); index++)
                        {
                            signalSemaphoreInfos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledSubmits->SignalSemaphoreInfos = fieldPointer;
                    }
                }
                SharpVk.Interop.VkQueueSubmit2Delegate commandDelegate = commandCache.Cache.vkQueueSubmit2;
                Result methodResult = commandDelegate(this.handle, 1, marshalledSubmits, fence?.handle ?? default(SharpVk.Interop.Fence));
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
    }
}
