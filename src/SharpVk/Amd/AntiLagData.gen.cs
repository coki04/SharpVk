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

namespace SharpVk.Amd
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AntiLagData
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Amd.AntiLagMode Mode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxFPS
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Amd.AntiLagPresentationInfo? PresentationInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Amd.AntiLagData* pointer)
        {
            pointer->SType = StructureType.AntiLagData;
            pointer->Next = null;
            pointer->Mode = this.Mode;
            pointer->MaxFPS = this.MaxFPS;
            if (this.PresentationInfo != null)
            {
                pointer->PresentationInfo = (SharpVk.Interop.Amd.AntiLagPresentationInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Amd.AntiLagPresentationInfo>());
                this.PresentationInfo.Value.MarshalTo(pointer->PresentationInfo);
            }
            else
            {
                pointer->PresentationInfo = default(SharpVk.Interop.Amd.AntiLagPresentationInfo*);
            }
        }
    }
}
