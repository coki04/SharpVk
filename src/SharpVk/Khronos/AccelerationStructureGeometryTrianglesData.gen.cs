// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2022
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
    public partial struct AccelerationStructureGeometryTrianglesData
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Format VertexFormat
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr VertexData
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong VertexStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxVertex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.IndexType IndexType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr IndexData
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr TransformData
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.AccelerationStructureGeometryTrianglesData* pointer)
        {
            pointer->SType = StructureType.AccelerationStructureGeometryTrianglesData;
            pointer->Next = null;
            pointer->VertexFormat = this.VertexFormat;
            pointer->VertexData = this.VertexData;
            pointer->VertexStride = this.VertexStride;
            pointer->MaxVertex = this.MaxVertex;
            pointer->IndexType = this.IndexType;
            pointer->IndexData = this.IndexData;
            pointer->TransformData = this.TransformData;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe AccelerationStructureGeometryTrianglesData MarshalFrom(SharpVk.Interop.Khronos.AccelerationStructureGeometryTrianglesData* pointer)
        {
            AccelerationStructureGeometryTrianglesData result = default(AccelerationStructureGeometryTrianglesData);
            result.VertexFormat = pointer->VertexFormat;
            result.VertexData = pointer->VertexData;
            result.VertexStride = pointer->VertexStride;
            result.MaxVertex = pointer->MaxVertex;
            result.IndexType = pointer->IndexType;
            result.IndexData = pointer->IndexData;
            result.TransformData = pointer->TransformData;
            return result;
        }
    }
}
