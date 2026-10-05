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
    public partial struct StdVideoAV1CDEF
    {
        /// <summary>
        /// 
        /// </summary>
        public byte CdefDampingMinus3
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte CdefBits
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] CdefYPriStrength
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] CdefYSecStrength
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] CdefUvPriStrength
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] CdefUvSecStrength
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoAV1CDEF* pointer)
        {
            pointer->CdefDampingMinus3 = this.CdefDampingMinus3;
            pointer->CdefBits = this.CdefBits;
            Interop.HeapUtil.MarshalTo(this.CdefYPriStrength, checked((int)Constants.StdVideoAv1MaxCdefFilterStrengths), pointer->CdefYPriStrength);
            Interop.HeapUtil.MarshalTo(this.CdefYSecStrength, checked((int)Constants.StdVideoAv1MaxCdefFilterStrengths), pointer->CdefYSecStrength);
            Interop.HeapUtil.MarshalTo(this.CdefUvPriStrength, checked((int)Constants.StdVideoAv1MaxCdefFilterStrengths), pointer->CdefUvPriStrength);
            Interop.HeapUtil.MarshalTo(this.CdefUvSecStrength, checked((int)Constants.StdVideoAv1MaxCdefFilterStrengths), pointer->CdefUvSecStrength);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe StdVideoAV1CDEF MarshalFrom(SharpVk.Interop.StdVideoAV1CDEF* pointer)
        {
            StdVideoAV1CDEF result = default(StdVideoAV1CDEF);
            result.CdefDampingMinus3 = pointer->CdefDampingMinus3;
            result.CdefBits = pointer->CdefBits;
            result.CdefYPriStrength = Interop.HeapUtil.MarshalFrom(pointer->CdefYPriStrength, checked((int)Constants.StdVideoAv1MaxCdefFilterStrengths));
            result.CdefYSecStrength = Interop.HeapUtil.MarshalFrom(pointer->CdefYSecStrength, checked((int)Constants.StdVideoAv1MaxCdefFilterStrengths));
            result.CdefUvPriStrength = Interop.HeapUtil.MarshalFrom(pointer->CdefUvPriStrength, checked((int)Constants.StdVideoAv1MaxCdefFilterStrengths));
            result.CdefUvSecStrength = Interop.HeapUtil.MarshalFrom(pointer->CdefUvSecStrength, checked((int)Constants.StdVideoAv1MaxCdefFilterStrengths));
            return result;
        }
    }
}
