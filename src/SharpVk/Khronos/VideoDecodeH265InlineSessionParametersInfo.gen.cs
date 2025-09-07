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
    public partial struct VideoDecodeH265InlineSessionParametersInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public IntPtr? StdVPS
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr? StdSPS
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr? StdPPS
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.VideoDecodeH265InlineSessionParametersInfo* pointer)
        {
            pointer->SType = StructureType.VideoDecodeH265InlineSessionParametersInfo;
            pointer->Next = null;
            if (this.StdVPS != null)
            {
                pointer->StdVPS = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *pointer->StdVPS = this.StdVPS.Value;
            }
            else
            {
                pointer->StdVPS = default(IntPtr*);
            }
            if (this.StdSPS != null)
            {
                pointer->StdSPS = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *pointer->StdSPS = this.StdSPS.Value;
            }
            else
            {
                pointer->StdSPS = default(IntPtr*);
            }
            if (this.StdPPS != null)
            {
                pointer->StdPPS = (IntPtr*)(Interop.HeapUtil.Allocate<IntPtr>());
                *pointer->StdPPS = this.StdPPS.Value;
            }
            else
            {
                pointer->StdPPS = default(IntPtr*);
            }
        }
    }
}
