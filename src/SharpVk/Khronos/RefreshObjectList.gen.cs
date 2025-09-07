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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct RefreshObjectList
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.RefreshObject[] Objects
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.RefreshObjectList* pointer)
        {
            pointer->SType = StructureType.RefreshObjectList;
            pointer->Next = null;
            pointer->ObjectCount = (uint)(Interop.HeapUtil.GetLength(this.Objects));
            if (this.Objects != null)
            {
                var fieldPointer = (SharpVk.Khronos.RefreshObject*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Khronos.RefreshObject>(this.Objects.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Objects.Length); index++)
                {
                    fieldPointer[index] = this.Objects[index];
                }
                pointer->Objects = fieldPointer;
            }
            else
            {
                pointer->Objects = null;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe RefreshObjectList MarshalFrom(SharpVk.Interop.Khronos.RefreshObjectList* pointer)
        {
            RefreshObjectList result = default(RefreshObjectList);
            if (pointer->Objects != null)
            {
                var fieldPointer = new SharpVk.Khronos.RefreshObject[(uint)(pointer->ObjectCount)];
                for(int index = 0; index < (uint)(pointer->ObjectCount); index++)
                {
                    fieldPointer[index] = pointer->Objects[index];
                }
                result.Objects = fieldPointer;
            }
            else
            {
                result.Objects = null;
            }
            return result;
        }
    }
}
