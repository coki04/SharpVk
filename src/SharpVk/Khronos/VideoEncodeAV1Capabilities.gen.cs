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
using System.Runtime.InteropServices;

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct VideoEncodeAV1Capabilities
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeAV1CapabilityFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public int MaxLevel
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D CodedPictureAlignment
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D MaxTiles
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D MinTileSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D MaxTileSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeAV1SuperblockSizeFlags SuperblockSizes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSingleReferenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint SingleReferenceNameMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxUnidirectionalCompoundReferenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxUnidirectionalCompoundGroup1ReferenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint UnidirectionalCompoundReferenceNameMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxBidirectionalCompoundReferenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxBidirectionalCompoundGroup1ReferenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxBidirectionalCompoundGroup2ReferenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint BidirectionalCompoundReferenceNameMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTemporalLayerCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSpatialLayerCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxOperatingPoints
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MinQIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxQIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool PrefersGopRemainingFrames
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool RequiresGopRemainingFrames
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeAV1StdFlags StdSyntaxFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe VideoEncodeAV1Capabilities MarshalFrom(SharpVk.Interop.Khronos.VideoEncodeAV1Capabilities* pointer)
        {
            VideoEncodeAV1Capabilities result = default(VideoEncodeAV1Capabilities);
            result.Flags = pointer->Flags;
            result.MaxLevel = pointer->MaxLevel;
            result.CodedPictureAlignment = pointer->CodedPictureAlignment;
            result.MaxTiles = pointer->MaxTiles;
            result.MinTileSize = pointer->MinTileSize;
            result.MaxTileSize = pointer->MaxTileSize;
            result.SuperblockSizes = pointer->SuperblockSizes;
            result.MaxSingleReferenceCount = pointer->MaxSingleReferenceCount;
            result.SingleReferenceNameMask = pointer->SingleReferenceNameMask;
            result.MaxUnidirectionalCompoundReferenceCount = pointer->MaxUnidirectionalCompoundReferenceCount;
            result.MaxUnidirectionalCompoundGroup1ReferenceCount = pointer->MaxUnidirectionalCompoundGroup1ReferenceCount;
            result.UnidirectionalCompoundReferenceNameMask = pointer->UnidirectionalCompoundReferenceNameMask;
            result.MaxBidirectionalCompoundReferenceCount = pointer->MaxBidirectionalCompoundReferenceCount;
            result.MaxBidirectionalCompoundGroup1ReferenceCount = pointer->MaxBidirectionalCompoundGroup1ReferenceCount;
            result.MaxBidirectionalCompoundGroup2ReferenceCount = pointer->MaxBidirectionalCompoundGroup2ReferenceCount;
            result.BidirectionalCompoundReferenceNameMask = pointer->BidirectionalCompoundReferenceNameMask;
            result.MaxTemporalLayerCount = pointer->MaxTemporalLayerCount;
            result.MaxSpatialLayerCount = pointer->MaxSpatialLayerCount;
            result.MaxOperatingPoints = pointer->MaxOperatingPoints;
            result.MinQIndex = pointer->MinQIndex;
            result.MaxQIndex = pointer->MaxQIndex;
            result.PrefersGopRemainingFrames = pointer->PrefersGopRemainingFrames;
            result.RequiresGopRemainingFrames = pointer->RequiresGopRemainingFrames;
            result.StdSyntaxFlags = pointer->StdSyntaxFlags;
            return result;
        }
    }
}
