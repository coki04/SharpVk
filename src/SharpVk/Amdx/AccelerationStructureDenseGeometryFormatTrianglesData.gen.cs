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

namespace SharpVk.Amdx
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AccelerationStructureDenseGeometryFormatTrianglesData
    {
        /// <summary>
        /// 
        /// </summary>
        public IntPtr CompressedData
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong DataSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint NumTriangles
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint NumVertices
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxPrimitiveIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxGeometryIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Amdx.CompressedTriangleFormat Format
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Amdx.AccelerationStructureDenseGeometryFormatTrianglesData* pointer)
        {
            pointer->SType = StructureType.AccelerationStructureDenseGeometryFormatTrianglesData;
            pointer->Next = null;
            pointer->CompressedData = this.CompressedData;
            pointer->DataSize = this.DataSize;
            pointer->NumTriangles = this.NumTriangles;
            pointer->NumVertices = this.NumVertices;
            pointer->MaxPrimitiveIndex = this.MaxPrimitiveIndex;
            pointer->MaxGeometryIndex = this.MaxGeometryIndex;
            pointer->Format = this.Format;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe AccelerationStructureDenseGeometryFormatTrianglesData MarshalFrom(SharpVk.Interop.Amdx.AccelerationStructureDenseGeometryFormatTrianglesData* pointer)
        {
            AccelerationStructureDenseGeometryFormatTrianglesData result = default(AccelerationStructureDenseGeometryFormatTrianglesData);
            result.CompressedData = pointer->CompressedData;
            result.DataSize = pointer->DataSize;
            result.NumTriangles = pointer->NumTriangles;
            result.NumVertices = pointer->NumVertices;
            result.MaxPrimitiveIndex = pointer->MaxPrimitiveIndex;
            result.MaxGeometryIndex = pointer->MaxGeometryIndex;
            result.Format = pointer->Format;
            return result;
        }
    }
}
