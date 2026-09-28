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

namespace SharpVk.NVidia
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct CudaLaunchInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.CudaFunction Function
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint GridDimX
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint GridDimY
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint GridDimZ
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint BlockDimX
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint BlockDimY
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint BlockDimZ
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint SharedMemBytes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr[] Params
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr[] Extras
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.CudaLaunchInfo* pointer)
        {
            pointer->SType = StructureType.CudaLaunchInfo;
            pointer->Next = null;
            pointer->Function = this.Function?.handle ?? default(SharpVk.Interop.NVidia.CudaFunction);
            pointer->GridDimX = this.GridDimX;
            pointer->GridDimY = this.GridDimY;
            pointer->GridDimZ = this.GridDimZ;
            pointer->BlockDimX = this.BlockDimX;
            pointer->BlockDimY = this.BlockDimY;
            pointer->BlockDimZ = this.BlockDimZ;
            pointer->SharedMemBytes = this.SharedMemBytes;
            pointer->ParamCount = (HostSize)(Interop.HeapUtil.GetLength(this.Params));
            pointer->ExtraCount = (HostSize)(Interop.HeapUtil.GetLength(this.Extras));
        }
    }
}
