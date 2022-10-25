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
using System.Runtime.InteropServices;

namespace SharpVk.Interop.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VideoEncodeH265Capabilities
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
        public SharpVk.Multivendor.VideoEncodeH265CapabilityFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.VideoEncodeH265InputModeFlags InputModeFlags; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.VideoEncodeH265OutputModeFlags OutputModeFlags; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.VideoEncodeH265CtbSizeFlags CtbSizes; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.VideoEncodeH265TransformBlockSizeFlags TransformBlockSizes; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxPPictureL0ReferenceCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxBPictureL0ReferenceCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxL1ReferenceCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxSubLayersCount; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte MinLog2MinLumaCodingBlockSizeMinus3; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxLog2MinLumaCodingBlockSizeMinus3; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte MinLog2MinLumaTransformBlockSizeMinus2; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxLog2MinLumaTransformBlockSizeMinus2; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte MinMaxTransformHierarchyDepthInter; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxMaxTransformHierarchyDepthInter; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte MinMaxTransformHierarchyDepthIntra; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxMaxTransformHierarchyDepthIntra; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxDiffCuQpDeltaDepth; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte MinMaxNumMergeCand; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxMaxNumMergeCand; 
    }
}
