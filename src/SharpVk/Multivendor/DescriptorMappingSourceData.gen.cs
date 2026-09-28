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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct DescriptorMappingSourceData
    {
        /// <summary>
        /// 
        /// </summary>
        [FieldOffset(0)]
        public SharpVk.Multivendor.DescriptorMappingSourceConstantOffset ConstantOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        [FieldOffset(0)]
        public SharpVk.Multivendor.DescriptorMappingSourcePushIndex PushIndex; 
        
        /// <summary>
        /// 
        /// </summary>
        [FieldOffset(0)]
        public SharpVk.Multivendor.DescriptorMappingSourceIndirectIndex IndirectIndex; 
        
        /// <summary>
        /// 
        /// </summary>
        [FieldOffset(0)]
        public SharpVk.Multivendor.DescriptorMappingSourceIndirectIndexArray IndirectIndexArray; 
        
        /// <summary>
        /// 
        /// </summary>
        [FieldOffset(0)]
        public SharpVk.Multivendor.DescriptorMappingSourceHeapData HeapData; 
        
        /// <summary>
        /// 
        /// </summary>
        [FieldOffset(0)]
        public uint PushDataOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        [FieldOffset(0)]
        public uint PushAddressOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        [FieldOffset(0)]
        public SharpVk.Multivendor.DescriptorMappingSourceIndirectAddress IndirectAddress; 
        
        /// <summary>
        /// 
        /// </summary>
        [FieldOffset(0)]
        public SharpVk.Multivendor.DescriptorMappingSourceShaderRecordIndex ShaderRecordIndex; 
        
        /// <summary>
        /// 
        /// </summary>
        [FieldOffset(0)]
        public uint ShaderRecordDataOffset; 
        
        /// <summary>
        /// 
        /// </summary>
        [FieldOffset(0)]
        public uint ShaderRecordAddressOffset; 
    }
}
