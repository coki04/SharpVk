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
using System.Runtime.InteropServices;

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct PhysicalDeviceVulkan13Properties
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
        public uint MinSubgroupSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxSubgroupSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxComputeWorkgroupSubgroups; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ShaderStageFlags RequiredSubgroupSizeStages; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxInlineUniformBlockSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorInlineUniformBlocks; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetInlineUniformBlocks; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxDescriptorSetUpdateAfterBindInlineUniformBlocks; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxInlineUniformTotalSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProduct8BitUnsignedAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProduct8BitSignedAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProduct8BitMixedSignednessAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProduct4X8BitPackedUnsignedAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProduct4X8BitPackedSignedAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProduct4X8BitPackedMixedSignednessAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProduct16BitUnsignedAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProduct16BitSignedAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProduct16BitMixedSignednessAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProduct32BitUnsignedAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProduct32BitSignedAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProduct32BitMixedSignednessAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProduct64BitUnsignedAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProduct64BitSignedAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProduct64BitMixedSignednessAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProductAccumulatingSaturating8BitUnsignedAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProductAccumulatingSaturating8BitSignedAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProductAccumulatingSaturating4X8BitPackedUnsignedAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProductAccumulatingSaturating4X8BitPackedSignedAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProductAccumulatingSaturating4X8BitPackedMixedSignednessAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProductAccumulatingSaturating16BitUnsignedAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProductAccumulatingSaturating16BitSignedAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProductAccumulatingSaturating32BitUnsignedAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProductAccumulatingSaturating32BitSignedAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProductAccumulatingSaturating64BitUnsignedAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProductAccumulatingSaturating64BitSignedAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 IntegerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong StorageTexelBufferOffsetAlignmentBytes; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 StorageTexelBufferOffsetSingleTexelAlignment; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong UniformTexelBufferOffsetAlignmentBytes; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 UniformTexelBufferOffsetSingleTexelAlignment; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong MaxBufferSize; 
    }
}
