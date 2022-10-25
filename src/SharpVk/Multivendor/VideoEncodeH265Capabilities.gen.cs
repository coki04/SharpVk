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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct VideoEncodeH265Capabilities
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.VideoEncodeH265CapabilityFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.VideoEncodeH265InputModeFlags InputModeFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.VideoEncodeH265OutputModeFlags OutputModeFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.VideoEncodeH265CtbSizeFlags CtbSizes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.VideoEncodeH265TransformBlockSizeFlags TransformBlockSizes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxPPictureL0ReferenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxBPictureL0ReferenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxL1ReferenceCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxSubLayersCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MinLog2MinLumaCodingBlockSizeMinus3
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxLog2MinLumaCodingBlockSizeMinus3
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MinLog2MinLumaTransformBlockSizeMinus2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxLog2MinLumaTransformBlockSizeMinus2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MinMaxTransformHierarchyDepthInter
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxMaxTransformHierarchyDepthInter
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MinMaxTransformHierarchyDepthIntra
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxMaxTransformHierarchyDepthIntra
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxDiffCuQpDeltaDepth
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MinMaxNumMergeCand
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte MaxMaxNumMergeCand
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe VideoEncodeH265Capabilities MarshalFrom(SharpVk.Interop.Multivendor.VideoEncodeH265Capabilities* pointer)
        {
            VideoEncodeH265Capabilities result = default(VideoEncodeH265Capabilities);
            result.Flags = pointer->Flags;
            result.InputModeFlags = pointer->InputModeFlags;
            result.OutputModeFlags = pointer->OutputModeFlags;
            result.CtbSizes = pointer->CtbSizes;
            result.TransformBlockSizes = pointer->TransformBlockSizes;
            result.MaxPPictureL0ReferenceCount = pointer->MaxPPictureL0ReferenceCount;
            result.MaxBPictureL0ReferenceCount = pointer->MaxBPictureL0ReferenceCount;
            result.MaxL1ReferenceCount = pointer->MaxL1ReferenceCount;
            result.MaxSubLayersCount = pointer->MaxSubLayersCount;
            result.MinLog2MinLumaCodingBlockSizeMinus3 = pointer->MinLog2MinLumaCodingBlockSizeMinus3;
            result.MaxLog2MinLumaCodingBlockSizeMinus3 = pointer->MaxLog2MinLumaCodingBlockSizeMinus3;
            result.MinLog2MinLumaTransformBlockSizeMinus2 = pointer->MinLog2MinLumaTransformBlockSizeMinus2;
            result.MaxLog2MinLumaTransformBlockSizeMinus2 = pointer->MaxLog2MinLumaTransformBlockSizeMinus2;
            result.MinMaxTransformHierarchyDepthInter = pointer->MinMaxTransformHierarchyDepthInter;
            result.MaxMaxTransformHierarchyDepthInter = pointer->MaxMaxTransformHierarchyDepthInter;
            result.MinMaxTransformHierarchyDepthIntra = pointer->MinMaxTransformHierarchyDepthIntra;
            result.MaxMaxTransformHierarchyDepthIntra = pointer->MaxMaxTransformHierarchyDepthIntra;
            result.MaxDiffCuQpDeltaDepth = pointer->MaxDiffCuQpDeltaDepth;
            result.MinMaxNumMergeCand = pointer->MinMaxNumMergeCand;
            result.MaxMaxNumMergeCand = pointer->MaxMaxNumMergeCand;
            return result;
        }
    }
}
