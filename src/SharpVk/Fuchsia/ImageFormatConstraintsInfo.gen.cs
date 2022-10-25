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

namespace SharpVk.Fuchsia
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImageFormatConstraintsInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ImageCreateInfo ImageCreateInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.FormatFeatureFlags RequiredFormatFeatures
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Fuchsia.ImageFormatConstraintsFlags? Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong? SysmemPixelFormat
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Fuchsia.SysmemColorSpace[] ColorSpaces
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Fuchsia.ImageFormatConstraintsInfo* pointer)
        {
            pointer->SType = StructureType.ImageFormatConstraintsInfo;
            pointer->Next = null;
            this.ImageCreateInfo.MarshalTo(&pointer->ImageCreateInfo);
            pointer->RequiredFormatFeatures = this.RequiredFormatFeatures;
            if (this.Flags != null)
            {
                pointer->Flags = this.Flags.Value;
            }
            else
            {
                pointer->Flags = default(SharpVk.Fuchsia.ImageFormatConstraintsFlags);
            }
            if (this.SysmemPixelFormat != null)
            {
                pointer->SysmemPixelFormat = this.SysmemPixelFormat.Value;
            }
            else
            {
                pointer->SysmemPixelFormat = default(ulong);
            }
            pointer->ColorSpaceCount = (uint)(Interop.HeapUtil.GetLength(this.ColorSpaces));
            if (this.ColorSpaces != null)
            {
                var fieldPointer = (SharpVk.Interop.Fuchsia.SysmemColorSpace*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.Fuchsia.SysmemColorSpace>(this.ColorSpaces.Length).ToPointer());
                for(int index = 0; index < (uint)(this.ColorSpaces.Length); index++)
                {
                    this.ColorSpaces[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->ColorSpaces = fieldPointer;
            }
            else
            {
                pointer->ColorSpaces = null;
            }
        }
    }
}
