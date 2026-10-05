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
    public partial struct StdVideoEncodeAV1DecoderModelInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public StdVideoEncodeAV1DecoderModelInfo(byte bufferDelayLengthMinus1, byte bufferRemovalTimeLengthMinus1, byte framePresentationTimeLengthMinus1, byte reserved1, uint numUnitsInDecodingTick)
        {
            this.BufferDelayLengthMinus1 = bufferDelayLengthMinus1;
            this.BufferRemovalTimeLengthMinus1 = bufferRemovalTimeLengthMinus1;
            this.FramePresentationTimeLengthMinus1 = framePresentationTimeLengthMinus1;
            this.Reserved1 = reserved1;
            this.NumUnitsInDecodingTick = numUnitsInDecodingTick;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte BufferDelayLengthMinus1; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte BufferRemovalTimeLengthMinus1; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte FramePresentationTimeLengthMinus1; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte Reserved1; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint NumUnitsInDecodingTick; 
    }
}
