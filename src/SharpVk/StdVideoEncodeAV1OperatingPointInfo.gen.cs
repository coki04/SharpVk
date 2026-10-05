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
    public partial struct StdVideoEncodeAV1OperatingPointInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public StdVideoEncodeAV1OperatingPointInfo(SharpVk.StdVideoEncodeAV1OperatingPointInfoFlags flags, ushort operatingPointIdc, byte seqLevelIdx, byte seqTier, uint decoderBufferDelay, uint encoderBufferDelay, byte initialDisplayDelayMinus1)
        {
            this.Flags = flags;
            this.OperatingPointIdc = operatingPointIdc;
            this.SeqLevelIdx = seqLevelIdx;
            this.SeqTier = seqTier;
            this.DecoderBufferDelay = decoderBufferDelay;
            this.EncoderBufferDelay = encoderBufferDelay;
            this.InitialDisplayDelayMinus1 = initialDisplayDelayMinus1;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeAV1OperatingPointInfoFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public ushort OperatingPointIdc; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte SeqLevelIdx; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte SeqTier; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint DecoderBufferDelay; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint EncoderBufferDelay; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte InitialDisplayDelayMinus1; 
    }
}
