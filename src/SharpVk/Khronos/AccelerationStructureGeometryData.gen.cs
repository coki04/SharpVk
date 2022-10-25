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
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct AccelerationStructureGeometryData
    {
        /// <summary>
        /// 
        /// </summary>
        [FieldOffset(0)]
        public SharpVk.Khronos.AccelerationStructureGeometryTrianglesData Triangles; 
        
        /// <summary>
        /// 
        /// </summary>
        [FieldOffset(0)]
        public SharpVk.Khronos.AccelerationStructureGeometryAabbsData Aabbs; 
        
        /// <summary>
        /// 
        /// </summary>
        [FieldOffset(0)]
        public SharpVk.Khronos.AccelerationStructureGeometryInstancesData Instances;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.AccelerationStructureGeometryData* pointer, SharpVk.Khronos.GeometryType GeometryType)
        {
            switch (GeometryType)
            {
                case GeometryType.Triangles:
                    this.Triangles.MarshalTo(&pointer->Triangles);
                    break;
                case GeometryType.Aabbs:
                    this.Aabbs.MarshalTo(&pointer->Aabbs);
                    break;
                case GeometryType.Instances:
                    this.Instances.MarshalTo(&pointer->Instances);
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe AccelerationStructureGeometryData MarshalFrom(SharpVk.Interop.Khronos.AccelerationStructureGeometryData* pointer, SharpVk.Khronos.GeometryType GeometryType)
        {
            AccelerationStructureGeometryData result = default(AccelerationStructureGeometryData);
            switch (GeometryType)
            {
                case GeometryType.Triangles:
                    //this.Triangles.MarshalFrom((SharpVk.Interop.Khronos.AccelerationStructureGeometryTrianglesData*)pointer->Triangles);
                    break;
                case GeometryType.Aabbs:
                    //this.Aabbs.MarshalFrom((SharpVk.Interop.Khronos.AccelerationStructureGeometryAabbsData*)pointer->Aabbs);
                    break;
                case GeometryType.Instances:
                    //this.Instances.MarshalFrom((SharpVk.Interop.Khronos.AccelerationStructureGeometryInstancesData*)pointer->Instances);
                    break;
            }
            return result;
        }
    }
}

namespace SharpVk.Interop.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct AccelerationStructureGeometryData
    {
        /// <summary>
        /// 
        /// </summary>
        [FieldOffset(0)]
        public SharpVk.Interop.Khronos.AccelerationStructureGeometryTrianglesData Triangles;

        /// <summary>
        /// 
        /// </summary>
        [FieldOffset(0)]
        public SharpVk.Interop.Khronos.AccelerationStructureGeometryAabbsData Aabbs;

        /// <summary>
        /// 
        /// </summary>
        [FieldOffset(0)]
        public SharpVk.Interop.Khronos.AccelerationStructureGeometryInstancesData Instances;
    }
}