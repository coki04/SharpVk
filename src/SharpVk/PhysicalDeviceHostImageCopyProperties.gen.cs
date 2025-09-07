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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceHostImageCopyProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ImageLayout[] CopySourceLayouts
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ImageLayout[] CopyDestinationLayouts
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Guid OptimalTilingLayoutUUID
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IdenticalMemoryTypeRequirements
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.PhysicalDeviceHostImageCopyProperties* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceHostImageCopyPropertiesVersion;
            pointer->Next = null;
            pointer->CopySourceLayoutCount = (uint)(Interop.HeapUtil.GetLength(this.CopySourceLayouts));
            if (this.CopySourceLayouts != null)
            {
                var fieldPointer = (SharpVk.ImageLayout*)(Interop.HeapUtil.AllocateAndClear<SharpVk.ImageLayout>(this.CopySourceLayouts.Length).ToPointer());
                for(int index = 0; index < (uint)(this.CopySourceLayouts.Length); index++)
                {
                    fieldPointer[index] = this.CopySourceLayouts[index];
                }
                pointer->CopySourceLayouts = fieldPointer;
            }
            else
            {
                pointer->CopySourceLayouts = null;
            }
            pointer->CopyDestinationLayoutCount = (uint)(Interop.HeapUtil.GetLength(this.CopyDestinationLayouts));
            if (this.CopyDestinationLayouts != null)
            {
                var fieldPointer = (SharpVk.ImageLayout*)(Interop.HeapUtil.AllocateAndClear<SharpVk.ImageLayout>(this.CopyDestinationLayouts.Length).ToPointer());
                for(int index = 0; index < (uint)(this.CopyDestinationLayouts.Length); index++)
                {
                    fieldPointer[index] = this.CopyDestinationLayouts[index];
                }
                pointer->CopyDestinationLayouts = fieldPointer;
            }
            else
            {
                pointer->CopyDestinationLayouts = null;
            }
            Interop.HeapUtil.MarshalTo(this.OptimalTilingLayoutUUID, Constants.UuidSize, pointer->OptimalTilingLayoutUUID);
            pointer->IdenticalMemoryTypeRequirements = this.IdenticalMemoryTypeRequirements;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceHostImageCopyProperties MarshalFrom(SharpVk.Interop.PhysicalDeviceHostImageCopyProperties* pointer)
        {
            PhysicalDeviceHostImageCopyProperties result = default(PhysicalDeviceHostImageCopyProperties);
            if (pointer->CopySourceLayouts != null)
            {
                var fieldPointer = new SharpVk.ImageLayout[(uint)(pointer->CopySourceLayoutCount)];
                for(int index = 0; index < (uint)(pointer->CopySourceLayoutCount); index++)
                {
                    fieldPointer[index] = pointer->CopySourceLayouts[index];
                }
                result.CopySourceLayouts = fieldPointer;
            }
            else
            {
                result.CopySourceLayouts = null;
            }
            if (pointer->CopyDestinationLayouts != null)
            {
                var fieldPointer = new SharpVk.ImageLayout[(uint)(pointer->CopyDestinationLayoutCount)];
                for(int index = 0; index < (uint)(pointer->CopyDestinationLayoutCount); index++)
                {
                    fieldPointer[index] = pointer->CopyDestinationLayouts[index];
                }
                result.CopyDestinationLayouts = fieldPointer;
            }
            else
            {
                result.CopyDestinationLayouts = null;
            }
            result.OptimalTilingLayoutUUID = new Guid(Interop.HeapUtil.MarshalFrom(pointer->OptimalTilingLayoutUUID, Constants.UuidSize));
            result.IdenticalMemoryTypeRequirements = pointer->IdenticalMemoryTypeRequirements;
            return result;
        }
    }
}
