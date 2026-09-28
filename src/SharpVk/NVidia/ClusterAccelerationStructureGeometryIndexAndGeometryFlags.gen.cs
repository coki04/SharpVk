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
    public partial struct ClusterAccelerationStructureGeometryIndexAndGeometryFlags
    {
        /// <summary>
        /// 
        /// </summary>
        public (uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint) GeometryIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (uint, uint, uint, uint, uint) Reserved
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (uint, uint, uint) GeometryFlags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.NVidia.ClusterAccelerationStructureGeometryIndexAndGeometryFlags* pointer)
        {
            pointer->GeometryIndex[0] = this.GeometryIndex.Item1;
            pointer->GeometryIndex[1] = this.GeometryIndex.Item2;
            pointer->GeometryIndex[2] = this.GeometryIndex.Item3;
            pointer->GeometryIndex[3] = this.GeometryIndex.Item4;
            pointer->GeometryIndex[4] = this.GeometryIndex.Item5;
            pointer->GeometryIndex[5] = this.GeometryIndex.Item6;
            pointer->GeometryIndex[6] = this.GeometryIndex.Item7;
            pointer->GeometryIndex[7] = this.GeometryIndex.Item8;
            pointer->GeometryIndex[8] = this.GeometryIndex.Item9;
            pointer->GeometryIndex[9] = this.GeometryIndex.Item10;
            pointer->GeometryIndex[10] = this.GeometryIndex.Item11;
            pointer->GeometryIndex[11] = this.GeometryIndex.Item12;
            pointer->GeometryIndex[12] = this.GeometryIndex.Item13;
            pointer->GeometryIndex[13] = this.GeometryIndex.Item14;
            pointer->GeometryIndex[14] = this.GeometryIndex.Item15;
            pointer->GeometryIndex[15] = this.GeometryIndex.Item16;
            pointer->GeometryIndex[16] = this.GeometryIndex.Item17;
            pointer->GeometryIndex[17] = this.GeometryIndex.Item18;
            pointer->GeometryIndex[18] = this.GeometryIndex.Item19;
            pointer->GeometryIndex[19] = this.GeometryIndex.Item20;
            pointer->GeometryIndex[20] = this.GeometryIndex.Item21;
            pointer->GeometryIndex[21] = this.GeometryIndex.Item22;
            pointer->GeometryIndex[22] = this.GeometryIndex.Item23;
            pointer->GeometryIndex[23] = this.GeometryIndex.Item24;
            pointer->Reserved[0] = this.Reserved.Item1;
            pointer->Reserved[1] = this.Reserved.Item2;
            pointer->Reserved[2] = this.Reserved.Item3;
            pointer->Reserved[3] = this.Reserved.Item4;
            pointer->Reserved[4] = this.Reserved.Item5;
            pointer->GeometryFlags[0] = this.GeometryFlags.Item1;
            pointer->GeometryFlags[1] = this.GeometryFlags.Item2;
            pointer->GeometryFlags[2] = this.GeometryFlags.Item3;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe ClusterAccelerationStructureGeometryIndexAndGeometryFlags MarshalFrom(SharpVk.Interop.NVidia.ClusterAccelerationStructureGeometryIndexAndGeometryFlags* pointer)
        {
            ClusterAccelerationStructureGeometryIndexAndGeometryFlags result = default(ClusterAccelerationStructureGeometryIndexAndGeometryFlags);
            result.GeometryIndex = (pointer->GeometryIndex[0], pointer->GeometryIndex[1], pointer->GeometryIndex[2], pointer->GeometryIndex[3], pointer->GeometryIndex[4], pointer->GeometryIndex[5], pointer->GeometryIndex[6], pointer->GeometryIndex[7], pointer->GeometryIndex[8], pointer->GeometryIndex[9], pointer->GeometryIndex[10], pointer->GeometryIndex[11], pointer->GeometryIndex[12], pointer->GeometryIndex[13], pointer->GeometryIndex[14], pointer->GeometryIndex[15], pointer->GeometryIndex[16], pointer->GeometryIndex[17], pointer->GeometryIndex[18], pointer->GeometryIndex[19], pointer->GeometryIndex[20], pointer->GeometryIndex[21], pointer->GeometryIndex[22], pointer->GeometryIndex[23]);
            result.Reserved = (pointer->Reserved[0], pointer->Reserved[1], pointer->Reserved[2], pointer->Reserved[3], pointer->Reserved[4]);
            result.GeometryFlags = (pointer->GeometryFlags[0], pointer->GeometryFlags[1], pointer->GeometryFlags[2]);
            return result;
        }
    }
}
