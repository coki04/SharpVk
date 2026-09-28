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
    public partial struct ConvertCooperativeVectorMatrixInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public HostSize SourceSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr SourceData
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize DestinationSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr DestinationData
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.ComponentType SourceComponentType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.ComponentType DestinationComponentType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint NumRows
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint NumColumns
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.CooperativeVectorMatrixLayout SourceLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize SourceStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.CooperativeVectorMatrixLayout DestinationLayout
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public HostSize DestinationStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.ConvertCooperativeVectorMatrixInfo* pointer)
        {
            pointer->SType = StructureType.ConvertCooperativeVectorMatrixInfo;
            pointer->Next = null;
            pointer->SourceSize = this.SourceSize;
            pointer->SourceData = this.SourceData;
            pointer->DestinationSize = (HostSize*)(Interop.HeapUtil.Allocate<HostSize>());
            *pointer->DestinationSize = this.DestinationSize;
            pointer->DestinationData = this.DestinationData;
            pointer->SourceComponentType = this.SourceComponentType;
            pointer->DestinationComponentType = this.DestinationComponentType;
            pointer->NumRows = this.NumRows;
            pointer->NumColumns = this.NumColumns;
            pointer->SourceLayout = this.SourceLayout;
            pointer->SourceStride = this.SourceStride;
            pointer->DestinationLayout = this.DestinationLayout;
            pointer->DestinationStride = this.DestinationStride;
        }
    }
}
