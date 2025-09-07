// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2025
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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct VideoEncodeAV1QIndex
    {
        /// <summary>
        /// 
        /// </summary>
        public static VideoEncodeAV1QIndex Zero => new VideoEncodeAV1QIndex();
        
        /// <summary>
        /// 
        /// </summary>
        public VideoEncodeAV1QIndex(uint intraQIndex, uint predictiveQIndex, uint bipredictiveQIndex)
        {
            this.IntraQIndex = intraQIndex;
            this.PredictiveQIndex = predictiveQIndex;
            this.BipredictiveQIndex = bipredictiveQIndex;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint IntraQIndex; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint PredictiveQIndex; 
        
        /// <summary>
        /// 
        /// </summary>
        public uint BipredictiveQIndex; 
    }
}
