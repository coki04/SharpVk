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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct StdVideoAV1Quantization
    {
        /// <summary>
        /// 
        /// </summary>
        public StdVideoAV1Quantization(SharpVk.StdVideoAV1QuantizationFlags flags, byte baseQIdx, sbyte deltaQYDc, sbyte deltaQUDc, sbyte deltaQUAc, sbyte deltaQVDc, sbyte deltaQVAc, byte qmY, byte qmU, byte qmV)
        {
            this.Flags = flags;
            this.BaseQIdx = baseQIdx;
            this.DeltaQYDc = deltaQYDc;
            this.DeltaQUDc = deltaQUDc;
            this.DeltaQUAc = deltaQUAc;
            this.DeltaQVDc = deltaQVDc;
            this.DeltaQVAc = deltaQVAc;
            this.QmY = qmY;
            this.QmU = qmU;
            this.QmV = qmV;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1QuantizationFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte BaseQIdx; 
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte DeltaQYDc; 
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte DeltaQUDc; 
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte DeltaQUAc; 
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte DeltaQVDc; 
        
        /// <summary>
        /// 
        /// </summary>
        public sbyte DeltaQVAc; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte QmY; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte QmU; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte QmV; 
    }
}
