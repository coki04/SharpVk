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
    public partial struct StdVideoAV1ColorConfig
    {
        /// <summary>
        /// 
        /// </summary>
        public StdVideoAV1ColorConfig(SharpVk.StdVideoAV1ColorConfigFlags flags, byte bitDepth, byte subsamplingX, byte subsamplingY, byte reserved1, SharpVk.StdVideoAV1ColorPrimaries colorPrimaries, SharpVk.StdVideoAV1TransferCharacteristics transferCharacteristics, SharpVk.StdVideoAV1MatrixCoefficients matrixCoefficients, SharpVk.StdVideoAV1ChromaSamplePosition chromaSamplePosition)
        {
            this.Flags = flags;
            this.BitDepth = bitDepth;
            this.SubsamplingX = subsamplingX;
            this.SubsamplingY = subsamplingY;
            this.Reserved1 = reserved1;
            this.ColorPrimaries = colorPrimaries;
            this.TransferCharacteristics = transferCharacteristics;
            this.MatrixCoefficients = matrixCoefficients;
            this.ChromaSamplePosition = chromaSamplePosition;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1ColorConfigFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte BitDepth; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte SubsamplingX; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte SubsamplingY; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte Reserved1; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1ColorPrimaries ColorPrimaries; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1TransferCharacteristics TransferCharacteristics; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1MatrixCoefficients MatrixCoefficients; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1ChromaSamplePosition ChromaSamplePosition; 
    }
}
