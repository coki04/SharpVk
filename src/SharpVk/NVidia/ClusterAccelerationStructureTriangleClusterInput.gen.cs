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

namespace SharpVk.NVidia
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ClusterAccelerationStructureTriangleClusterInput
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
        public uint MaxGeometryIndexValue
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxClusterUniqueGeometryCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxClusterTriangleCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxClusterVertexCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTotalTriangleCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxTotalVertexCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MinPositionTruncateBitCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.ClusterAccelerationStructureTriangleClusterInput* pointer)
        {
            pointer->SType = StructureType.ClusterAccelerationStructureTriangleClusterInput;
            pointer->Next = null;
            pointer->VertexFormat = this.VertexFormat;
            pointer->MaxGeometryIndexValue = this.MaxGeometryIndexValue;
            pointer->MaxClusterUniqueGeometryCount = this.MaxClusterUniqueGeometryCount;
            pointer->MaxClusterTriangleCount = this.MaxClusterTriangleCount;
            pointer->MaxClusterVertexCount = this.MaxClusterVertexCount;
            pointer->MaxTotalTriangleCount = this.MaxTotalTriangleCount;
            pointer->MaxTotalVertexCount = this.MaxTotalVertexCount;
            pointer->MinPositionTruncateBitCount = this.MinPositionTruncateBitCount;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe ClusterAccelerationStructureTriangleClusterInput MarshalFrom(SharpVk.Interop.NVidia.ClusterAccelerationStructureTriangleClusterInput* pointer)
        {
            ClusterAccelerationStructureTriangleClusterInput result = default(ClusterAccelerationStructureTriangleClusterInput);
            result.VertexFormat = pointer->VertexFormat;
            result.MaxGeometryIndexValue = pointer->MaxGeometryIndexValue;
            result.MaxClusterUniqueGeometryCount = pointer->MaxClusterUniqueGeometryCount;
            result.MaxClusterTriangleCount = pointer->MaxClusterTriangleCount;
            result.MaxClusterVertexCount = pointer->MaxClusterVertexCount;
            result.MaxTotalTriangleCount = pointer->MaxTotalTriangleCount;
            result.MaxTotalVertexCount = pointer->MaxTotalVertexCount;
            result.MinPositionTruncateBitCount = pointer->MinPositionTruncateBitCount;
            return result;
        }
    }
}
