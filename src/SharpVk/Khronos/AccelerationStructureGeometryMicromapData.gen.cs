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
    public partial struct AccelerationStructureGeometryMicromapData
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.MicromapUsage[] UsageCounts
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong Data
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong TriangleArray
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong TriangleArrayStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.AccelerationStructureGeometryMicromapData* pointer)
        {
            pointer->SType = StructureType.AccelerationStructureGeometryMicromapData;
            pointer->Next = null;
            pointer->UsageCountsCount = (uint)(Interop.HeapUtil.GetLength(this.UsageCounts));
            if (this.UsageCounts != null)
            {
                var fieldPointer = (SharpVk.Khronos.MicromapUsage*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Khronos.MicromapUsage>(this.UsageCounts.Length).ToPointer());
                for(int index = 0; index < (uint)(this.UsageCounts.Length); index++)
                {
                    fieldPointer[index] = this.UsageCounts[index];
                }
                pointer->UsageCounts = fieldPointer;
            }
            else
            {
                pointer->UsageCounts = null;
            }
            pointer->Data = this.Data;
            pointer->TriangleArray = this.TriangleArray;
            pointer->TriangleArrayStride = this.TriangleArrayStride;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe AccelerationStructureGeometryMicromapData MarshalFrom(SharpVk.Interop.Khronos.AccelerationStructureGeometryMicromapData* pointer)
        {
            AccelerationStructureGeometryMicromapData result = default(AccelerationStructureGeometryMicromapData);
            if (pointer->UsageCounts != null)
            {
                var fieldPointer = new SharpVk.Khronos.MicromapUsage[(uint)(pointer->UsageCountsCount)];
                for(int index = 0; index < (uint)(pointer->UsageCountsCount); index++)
                {
                    fieldPointer[index] = pointer->UsageCounts[index];
                }
                result.UsageCounts = fieldPointer;
            }
            else
            {
                result.UsageCounts = null;
            }
            result.Data = pointer->Data;
            result.TriangleArray = pointer->TriangleArray;
            result.TriangleArrayStride = pointer->TriangleArrayStride;
            return result;
        }
    }
}
