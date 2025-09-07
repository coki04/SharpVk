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
    public partial struct ClusterAccelerationStructureInstantiateClusterInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public uint ClusterIdOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint) GeometryIndexOffset
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (uint, uint, uint, uint, uint, uint, uint, uint) Reserved
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong ClusterTemplateAddress
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.NVidia.StridedDeviceAddress VertexBuffer
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.ClusterAccelerationStructureInstantiateClusterInfo* pointer)
        {
            pointer->ClusterIdOffset = this.ClusterIdOffset;
            pointer->GeometryIndexOffset[0] = this.GeometryIndexOffset.Item1;
            pointer->GeometryIndexOffset[1] = this.GeometryIndexOffset.Item2;
            pointer->GeometryIndexOffset[2] = this.GeometryIndexOffset.Item3;
            pointer->GeometryIndexOffset[3] = this.GeometryIndexOffset.Item4;
            pointer->GeometryIndexOffset[4] = this.GeometryIndexOffset.Item5;
            pointer->GeometryIndexOffset[5] = this.GeometryIndexOffset.Item6;
            pointer->GeometryIndexOffset[6] = this.GeometryIndexOffset.Item7;
            pointer->GeometryIndexOffset[7] = this.GeometryIndexOffset.Item8;
            pointer->GeometryIndexOffset[8] = this.GeometryIndexOffset.Item9;
            pointer->GeometryIndexOffset[9] = this.GeometryIndexOffset.Item10;
            pointer->GeometryIndexOffset[10] = this.GeometryIndexOffset.Item11;
            pointer->GeometryIndexOffset[11] = this.GeometryIndexOffset.Item12;
            pointer->GeometryIndexOffset[12] = this.GeometryIndexOffset.Item13;
            pointer->GeometryIndexOffset[13] = this.GeometryIndexOffset.Item14;
            pointer->GeometryIndexOffset[14] = this.GeometryIndexOffset.Item15;
            pointer->GeometryIndexOffset[15] = this.GeometryIndexOffset.Item16;
            pointer->GeometryIndexOffset[16] = this.GeometryIndexOffset.Item17;
            pointer->GeometryIndexOffset[17] = this.GeometryIndexOffset.Item18;
            pointer->GeometryIndexOffset[18] = this.GeometryIndexOffset.Item19;
            pointer->GeometryIndexOffset[19] = this.GeometryIndexOffset.Item20;
            pointer->GeometryIndexOffset[20] = this.GeometryIndexOffset.Item21;
            pointer->GeometryIndexOffset[21] = this.GeometryIndexOffset.Item22;
            pointer->GeometryIndexOffset[22] = this.GeometryIndexOffset.Item23;
            pointer->GeometryIndexOffset[23] = this.GeometryIndexOffset.Item24;
            pointer->Reserved[0] = this.Reserved.Item1;
            pointer->Reserved[1] = this.Reserved.Item2;
            pointer->Reserved[2] = this.Reserved.Item3;
            pointer->Reserved[3] = this.Reserved.Item4;
            pointer->Reserved[4] = this.Reserved.Item5;
            pointer->Reserved[5] = this.Reserved.Item6;
            pointer->Reserved[6] = this.Reserved.Item7;
            pointer->Reserved[7] = this.Reserved.Item8;
            pointer->ClusterTemplateAddress = this.ClusterTemplateAddress;
            pointer->VertexBuffer = this.VertexBuffer;
        }
    }
}
