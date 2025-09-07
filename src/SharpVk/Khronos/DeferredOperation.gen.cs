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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DeferredOperation
        : IDisposable
    {
        internal readonly SharpVk.Interop.Khronos.DeferredOperation handle; 
        
        internal readonly CommandCache commandCache; 
        
        internal readonly SharpVk.Device parent; 
        
        /// <summary>
        /// 
        /// </summary>
        public DeferredOperation(SharpVk.Device parent, SharpVk.Interop.Khronos.DeferredOperation handle)
        {
            this.handle = handle;
            this.parent = parent;
            this.commandCache = parent.commandCache;
        }
        
        /// <summary>
        /// The raw handle for this instance.
        /// </summary>
        public SharpVk.Interop.Khronos.DeferredOperation RawHandle => this.handle;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="infos">
        /// </param>
        /// <param name="buildRangeInfos">
        /// </param>
        public unsafe Result BuildAccelerationStructures(ArrayProxy<SharpVk.Khronos.AccelerationStructureBuildGeometryInfo>? infos, ArrayProxy<SharpVk.Khronos.AccelerationStructureBuildRangeInfo>? buildRangeInfos)
        {
            try
            {
                Result result = default(Result);
                SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo* marshalledInfos = default(SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo*);
                SharpVk.Khronos.AccelerationStructureBuildRangeInfo** marshalledBuildRangeInfos = default(SharpVk.Khronos.AccelerationStructureBuildRangeInfo**);
                SharpVk.Khronos.AccelerationStructureBuildRangeInfo* semiMarshalledBuildRangeInfos = default(SharpVk.Khronos.AccelerationStructureBuildRangeInfo*);
                if (infos.IsNull())
                {
                    marshalledInfos = null;
                }
                else
                {
                    if (infos.Value.Contents == ProxyContents.Single)
                    {
                        marshalledInfos = (SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo>());
                        infos.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo*)(marshalledInfos));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo>(Interop.HeapUtil.GetLength(infos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(infos.Value)); index++)
                        {
                            infos.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledInfos = fieldPointer;
                    }
                }
                if (buildRangeInfos.IsNull())
                {
                    marshalledBuildRangeInfos = null;
                }
                else
                {
                    if (buildRangeInfos.Value.Contents == ProxyContents.Single)
                    {
                        semiMarshalledBuildRangeInfos = (SharpVk.Khronos.AccelerationStructureBuildRangeInfo*)(Interop.HeapUtil.Allocate<SharpVk.Khronos.AccelerationStructureBuildRangeInfo>());
                        *(SharpVk.Khronos.AccelerationStructureBuildRangeInfo*)(semiMarshalledBuildRangeInfos) = buildRangeInfos.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Khronos.AccelerationStructureBuildRangeInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Khronos.AccelerationStructureBuildRangeInfo>(Interop.HeapUtil.GetLength(buildRangeInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(buildRangeInfos.Value)); index++)
                        {
                            fieldPointer[index] = buildRangeInfos.Value[index];
                        }
                        semiMarshalledBuildRangeInfos = fieldPointer;
                        var marshalledFieldPointer = (SharpVk.Khronos.AccelerationStructureBuildRangeInfo**)(Interop.HeapUtil.AllocateAndClear<IntPtr>(Interop.HeapUtil.GetLength(buildRangeInfos.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(buildRangeInfos.Value)); index++)
                        {
                            marshalledFieldPointer[index] = &semiMarshalledBuildRangeInfos[index];
                        }
                        marshalledBuildRangeInfos = marshalledFieldPointer;
                    }
                }
                SharpVk.Interop.Khronos.VkDeferredOperationKHRBuildAccelerationStructuresDelegate commandDelegate = commandCache.Cache.vkBuildAccelerationStructuresKHR;
                result = commandDelegate(this.parent.handle, this.handle, (uint)(Interop.HeapUtil.GetLength(infos)), marshalledInfos, marshalledBuildRangeInfos);
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
        /// <param name="info">
        /// </param>
        public unsafe Result CopyAccelerationStructure(SharpVk.Khronos.CopyAccelerationStructureInfo info)
        {
            try
            {
                Result result = default(Result);
                SharpVk.Interop.Khronos.CopyAccelerationStructureInfo* marshalledInfo = default(SharpVk.Interop.Khronos.CopyAccelerationStructureInfo*);
                marshalledInfo = (SharpVk.Interop.Khronos.CopyAccelerationStructureInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.CopyAccelerationStructureInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Khronos.VkDeferredOperationKHRCopyAccelerationStructureDelegate commandDelegate = commandCache.Cache.vkCopyAccelerationStructureKHR;
                result = commandDelegate(this.parent.handle, this.handle, marshalledInfo);
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
        /// <param name="info">
        /// </param>
        public unsafe Result CopyAccelerationStructureToMemory(SharpVk.Khronos.CopyAccelerationStructureToMemoryInfo info)
        {
            try
            {
                Result result = default(Result);
                SharpVk.Interop.Khronos.CopyAccelerationStructureToMemoryInfo* marshalledInfo = default(SharpVk.Interop.Khronos.CopyAccelerationStructureToMemoryInfo*);
                marshalledInfo = (SharpVk.Interop.Khronos.CopyAccelerationStructureToMemoryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.CopyAccelerationStructureToMemoryInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Khronos.VkDeferredOperationKHRCopyAccelerationStructureToMemoryDelegate commandDelegate = commandCache.Cache.vkCopyAccelerationStructureToMemoryKHR;
                result = commandDelegate(this.parent.handle, this.handle, marshalledInfo);
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
        /// <param name="info">
        /// </param>
        public unsafe Result CopyMemoryToAccelerationStructure(SharpVk.Khronos.CopyMemoryToAccelerationStructureInfo info)
        {
            try
            {
                Result result = default(Result);
                SharpVk.Interop.Khronos.CopyMemoryToAccelerationStructureInfo* marshalledInfo = default(SharpVk.Interop.Khronos.CopyMemoryToAccelerationStructureInfo*);
                marshalledInfo = (SharpVk.Interop.Khronos.CopyMemoryToAccelerationStructureInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.CopyMemoryToAccelerationStructureInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Khronos.VkDeferredOperationKHRCopyMemoryToAccelerationStructureDelegate commandDelegate = commandCache.Cache.vkCopyMemoryToAccelerationStructureKHR;
                result = commandDelegate(this.parent.handle, this.handle, marshalledInfo);
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
                SharpVk.Interop.Khronos.VkDeferredOperationKHRDestroyDelegate commandDelegate = commandCache.Cache.vkDestroyDeferredOperationKHR;
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
        public unsafe void GetMaxConcurrency()
        {
            try
            {
                SharpVk.Interop.Khronos.VkDeferredOperationKHRGetMaxConcurrencyDelegate commandDelegate = commandCache.Cache.vkGetDeferredOperationMaxConcurrencyKHR;
                commandDelegate(this.parent.handle, this.handle);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public unsafe Result GetResult()
        {
            try
            {
                Result result = default(Result);
                SharpVk.Interop.Khronos.VkDeferredOperationKHRGetResultDelegate commandDelegate = commandCache.Cache.vkGetDeferredOperationResultKHR;
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
        public unsafe Result DeferredOperationJoin()
        {
            try
            {
                Result result = default(Result);
                SharpVk.Interop.Khronos.VkDeferredOperationKHRDeferredOperationJoinDelegate commandDelegate = commandCache.Cache.vkDeferredOperationJoinKHR;
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
        /// Destroys the handles and releases any unmanaged resources
        /// associated with it.
        /// </summary>
        public void Dispose()
        {
            this.Destroy();
        }
    }
}
