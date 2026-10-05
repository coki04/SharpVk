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
    public unsafe partial struct StdVideoAV1LoopFilter
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoAV1LoopFilterFlags Flags; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed byte LoopFilterLevel[checked((int)Constants.StdVideoAv1MaxLoopFilterStrengths)]; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte LoopFilterSharpness; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte UpdateRefDelta; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed sbyte LoopFilterRefDeltas[checked((int)Constants.StdVideoAv1TotalRefsPerFrame)]; 
        
        /// <summary>
        /// 
        /// </summary>
        public byte UpdateModeDelta; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed sbyte LoopFilterModeDeltas[checked((int)Constants.StdVideoAv1LoopFilterAdjustments)]; 
    }
}
