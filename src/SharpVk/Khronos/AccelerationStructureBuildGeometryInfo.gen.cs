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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AccelerationStructureBuildGeometryInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.AccelerationStructureType Type
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.BuildAccelerationStructureFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.BuildAccelerationStructureMode Mode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.AccelerationStructure SourceAccelerationStructure
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.AccelerationStructure DestinationAccelerationStructure
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.AccelerationStructureGeometry[] Geometries
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public IntPtr ScratchData
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.AccelerationStructureBuildGeometryInfo* pointer)
        {
            pointer->SType = StructureType.AccelerationStructureBuildGeometryInfo;
            pointer->Next = null;
            pointer->Type = this.Type;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.Khronos.BuildAccelerationStructureFlags);
            }
            pointer->Mode = this.Mode;
            pointer->SourceAccelerationStructure = this.SourceAccelerationStructure?.handle ?? default(SharpVk.Interop.Khronos.AccelerationStructure);
            pointer->DestinationAccelerationStructure = this.DestinationAccelerationStructure?.handle ?? default(SharpVk.Interop.Khronos.AccelerationStructure);
            pointer->GeometryCount = (uint)(Interop.HeapUtil.GetLength(this.Geometries));
            if (this.Geometries != null)
            {
                var fieldPointer = (SharpVk.Interop.Khronos.AccelerationStructureGeometry*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Khronos.AccelerationStructureGeometry>(this.Geometries.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Geometries.Length); index++)
                {
                    this.Geometries[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->Geometries = fieldPointer;
            }
            else
            {
                pointer->Geometries = null;
            }
            pointer->ScratchData = this.ScratchData;
        }
    }
}
