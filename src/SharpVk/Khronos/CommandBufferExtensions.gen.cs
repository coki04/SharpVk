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
    public static class CommandBufferExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extendedHandle">
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="beginInfo">
        /// </param>
        public static unsafe void BeginVideoCoding(this SharpVk.CommandBuffer extendedHandle, SharpVk.Khronos.VideoBeginCodingInfo beginInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.VideoBeginCodingInfo* marshalledBeginInfo = default(SharpVk.Interop.Khronos.VideoBeginCodingInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledBeginInfo = (SharpVk.Interop.Khronos.VideoBeginCodingInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoBeginCodingInfo>());
                beginInfo.MarshalTo(marshalledBeginInfo);
                SharpVk.Interop.Khronos.VkCommandBufferBeginVideoCodingDelegate commandDelegate = commandCache.Cache.vkCmdBeginVideoCodingKHR;
                commandDelegate(extendedHandle.handle, marshalledBeginInfo);
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="endCodingInfo">
        /// </param>
        public static unsafe void EndVideoCoding(this SharpVk.CommandBuffer extendedHandle, SharpVk.Khronos.VideoEndCodingInfo endCodingInfo)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.VideoEndCodingInfo* marshalledEndCodingInfo = default(SharpVk.Interop.Khronos.VideoEndCodingInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledEndCodingInfo = (SharpVk.Interop.Khronos.VideoEndCodingInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoEndCodingInfo>());
                endCodingInfo.MarshalTo(marshalledEndCodingInfo);
                SharpVk.Interop.Khronos.VkCommandBufferEndVideoCodingDelegate commandDelegate = commandCache.Cache.vkCmdEndVideoCodingKHR;
                commandDelegate(extendedHandle.handle, marshalledEndCodingInfo);
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="videoEncodeQualityLevelInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="videoEncodeRateControlInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="videoEncodeH264RateControlInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="videoEncodeH265RateControlInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="videoEncodeAV1RateControlInfoKhr">
        /// Extension struct
        /// </param>
        public static unsafe void ControlVideoCoding(this SharpVk.CommandBuffer extendedHandle, SharpVk.Khronos.VideoCodingControlFlags flags, SharpVk.Khronos.VideoEncodeQualityLevelInfo? videoEncodeQualityLevelInfoKhr = null, SharpVk.Khronos.VideoEncodeRateControlInfo? videoEncodeRateControlInfoKhr = null, SharpVk.Khronos.VideoEncodeH264RateControlInfo? videoEncodeH264RateControlInfoKhr = null, SharpVk.Khronos.VideoEncodeH265RateControlInfo? videoEncodeH265RateControlInfoKhr = null, SharpVk.Khronos.VideoEncodeAV1RateControlInfo? videoEncodeAV1RateControlInfoKhr = null)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.VideoCodingControlInfo* marshalledCodingControlInfo = default(SharpVk.Interop.Khronos.VideoCodingControlInfo*);
                void* vkVideoCodingControlInfoKHRNextPointer = default(void*);
                if (videoEncodeQualityLevelInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.VideoEncodeQualityLevelInfo* extensionPointer = default(SharpVk.Interop.Khronos.VideoEncodeQualityLevelInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.VideoEncodeQualityLevelInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoEncodeQualityLevelInfo>());
                    videoEncodeQualityLevelInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoCodingControlInfoKHRNextPointer;
                    vkVideoCodingControlInfoKHRNextPointer = extensionPointer;
                }
                if (videoEncodeRateControlInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.VideoEncodeRateControlInfo* extensionPointer = default(SharpVk.Interop.Khronos.VideoEncodeRateControlInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.VideoEncodeRateControlInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoEncodeRateControlInfo>());
                    videoEncodeRateControlInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoCodingControlInfoKHRNextPointer;
                    vkVideoCodingControlInfoKHRNextPointer = extensionPointer;
                }
                if (videoEncodeH264RateControlInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.VideoEncodeH264RateControlInfo* extensionPointer = default(SharpVk.Interop.Khronos.VideoEncodeH264RateControlInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.VideoEncodeH264RateControlInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoEncodeH264RateControlInfo>());
                    videoEncodeH264RateControlInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoCodingControlInfoKHRNextPointer;
                    vkVideoCodingControlInfoKHRNextPointer = extensionPointer;
                }
                if (videoEncodeH265RateControlInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.VideoEncodeH265RateControlInfo* extensionPointer = default(SharpVk.Interop.Khronos.VideoEncodeH265RateControlInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.VideoEncodeH265RateControlInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoEncodeH265RateControlInfo>());
                    videoEncodeH265RateControlInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoCodingControlInfoKHRNextPointer;
                    vkVideoCodingControlInfoKHRNextPointer = extensionPointer;
                }
                if (videoEncodeAV1RateControlInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.VideoEncodeAV1RateControlInfo* extensionPointer = default(SharpVk.Interop.Khronos.VideoEncodeAV1RateControlInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.VideoEncodeAV1RateControlInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoEncodeAV1RateControlInfo>());
                    videoEncodeAV1RateControlInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoCodingControlInfoKHRNextPointer;
                    vkVideoCodingControlInfoKHRNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledCodingControlInfo = (SharpVk.Interop.Khronos.VideoCodingControlInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoCodingControlInfo>());
                marshalledCodingControlInfo->SType = StructureType.VideoCodingControlInfo;
                marshalledCodingControlInfo->Next = vkVideoCodingControlInfoKHRNextPointer;
                marshalledCodingControlInfo->Flags = flags;
                SharpVk.Interop.Khronos.VkCommandBufferControlVideoCodingDelegate commandDelegate = commandCache.Cache.vkCmdControlVideoCodingKHR;
                commandDelegate(extendedHandle.handle, marshalledCodingControlInfo);
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="sourceBuffer">
        /// </param>
        /// <param name="sourceBufferOffset">
        /// </param>
        /// <param name="sourceBufferRange">
        /// </param>
        /// <param name="destinationPictureResource">
        /// </param>
        /// <param name="setupReferenceSlot">
        /// </param>
        /// <param name="referenceSlots">
        /// </param>
        /// <param name="videoInlineQueryInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="videoDecodeH264InlineSessionParametersInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="videoDecodeH264PictureInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="videoDecodeH265InlineSessionParametersInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="videoDecodeH265PictureInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="videoDecodeVP9PictureInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="videoDecodeAV1InlineSessionParametersInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="videoDecodeAV1PictureInfoKhr">
        /// Extension struct
        /// </param>
        public static unsafe void DecodeVideo(this SharpVk.CommandBuffer extendedHandle, SharpVk.Buffer sourceBuffer, ulong sourceBufferOffset, ulong sourceBufferRange, SharpVk.Khronos.VideoPictureResourceInfo destinationPictureResource, ArrayProxy<SharpVk.Khronos.VideoReferenceSlotInfo>? referenceSlots, SharpVk.Khronos.VideoDecodeFlags? flags = default(SharpVk.Khronos.VideoDecodeFlags?), SharpVk.Khronos.VideoReferenceSlotInfo? setupReferenceSlot = default(SharpVk.Khronos.VideoReferenceSlotInfo?), SharpVk.Khronos.VideoInlineQueryInfo? videoInlineQueryInfoKhr = null, SharpVk.Khronos.VideoDecodeH264InlineSessionParametersInfo? videoDecodeH264InlineSessionParametersInfoKhr = null, SharpVk.Khronos.VideoDecodeH264PictureInfo? videoDecodeH264PictureInfoKhr = null, SharpVk.Khronos.VideoDecodeH265InlineSessionParametersInfo? videoDecodeH265InlineSessionParametersInfoKhr = null, SharpVk.Khronos.VideoDecodeH265PictureInfo? videoDecodeH265PictureInfoKhr = null, SharpVk.Khronos.VideoDecodeVP9PictureInfo? videoDecodeVP9PictureInfoKhr = null, SharpVk.Khronos.VideoDecodeAV1InlineSessionParametersInfo? videoDecodeAV1InlineSessionParametersInfoKhr = null, SharpVk.Khronos.VideoDecodeAV1PictureInfo? videoDecodeAV1PictureInfoKhr = null)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.VideoDecodeInfo* marshalledDecodeInfo = default(SharpVk.Interop.Khronos.VideoDecodeInfo*);
                void* vkVideoDecodeInfoKHRNextPointer = default(void*);
                if (videoInlineQueryInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.VideoInlineQueryInfo* extensionPointer = default(SharpVk.Interop.Khronos.VideoInlineQueryInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.VideoInlineQueryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoInlineQueryInfo>());
                    videoInlineQueryInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoDecodeInfoKHRNextPointer;
                    vkVideoDecodeInfoKHRNextPointer = extensionPointer;
                }
                if (videoDecodeH264InlineSessionParametersInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.VideoDecodeH264InlineSessionParametersInfo* extensionPointer = default(SharpVk.Interop.Khronos.VideoDecodeH264InlineSessionParametersInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.VideoDecodeH264InlineSessionParametersInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoDecodeH264InlineSessionParametersInfo>());
                    videoDecodeH264InlineSessionParametersInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoDecodeInfoKHRNextPointer;
                    vkVideoDecodeInfoKHRNextPointer = extensionPointer;
                }
                if (videoDecodeH264PictureInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.VideoDecodeH264PictureInfo* extensionPointer = default(SharpVk.Interop.Khronos.VideoDecodeH264PictureInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.VideoDecodeH264PictureInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoDecodeH264PictureInfo>());
                    videoDecodeH264PictureInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoDecodeInfoKHRNextPointer;
                    vkVideoDecodeInfoKHRNextPointer = extensionPointer;
                }
                if (videoDecodeH265InlineSessionParametersInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.VideoDecodeH265InlineSessionParametersInfo* extensionPointer = default(SharpVk.Interop.Khronos.VideoDecodeH265InlineSessionParametersInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.VideoDecodeH265InlineSessionParametersInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoDecodeH265InlineSessionParametersInfo>());
                    videoDecodeH265InlineSessionParametersInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoDecodeInfoKHRNextPointer;
                    vkVideoDecodeInfoKHRNextPointer = extensionPointer;
                }
                if (videoDecodeH265PictureInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.VideoDecodeH265PictureInfo* extensionPointer = default(SharpVk.Interop.Khronos.VideoDecodeH265PictureInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.VideoDecodeH265PictureInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoDecodeH265PictureInfo>());
                    videoDecodeH265PictureInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoDecodeInfoKHRNextPointer;
                    vkVideoDecodeInfoKHRNextPointer = extensionPointer;
                }
                if (videoDecodeVP9PictureInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.VideoDecodeVP9PictureInfo* extensionPointer = default(SharpVk.Interop.Khronos.VideoDecodeVP9PictureInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.VideoDecodeVP9PictureInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoDecodeVP9PictureInfo>());
                    videoDecodeVP9PictureInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoDecodeInfoKHRNextPointer;
                    vkVideoDecodeInfoKHRNextPointer = extensionPointer;
                }
                if (videoDecodeAV1InlineSessionParametersInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.VideoDecodeAV1InlineSessionParametersInfo* extensionPointer = default(SharpVk.Interop.Khronos.VideoDecodeAV1InlineSessionParametersInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.VideoDecodeAV1InlineSessionParametersInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoDecodeAV1InlineSessionParametersInfo>());
                    videoDecodeAV1InlineSessionParametersInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoDecodeInfoKHRNextPointer;
                    vkVideoDecodeInfoKHRNextPointer = extensionPointer;
                }
                if (videoDecodeAV1PictureInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.VideoDecodeAV1PictureInfo* extensionPointer = default(SharpVk.Interop.Khronos.VideoDecodeAV1PictureInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.VideoDecodeAV1PictureInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoDecodeAV1PictureInfo>());
                    videoDecodeAV1PictureInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoDecodeInfoKHRNextPointer;
                    vkVideoDecodeInfoKHRNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledDecodeInfo = (SharpVk.Interop.Khronos.VideoDecodeInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoDecodeInfo>());
                marshalledDecodeInfo->SType = StructureType.VideoDecodeInfo;
                marshalledDecodeInfo->Next = vkVideoDecodeInfoKHRNextPointer;
                if (flags != null)
                {
                    marshalledDecodeInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledDecodeInfo->Flags = default(SharpVk.Khronos.VideoDecodeFlags);
                }
                marshalledDecodeInfo->SourceBuffer = sourceBuffer?.handle ?? default(SharpVk.Interop.Buffer);
                marshalledDecodeInfo->SourceBufferOffset = sourceBufferOffset;
                marshalledDecodeInfo->SourceBufferRange = sourceBufferRange;
                destinationPictureResource.MarshalTo(&marshalledDecodeInfo->DestinationPictureResource);
                if (setupReferenceSlot != null)
                {
                    marshalledDecodeInfo->SetupReferenceSlot = (SharpVk.Interop.Khronos.VideoReferenceSlotInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoReferenceSlotInfo>());
                    setupReferenceSlot.Value.MarshalTo(marshalledDecodeInfo->SetupReferenceSlot);
                }
                else
                {
                    marshalledDecodeInfo->SetupReferenceSlot = default(SharpVk.Interop.Khronos.VideoReferenceSlotInfo*);
                }
                marshalledDecodeInfo->ReferenceSlotCount = (uint)(Interop.HeapUtil.GetLength(referenceSlots));
                if (referenceSlots.IsNull())
                {
                    marshalledDecodeInfo->ReferenceSlots = null;
                }
                else
                {
                    if (referenceSlots.Value.Contents == ProxyContents.Single)
                    {
                        marshalledDecodeInfo->ReferenceSlots = (SharpVk.Interop.Khronos.VideoReferenceSlotInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoReferenceSlotInfo>());
                        referenceSlots.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Khronos.VideoReferenceSlotInfo*)(marshalledDecodeInfo->ReferenceSlots));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.VideoReferenceSlotInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.VideoReferenceSlotInfo>(Interop.HeapUtil.GetLength(referenceSlots.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(referenceSlots.Value)); index++)
                        {
                            referenceSlots.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledDecodeInfo->ReferenceSlots = fieldPointer;
                    }
                }
                SharpVk.Interop.Khronos.VkCommandBufferDecodeVideoDelegate commandDelegate = commandCache.Cache.vkCmdDecodeVideoKHR;
                commandDelegate(extendedHandle.handle, marshalledDecodeInfo);
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="infos">
        /// </param>
        /// <param name="buildRangeInfos">
        /// </param>
        public static unsafe void BuildAccelerationStructures(this SharpVk.CommandBuffer extendedHandle, ArrayProxy<SharpVk.Khronos.AccelerationStructureBuildGeometryInfo>? infos, ArrayProxy<SharpVk.Khronos.AccelerationStructureBuildRangeInfo>? buildRangeInfos)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo* marshalledInfos = default(SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo*);
                SharpVk.Khronos.AccelerationStructureBuildRangeInfo** marshalledBuildRangeInfos = default(SharpVk.Khronos.AccelerationStructureBuildRangeInfo**);
                SharpVk.Khronos.AccelerationStructureBuildRangeInfo* semiMarshalledBuildRangeInfos = default(SharpVk.Khronos.AccelerationStructureBuildRangeInfo*);
                commandCache = extendedHandle.commandCache;
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
                SharpVk.Interop.Khronos.VkCommandBufferBuildAccelerationStructuresDelegate commandDelegate = commandCache.Cache.vkCmdBuildAccelerationStructuresKHR;
                commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(infos)), marshalledInfos, marshalledBuildRangeInfos);
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="infos">
        /// </param>
        /// <param name="indirectDeviceAddresses">
        /// </param>
        /// <param name="indirectStrides">
        /// </param>
        /// <param name="maxPrimitiveCounts">
        /// </param>
        public static unsafe void BuildAccelerationStructuresIndirect(this SharpVk.CommandBuffer extendedHandle, ArrayProxy<SharpVk.Khronos.AccelerationStructureBuildGeometryInfo>? infos, ArrayProxy<ulong>? indirectDeviceAddresses, ArrayProxy<uint>? indirectStrides, ArrayProxy<uint>? maxPrimitiveCounts)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo* marshalledInfos = default(SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo*);
                ulong* marshalledIndirectDeviceAddresses = default(ulong*);
                uint* marshalledIndirectStrides = default(uint*);
                uint** marshalledMaxPrimitiveCounts = default(uint**);
                uint* semiMarshalledMaxPrimitiveCounts = default(uint*);
                commandCache = extendedHandle.commandCache;
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
                if (indirectDeviceAddresses.IsNull())
                {
                    marshalledIndirectDeviceAddresses = null;
                }
                else
                {
                    if (indirectDeviceAddresses.Value.Contents == ProxyContents.Single)
                    {
                        marshalledIndirectDeviceAddresses = (ulong*)(Interop.HeapUtil.Allocate<ulong>());
                        *(ulong*)(marshalledIndirectDeviceAddresses) = indirectDeviceAddresses.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (ulong*)(Interop.HeapUtil.AllocateAndClear<ulong>(Interop.HeapUtil.GetLength(indirectDeviceAddresses.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(indirectDeviceAddresses.Value)); index++)
                        {
                            fieldPointer[index] = indirectDeviceAddresses.Value[index];
                        }
                        marshalledIndirectDeviceAddresses = fieldPointer;
                    }
                }
                if (indirectStrides.IsNull())
                {
                    marshalledIndirectStrides = null;
                }
                else
                {
                    if (indirectStrides.Value.Contents == ProxyContents.Single)
                    {
                        marshalledIndirectStrides = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(marshalledIndirectStrides) = indirectStrides.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(indirectStrides.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(indirectStrides.Value)); index++)
                        {
                            fieldPointer[index] = indirectStrides.Value[index];
                        }
                        marshalledIndirectStrides = fieldPointer;
                    }
                }
                if (maxPrimitiveCounts.IsNull())
                {
                    marshalledMaxPrimitiveCounts = null;
                }
                else
                {
                    if (maxPrimitiveCounts.Value.Contents == ProxyContents.Single)
                    {
                        semiMarshalledMaxPrimitiveCounts = (uint*)(Interop.HeapUtil.Allocate<uint>());
                        *(uint*)(semiMarshalledMaxPrimitiveCounts) = maxPrimitiveCounts.Value.GetSingleValue();
                    }
                    else
                    {
                        var fieldPointer = (uint*)(Interop.HeapUtil.AllocateAndClear<uint>(Interop.HeapUtil.GetLength(maxPrimitiveCounts.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(maxPrimitiveCounts.Value)); index++)
                        {
                            fieldPointer[index] = maxPrimitiveCounts.Value[index];
                        }
                        semiMarshalledMaxPrimitiveCounts = fieldPointer;
                        var marshalledFieldPointer = (uint**)(Interop.HeapUtil.AllocateAndClear<IntPtr>(Interop.HeapUtil.GetLength(maxPrimitiveCounts.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(maxPrimitiveCounts.Value)); index++)
                        {
                            marshalledFieldPointer[index] = &semiMarshalledMaxPrimitiveCounts[index];
                        }
                        marshalledMaxPrimitiveCounts = marshalledFieldPointer;
                    }
                }
                SharpVk.Interop.Khronos.VkCommandBufferBuildAccelerationStructuresIndirectDelegate commandDelegate = commandCache.Cache.vkCmdBuildAccelerationStructuresIndirectKHR;
                commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(infos)), marshalledInfos, marshalledIndirectDeviceAddresses, marshalledIndirectStrides, marshalledMaxPrimitiveCounts);
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        public static unsafe void CopyAccelerationStructure(this SharpVk.CommandBuffer extendedHandle, SharpVk.Khronos.CopyAccelerationStructureInfo info)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.CopyAccelerationStructureInfo* marshalledInfo = default(SharpVk.Interop.Khronos.CopyAccelerationStructureInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Khronos.CopyAccelerationStructureInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.CopyAccelerationStructureInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Khronos.VkCommandBufferCopyAccelerationStructureDelegate commandDelegate = commandCache.Cache.vkCmdCopyAccelerationStructureKHR;
                commandDelegate(extendedHandle.handle, marshalledInfo);
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        public static unsafe void CopyAccelerationStructureToMemory(this SharpVk.CommandBuffer extendedHandle, SharpVk.Khronos.CopyAccelerationStructureToMemoryInfo info)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.CopyAccelerationStructureToMemoryInfo* marshalledInfo = default(SharpVk.Interop.Khronos.CopyAccelerationStructureToMemoryInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Khronos.CopyAccelerationStructureToMemoryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.CopyAccelerationStructureToMemoryInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Khronos.VkCommandBufferCopyAccelerationStructureToMemoryDelegate commandDelegate = commandCache.Cache.vkCmdCopyAccelerationStructureToMemoryKHR;
                commandDelegate(extendedHandle.handle, marshalledInfo);
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="info">
        /// </param>
        public static unsafe void CopyMemoryToAccelerationStructure(this SharpVk.CommandBuffer extendedHandle, SharpVk.Khronos.CopyMemoryToAccelerationStructureInfo info)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.CopyMemoryToAccelerationStructureInfo* marshalledInfo = default(SharpVk.Interop.Khronos.CopyMemoryToAccelerationStructureInfo*);
                commandCache = extendedHandle.commandCache;
                marshalledInfo = (SharpVk.Interop.Khronos.CopyMemoryToAccelerationStructureInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.CopyMemoryToAccelerationStructureInfo>());
                info.MarshalTo(marshalledInfo);
                SharpVk.Interop.Khronos.VkCommandBufferCopyMemoryToAccelerationStructureDelegate commandDelegate = commandCache.Cache.vkCmdCopyMemoryToAccelerationStructureKHR;
                commandDelegate(extendedHandle.handle, marshalledInfo);
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="accelerationStructures">
        /// </param>
        /// <param name="queryType">
        /// </param>
        /// <param name="queryPool">
        /// </param>
        /// <param name="firstQuery">
        /// </param>
        public static unsafe void WriteAccelerationStructuresProperties(this SharpVk.CommandBuffer extendedHandle, ArrayProxy<SharpVk.Khronos.AccelerationStructure>? accelerationStructures, SharpVk.QueryType queryType, SharpVk.QueryPool queryPool, uint firstQuery)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.AccelerationStructure* marshalledAccelerationStructures = default(SharpVk.Interop.Khronos.AccelerationStructure*);
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
                SharpVk.Interop.Khronos.VkCommandBufferWriteAccelerationStructuresPropertiesDelegate commandDelegate = commandCache.Cache.vkCmdWriteAccelerationStructuresPropertiesKHR;
                commandDelegate(extendedHandle.handle, (uint)(Interop.HeapUtil.GetLength(accelerationStructures)), marshalledAccelerationStructures, queryType, queryPool?.handle ?? default(SharpVk.Interop.QueryPool), firstQuery);
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="raygenShaderBindingTable">
        /// </param>
        /// <param name="missShaderBindingTable">
        /// </param>
        /// <param name="hitShaderBindingTable">
        /// </param>
        /// <param name="callableShaderBindingTable">
        /// </param>
        /// <param name="width">
        /// </param>
        /// <param name="height">
        /// </param>
        /// <param name="depth">
        /// </param>
        public static unsafe void TraceRays(this SharpVk.CommandBuffer extendedHandle, SharpVk.Khronos.StridedDeviceAddressRegion raygenShaderBindingTable, SharpVk.Khronos.StridedDeviceAddressRegion missShaderBindingTable, SharpVk.Khronos.StridedDeviceAddressRegion hitShaderBindingTable, SharpVk.Khronos.StridedDeviceAddressRegion callableShaderBindingTable, uint width, uint height, uint depth)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Khronos.StridedDeviceAddressRegion* marshalledRaygenShaderBindingTable = default(SharpVk.Khronos.StridedDeviceAddressRegion*);
                SharpVk.Khronos.StridedDeviceAddressRegion* marshalledMissShaderBindingTable = default(SharpVk.Khronos.StridedDeviceAddressRegion*);
                SharpVk.Khronos.StridedDeviceAddressRegion* marshalledHitShaderBindingTable = default(SharpVk.Khronos.StridedDeviceAddressRegion*);
                SharpVk.Khronos.StridedDeviceAddressRegion* marshalledCallableShaderBindingTable = default(SharpVk.Khronos.StridedDeviceAddressRegion*);
                commandCache = extendedHandle.commandCache;
                marshalledRaygenShaderBindingTable = (SharpVk.Khronos.StridedDeviceAddressRegion*)(Interop.HeapUtil.Allocate<SharpVk.Khronos.StridedDeviceAddressRegion>());
                *marshalledRaygenShaderBindingTable = raygenShaderBindingTable;
                marshalledMissShaderBindingTable = (SharpVk.Khronos.StridedDeviceAddressRegion*)(Interop.HeapUtil.Allocate<SharpVk.Khronos.StridedDeviceAddressRegion>());
                *marshalledMissShaderBindingTable = missShaderBindingTable;
                marshalledHitShaderBindingTable = (SharpVk.Khronos.StridedDeviceAddressRegion*)(Interop.HeapUtil.Allocate<SharpVk.Khronos.StridedDeviceAddressRegion>());
                *marshalledHitShaderBindingTable = hitShaderBindingTable;
                marshalledCallableShaderBindingTable = (SharpVk.Khronos.StridedDeviceAddressRegion*)(Interop.HeapUtil.Allocate<SharpVk.Khronos.StridedDeviceAddressRegion>());
                *marshalledCallableShaderBindingTable = callableShaderBindingTable;
                SharpVk.Interop.Khronos.VkCommandBufferTraceRaysDelegate commandDelegate = commandCache.Cache.vkCmdTraceRaysKHR;
                commandDelegate(extendedHandle.handle, marshalledRaygenShaderBindingTable, marshalledMissShaderBindingTable, marshalledHitShaderBindingTable, marshalledCallableShaderBindingTable, width, height, depth);
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="raygenShaderBindingTable">
        /// </param>
        /// <param name="missShaderBindingTable">
        /// </param>
        /// <param name="hitShaderBindingTable">
        /// </param>
        /// <param name="callableShaderBindingTable">
        /// </param>
        /// <param name="indirectDeviceAddress">
        /// </param>
        public static unsafe void TraceRaysIndirect(this SharpVk.CommandBuffer extendedHandle, SharpVk.Khronos.StridedDeviceAddressRegion raygenShaderBindingTable, SharpVk.Khronos.StridedDeviceAddressRegion missShaderBindingTable, SharpVk.Khronos.StridedDeviceAddressRegion hitShaderBindingTable, SharpVk.Khronos.StridedDeviceAddressRegion callableShaderBindingTable, ulong indirectDeviceAddress)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Khronos.StridedDeviceAddressRegion* marshalledRaygenShaderBindingTable = default(SharpVk.Khronos.StridedDeviceAddressRegion*);
                SharpVk.Khronos.StridedDeviceAddressRegion* marshalledMissShaderBindingTable = default(SharpVk.Khronos.StridedDeviceAddressRegion*);
                SharpVk.Khronos.StridedDeviceAddressRegion* marshalledHitShaderBindingTable = default(SharpVk.Khronos.StridedDeviceAddressRegion*);
                SharpVk.Khronos.StridedDeviceAddressRegion* marshalledCallableShaderBindingTable = default(SharpVk.Khronos.StridedDeviceAddressRegion*);
                commandCache = extendedHandle.commandCache;
                marshalledRaygenShaderBindingTable = (SharpVk.Khronos.StridedDeviceAddressRegion*)(Interop.HeapUtil.Allocate<SharpVk.Khronos.StridedDeviceAddressRegion>());
                *marshalledRaygenShaderBindingTable = raygenShaderBindingTable;
                marshalledMissShaderBindingTable = (SharpVk.Khronos.StridedDeviceAddressRegion*)(Interop.HeapUtil.Allocate<SharpVk.Khronos.StridedDeviceAddressRegion>());
                *marshalledMissShaderBindingTable = missShaderBindingTable;
                marshalledHitShaderBindingTable = (SharpVk.Khronos.StridedDeviceAddressRegion*)(Interop.HeapUtil.Allocate<SharpVk.Khronos.StridedDeviceAddressRegion>());
                *marshalledHitShaderBindingTable = hitShaderBindingTable;
                marshalledCallableShaderBindingTable = (SharpVk.Khronos.StridedDeviceAddressRegion*)(Interop.HeapUtil.Allocate<SharpVk.Khronos.StridedDeviceAddressRegion>());
                *marshalledCallableShaderBindingTable = callableShaderBindingTable;
                SharpVk.Interop.Khronos.VkCommandBufferTraceRaysIndirectDelegate commandDelegate = commandCache.Cache.vkCmdTraceRaysIndirectKHR;
                commandDelegate(extendedHandle.handle, marshalledRaygenShaderBindingTable, marshalledMissShaderBindingTable, marshalledHitShaderBindingTable, marshalledCallableShaderBindingTable, indirectDeviceAddress);
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="pipelineStackSize">
        /// </param>
        public static unsafe void SetRayTracingPipelineStackSize(this SharpVk.CommandBuffer extendedHandle, uint pipelineStackSize)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkCommandBufferSetRayTracingPipelineStackSizeDelegate commandDelegate = commandCache.Cache.vkCmdSetRayTracingPipelineStackSizeKHR;
                commandDelegate(extendedHandle.handle, pipelineStackSize);
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="fragmentSize">
        /// </param>
        /// <param name="combinerOps">
        /// </param>
        public static unsafe void SetFragmentShadingRate(this SharpVk.CommandBuffer extendedHandle, SharpVk.Extent2D fragmentSize, SharpVk.Khronos.FragmentShadingRateCombinerOp combinerOps)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Extent2D* marshalledFragmentSize = default(SharpVk.Extent2D*);
                commandCache = extendedHandle.commandCache;
                marshalledFragmentSize = (SharpVk.Extent2D*)(Interop.HeapUtil.Allocate<SharpVk.Extent2D>());
                *marshalledFragmentSize = fragmentSize;
                SharpVk.Interop.Khronos.VkCommandBufferSetFragmentShadingRateDelegate commandDelegate = commandCache.Cache.vkCmdSetFragmentShadingRateKHR;
                commandDelegate(extendedHandle.handle, marshalledFragmentSize, combinerOps);
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="flags">
        /// </param>
        /// <param name="destinationBuffer">
        /// </param>
        /// <param name="destinationBufferOffset">
        /// </param>
        /// <param name="destinationBufferRange">
        /// </param>
        /// <param name="sourcePictureResource">
        /// </param>
        /// <param name="setupReferenceSlot">
        /// </param>
        /// <param name="referenceSlots">
        /// </param>
        /// <param name="precedingExternallyEncodedBytes">
        /// </param>
        /// <param name="videoInlineQueryInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="videoEncodeQuantizationMapInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="videoEncodeH264PictureInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="videoEncodeH265PictureInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="videoEncodeAV1PictureInfoKhr">
        /// Extension struct
        /// </param>
        /// <param name="videoEncodeIntraRefreshInfoKhr">
        /// Extension struct
        /// </param>
        public static unsafe void EncodeVideo(this SharpVk.CommandBuffer extendedHandle, SharpVk.Buffer destinationBuffer, ulong destinationBufferOffset, ulong destinationBufferRange, SharpVk.Khronos.VideoPictureResourceInfo sourcePictureResource, ArrayProxy<SharpVk.Khronos.VideoReferenceSlotInfo>? referenceSlots, uint precedingExternallyEncodedBytes, SharpVk.Khronos.VideoEncodeFlags? flags = default(SharpVk.Khronos.VideoEncodeFlags?), SharpVk.Khronos.VideoReferenceSlotInfo? setupReferenceSlot = default(SharpVk.Khronos.VideoReferenceSlotInfo?), SharpVk.Khronos.VideoInlineQueryInfo? videoInlineQueryInfoKhr = null, SharpVk.Khronos.VideoEncodeQuantizationMapInfo? videoEncodeQuantizationMapInfoKhr = null, SharpVk.Khronos.VideoEncodeH264PictureInfo? videoEncodeH264PictureInfoKhr = null, SharpVk.Khronos.VideoEncodeH265PictureInfo? videoEncodeH265PictureInfoKhr = null, SharpVk.Khronos.VideoEncodeAV1PictureInfo? videoEncodeAV1PictureInfoKhr = null, SharpVk.Khronos.VideoEncodeIntraRefreshInfo? videoEncodeIntraRefreshInfoKhr = null)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                SharpVk.Interop.Khronos.VideoEncodeInfo* marshalledEncodeInfo = default(SharpVk.Interop.Khronos.VideoEncodeInfo*);
                void* vkVideoEncodeInfoKHRNextPointer = default(void*);
                if (videoInlineQueryInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.VideoInlineQueryInfo* extensionPointer = default(SharpVk.Interop.Khronos.VideoInlineQueryInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.VideoInlineQueryInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoInlineQueryInfo>());
                    videoInlineQueryInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoEncodeInfoKHRNextPointer;
                    vkVideoEncodeInfoKHRNextPointer = extensionPointer;
                }
                if (videoEncodeQuantizationMapInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.VideoEncodeQuantizationMapInfo* extensionPointer = default(SharpVk.Interop.Khronos.VideoEncodeQuantizationMapInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.VideoEncodeQuantizationMapInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoEncodeQuantizationMapInfo>());
                    videoEncodeQuantizationMapInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoEncodeInfoKHRNextPointer;
                    vkVideoEncodeInfoKHRNextPointer = extensionPointer;
                }
                if (videoEncodeH264PictureInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.VideoEncodeH264PictureInfo* extensionPointer = default(SharpVk.Interop.Khronos.VideoEncodeH264PictureInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.VideoEncodeH264PictureInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoEncodeH264PictureInfo>());
                    videoEncodeH264PictureInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoEncodeInfoKHRNextPointer;
                    vkVideoEncodeInfoKHRNextPointer = extensionPointer;
                }
                if (videoEncodeH265PictureInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.VideoEncodeH265PictureInfo* extensionPointer = default(SharpVk.Interop.Khronos.VideoEncodeH265PictureInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.VideoEncodeH265PictureInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoEncodeH265PictureInfo>());
                    videoEncodeH265PictureInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoEncodeInfoKHRNextPointer;
                    vkVideoEncodeInfoKHRNextPointer = extensionPointer;
                }
                if (videoEncodeAV1PictureInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.VideoEncodeAV1PictureInfo* extensionPointer = default(SharpVk.Interop.Khronos.VideoEncodeAV1PictureInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.VideoEncodeAV1PictureInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoEncodeAV1PictureInfo>());
                    videoEncodeAV1PictureInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoEncodeInfoKHRNextPointer;
                    vkVideoEncodeInfoKHRNextPointer = extensionPointer;
                }
                if (videoEncodeIntraRefreshInfoKhr != null)
                {
                    SharpVk.Interop.Khronos.VideoEncodeIntraRefreshInfo* extensionPointer = default(SharpVk.Interop.Khronos.VideoEncodeIntraRefreshInfo*);
                    extensionPointer = (SharpVk.Interop.Khronos.VideoEncodeIntraRefreshInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoEncodeIntraRefreshInfo>());
                    videoEncodeIntraRefreshInfoKhr.Value.MarshalTo(extensionPointer);
                    extensionPointer->Next = vkVideoEncodeInfoKHRNextPointer;
                    vkVideoEncodeInfoKHRNextPointer = extensionPointer;
                }
                commandCache = extendedHandle.commandCache;
                marshalledEncodeInfo = (SharpVk.Interop.Khronos.VideoEncodeInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoEncodeInfo>());
                marshalledEncodeInfo->SType = StructureType.VideoEncodeInfo;
                marshalledEncodeInfo->Next = vkVideoEncodeInfoKHRNextPointer;
                if (flags != null)
                {
                    marshalledEncodeInfo->Flags = flags.Value;
                }
                else
                {
                    marshalledEncodeInfo->Flags = default(SharpVk.Khronos.VideoEncodeFlags);
                }
                marshalledEncodeInfo->DestinationBuffer = destinationBuffer?.handle ?? default(SharpVk.Interop.Buffer);
                marshalledEncodeInfo->DestinationBufferOffset = destinationBufferOffset;
                marshalledEncodeInfo->DestinationBufferRange = destinationBufferRange;
                sourcePictureResource.MarshalTo(&marshalledEncodeInfo->SourcePictureResource);
                if (setupReferenceSlot != null)
                {
                    marshalledEncodeInfo->SetupReferenceSlot = (SharpVk.Interop.Khronos.VideoReferenceSlotInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoReferenceSlotInfo>());
                    setupReferenceSlot.Value.MarshalTo(marshalledEncodeInfo->SetupReferenceSlot);
                }
                else
                {
                    marshalledEncodeInfo->SetupReferenceSlot = default(SharpVk.Interop.Khronos.VideoReferenceSlotInfo*);
                }
                marshalledEncodeInfo->ReferenceSlotCount = (uint)(Interop.HeapUtil.GetLength(referenceSlots));
                if (referenceSlots.IsNull())
                {
                    marshalledEncodeInfo->ReferenceSlots = null;
                }
                else
                {
                    if (referenceSlots.Value.Contents == ProxyContents.Single)
                    {
                        marshalledEncodeInfo->ReferenceSlots = (SharpVk.Interop.Khronos.VideoReferenceSlotInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Khronos.VideoReferenceSlotInfo>());
                        referenceSlots.Value.GetSingleValue().MarshalTo(&*(SharpVk.Interop.Khronos.VideoReferenceSlotInfo*)(marshalledEncodeInfo->ReferenceSlots));
                    }
                    else
                    {
                        var fieldPointer = (SharpVk.Interop.Khronos.VideoReferenceSlotInfo*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.VideoReferenceSlotInfo>(Interop.HeapUtil.GetLength(referenceSlots.Value)).ToPointer());
                        for(int index = 0; index < (uint)(Interop.HeapUtil.GetLength(referenceSlots.Value)); index++)
                        {
                            referenceSlots.Value[index].MarshalTo(&fieldPointer[index]);
                        }
                        marshalledEncodeInfo->ReferenceSlots = fieldPointer;
                    }
                }
                marshalledEncodeInfo->PrecedingExternallyEncodedBytes = precedingExternallyEncodedBytes;
                SharpVk.Interop.Khronos.VkCommandBufferEncodeVideoDelegate commandDelegate = commandCache.Cache.vkCmdEncodeVideoKHR;
                commandDelegate(extendedHandle.handle, marshalledEncodeInfo);
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
        /// The CommandBuffer handle to extend.
        /// </param>
        /// <param name="indirectDeviceAddress">
        /// </param>
        public static unsafe void TraceRaysIndirect2(this SharpVk.CommandBuffer extendedHandle, ulong indirectDeviceAddress)
        {
            try
            {
                CommandCache commandCache = default(CommandCache);
                commandCache = extendedHandle.commandCache;
                SharpVk.Interop.Khronos.VkCommandBufferTraceRaysIndirect2Delegate commandDelegate = commandCache.Cache.vkCmdTraceRaysIndirect2KHR;
                commandDelegate(extendedHandle.handle, indirectDeviceAddress);
            }
            finally
            {
                Interop.HeapUtil.FreeAll();
            }
        }
    }
}
