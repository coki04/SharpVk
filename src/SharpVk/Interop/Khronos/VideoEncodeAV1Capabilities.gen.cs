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

namespace SharpVk.Interop.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VideoEncodeAV1Capabilities
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StructureType SType; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeAV1CapabilityFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public int MaxLevel; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D CodedPictureAlignment; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D MaxTiles; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D MinTileSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D MaxTileSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeAV1SuperblockSizeFlags SuperblockSizes; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSingleReferenceCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint SingleReferenceNameMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxUnidirectionalCompoundReferenceCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxUnidirectionalCompoundGroup1ReferenceCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint UnidirectionalCompoundReferenceNameMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxBidirectionalCompoundReferenceCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxBidirectionalCompoundGroup1ReferenceCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxBidirectionalCompoundGroup2ReferenceCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint BidirectionalCompoundReferenceNameMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTemporalLayerCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSpatialLayerCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxOperatingPoints; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MinQIndex; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxQIndex; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 PrefersGopRemainingFrames; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 RequiresGopRemainingFrames; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeAV1StdFlags StdSyntaxFlags; 
    }
}
