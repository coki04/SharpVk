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
    public unsafe partial struct StdVideoEncodeH264SliceHeader
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeH264SliceHeaderFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint FirstMbInSlice; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264SliceType SliceType; 
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte SliceAlphaC0OffsetDiv2; 
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte SliceBetaOffsetDiv2; 
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte SliceQpDelta; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte Reserved1; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264CabacInitIdc CabacInitIdc; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH264DisableDeblockingFilterIdc DisableDeblockingFilterIdc; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.StdVideoEncodeH264WeightTable* WeightTable; 
    }
}
