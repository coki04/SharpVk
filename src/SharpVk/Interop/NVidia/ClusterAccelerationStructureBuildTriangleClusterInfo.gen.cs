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

namespace SharpVk.Interop.NVidia
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct ClusterAccelerationStructureBuildTriangleClusterInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public uint ClusterID; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.ClusterAccelerationStructureClusterFlags ClusterFlags; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed uint TriangleCount[9]; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed uint VertexCount[9]; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed uint PositionTruncateBitCount[6]; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed uint IndexType[4]; 
        
        /// <summary>
        /// 
        /// </summary>
        public fixed uint OpacityMicromapIndexType[4]; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Interop.NVidia.ClusterAccelerationStructureGeometryIndexAndGeometryFlags BaseGeometryIndexAndGeometryFlags; 
        
        /// <summary>
        /// 
        /// </summary>
        public ushort IndexBufferStride; 
        
        /// <summary>
        /// 
        /// </summary>
        public ushort VertexBufferStride; 
        
        /// <summary>
        /// 
        /// </summary>
        public ushort GeometryIndexAndFlagsBufferStride; 
        
        /// <summary>
        /// 
        /// </summary>
        public ushort OpacityMicromapIndexBufferStride; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong IndexBuffer; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong VertexBuffer; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong GeometryIndexAndFlagsBuffer; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong OpacityMicromapArray; 
        
        /// <summary>
        /// 
        /// </summary>
        public ulong OpacityMicromapIndexBuffer; 
    }
}
