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
    public partial struct QueueFamilyGlobalPriorityProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public uint PriorityCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.QueueGlobalPriority[] Priorities
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.QueueFamilyGlobalPriorityProperties* pointer)
        {
            pointer->SType = StructureType.QueueFamilyGlobalPriorityPropertiesKhr;
            pointer->Next = null;
            pointer->PriorityCount = this.PriorityCount;
            if (this.Priorities != null && this.Priorities.Length >= 16)
            {
                pointer->Priorities_0 = this.Priorities[0];
                pointer->Priorities_1 = this.Priorities[1];
                pointer->Priorities_2 = this.Priorities[2];
                pointer->Priorities_3 = this.Priorities[3];
                pointer->Priorities_4 = this.Priorities[4];
                pointer->Priorities_5 = this.Priorities[5];
                pointer->Priorities_6 = this.Priorities[6];
                pointer->Priorities_7 = this.Priorities[7];
                pointer->Priorities_8 = this.Priorities[8];
                pointer->Priorities_9 = this.Priorities[9];
                pointer->Priorities_10 = this.Priorities[10];
                pointer->Priorities_11 = this.Priorities[11];
                pointer->Priorities_12 = this.Priorities[12];
                pointer->Priorities_13 = this.Priorities[13];
                pointer->Priorities_14 = this.Priorities[14];
                pointer->Priorities_15 = this.Priorities[15];
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe QueueFamilyGlobalPriorityProperties MarshalFrom(SharpVk.Interop.Khronos.QueueFamilyGlobalPriorityProperties* pointer)
        {
            QueueFamilyGlobalPriorityProperties result = default(QueueFamilyGlobalPriorityProperties);
            result.PriorityCount = pointer->PriorityCount;
            if (pointer->PriorityCount != 0)
            {
                var fieldPointer = new SharpVk.Khronos.QueueGlobalPriority[(uint)(pointer->PriorityCount)];
                for(int index = 0; index < (uint)(pointer->PriorityCount); index++)
                {
                    fieldPointer[index] = (&(pointer->Priorities_0))[index];
                }
                result.Priorities = fieldPointer;
            }
            else
            {
                result.Priorities = null;
            }
            return result;
        }
    }
}
