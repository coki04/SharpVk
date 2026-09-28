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
    public partial struct ClusterAccelerationStructureBuildTriangleClusterInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public uint ClusterID
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.ClusterAccelerationStructureClusterFlags? ClusterFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (uint, uint, uint, uint, uint, uint, uint, uint, uint) TriangleCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (uint, uint, uint, uint, uint, uint, uint, uint, uint) VertexCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (uint, uint, uint, uint, uint, uint) PositionTruncateBitCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (uint, uint, uint, uint) IndexType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (uint, uint, uint, uint) OpacityMicromapIndexType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.ClusterAccelerationStructureGeometryIndexAndGeometryFlags BaseGeometryIndexAndGeometryFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort IndexBufferStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort VertexBufferStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort GeometryIndexAndFlagsBufferStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort OpacityMicromapIndexBufferStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong IndexBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong VertexBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong? GeometryIndexAndFlagsBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong? OpacityMicromapArray
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong? OpacityMicromapIndexBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.ClusterAccelerationStructureBuildTriangleClusterInfo* pointer)
        {
            pointer->ClusterID = this.ClusterID;
            if (this.ClusterFlags != null)
            {
                pointer->ClusterFlags = this.ClusterFlags.Value;
            }
            else
            {
                pointer->ClusterFlags = default(SharpVk.NVidia.ClusterAccelerationStructureClusterFlags);
            }
            pointer->TriangleCount[0] = this.TriangleCount.Item1;
            pointer->TriangleCount[1] = this.TriangleCount.Item2;
            pointer->TriangleCount[2] = this.TriangleCount.Item3;
            pointer->TriangleCount[3] = this.TriangleCount.Item4;
            pointer->TriangleCount[4] = this.TriangleCount.Item5;
            pointer->TriangleCount[5] = this.TriangleCount.Item6;
            pointer->TriangleCount[6] = this.TriangleCount.Item7;
            pointer->TriangleCount[7] = this.TriangleCount.Item8;
            pointer->TriangleCount[8] = this.TriangleCount.Item9;
            pointer->VertexCount[0] = this.VertexCount.Item1;
            pointer->VertexCount[1] = this.VertexCount.Item2;
            pointer->VertexCount[2] = this.VertexCount.Item3;
            pointer->VertexCount[3] = this.VertexCount.Item4;
            pointer->VertexCount[4] = this.VertexCount.Item5;
            pointer->VertexCount[5] = this.VertexCount.Item6;
            pointer->VertexCount[6] = this.VertexCount.Item7;
            pointer->VertexCount[7] = this.VertexCount.Item8;
            pointer->VertexCount[8] = this.VertexCount.Item9;
            pointer->PositionTruncateBitCount[0] = this.PositionTruncateBitCount.Item1;
            pointer->PositionTruncateBitCount[1] = this.PositionTruncateBitCount.Item2;
            pointer->PositionTruncateBitCount[2] = this.PositionTruncateBitCount.Item3;
            pointer->PositionTruncateBitCount[3] = this.PositionTruncateBitCount.Item4;
            pointer->PositionTruncateBitCount[4] = this.PositionTruncateBitCount.Item5;
            pointer->PositionTruncateBitCount[5] = this.PositionTruncateBitCount.Item6;
            pointer->IndexType[0] = this.IndexType.Item1;
            pointer->IndexType[1] = this.IndexType.Item2;
            pointer->IndexType[2] = this.IndexType.Item3;
            pointer->IndexType[3] = this.IndexType.Item4;
            pointer->OpacityMicromapIndexType[0] = this.OpacityMicromapIndexType.Item1;
            pointer->OpacityMicromapIndexType[1] = this.OpacityMicromapIndexType.Item2;
            pointer->OpacityMicromapIndexType[2] = this.OpacityMicromapIndexType.Item3;
            pointer->OpacityMicromapIndexType[3] = this.OpacityMicromapIndexType.Item4;
            this.BaseGeometryIndexAndGeometryFlags.MarshalTo(&pointer->BaseGeometryIndexAndGeometryFlags);
            pointer->IndexBufferStride = this.IndexBufferStride;
            pointer->VertexBufferStride = this.VertexBufferStride;
            pointer->GeometryIndexAndFlagsBufferStride = this.GeometryIndexAndFlagsBufferStride;
            pointer->OpacityMicromapIndexBufferStride = this.OpacityMicromapIndexBufferStride;
            pointer->IndexBuffer = this.IndexBuffer;
            pointer->VertexBuffer = this.VertexBuffer;
            if (this.GeometryIndexAndFlagsBuffer != null)
            {
                pointer->GeometryIndexAndFlagsBuffer = this.GeometryIndexAndFlagsBuffer.Value;
            }
            else
            {
                pointer->GeometryIndexAndFlagsBuffer = default(ulong);
            }
            if (this.OpacityMicromapArray != null)
            {
                pointer->OpacityMicromapArray = this.OpacityMicromapArray.Value;
            }
            else
            {
                pointer->OpacityMicromapArray = default(ulong);
            }
            if (this.OpacityMicromapIndexBuffer != null)
            {
                pointer->OpacityMicromapIndexBuffer = this.OpacityMicromapIndexBuffer.Value;
            }
            else
            {
                pointer->OpacityMicromapIndexBuffer = default(ulong);
            }
        }
    }
}
