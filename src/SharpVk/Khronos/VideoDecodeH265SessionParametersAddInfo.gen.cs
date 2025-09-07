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
    public partial struct VideoDecodeH265SessionParametersAddInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public IntPtr[] StdVPSs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr[] StdSPSs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr[] StdPPSs
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.VideoDecodeH265SessionParametersAddInfo* pointer)
        {
            pointer->SType = StructureType.VideoDecodeH265SessionParametersAddInfo;
            pointer->Next = null;
            pointer->StdVPSCount = (uint)(Interop.HeapUtil.GetLength(this.StdVPSs));
            if (this.StdVPSs != null)
            {
                var fieldPointer = (IntPtr*)(Interop.HeapUtil.AllocateAndClear<IntPtr>(this.StdVPSs.Length).ToPointer());
                for(int index = 0; index < (uint)(this.StdVPSs.Length); index++)
                {
                    fieldPointer[index] = this.StdVPSs[index];
                }
                pointer->StdVPSs = fieldPointer;
            }
            else
            {
                pointer->StdVPSs = null;
            }
            pointer->StdSPSCount = (uint)(Interop.HeapUtil.GetLength(this.StdSPSs));
            if (this.StdSPSs != null)
            {
                var fieldPointer = (IntPtr*)(Interop.HeapUtil.AllocateAndClear<IntPtr>(this.StdSPSs.Length).ToPointer());
                for(int index = 0; index < (uint)(this.StdSPSs.Length); index++)
                {
                    fieldPointer[index] = this.StdSPSs[index];
                }
                pointer->StdSPSs = fieldPointer;
            }
            else
            {
                pointer->StdSPSs = null;
            }
            pointer->StdPPSCount = (uint)(Interop.HeapUtil.GetLength(this.StdPPSs));
            if (this.StdPPSs != null)
            {
                var fieldPointer = (IntPtr*)(Interop.HeapUtil.AllocateAndClear<IntPtr>(this.StdPPSs.Length).ToPointer());
                for(int index = 0; index < (uint)(this.StdPPSs.Length); index++)
                {
                    fieldPointer[index] = this.StdPPSs[index];
                }
                pointer->StdPPSs = fieldPointer;
            }
            else
            {
                pointer->StdPPSs = null;
            }
        }
    }
}
