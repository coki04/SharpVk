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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDevicePresentTimingFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        public bool PresentTiming
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool PresentAtAbsoluteTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool PresentAtRelativeTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.PhysicalDevicePresentTimingFeatures* pointer)
        {
            pointer->SType = StructureType.PhysicalDevicePresentTimingFeatures;
            pointer->Next = null;
            pointer->PresentTiming = this.PresentTiming;
            pointer->PresentAtAbsoluteTime = this.PresentAtAbsoluteTime;
            pointer->PresentAtRelativeTime = this.PresentAtRelativeTime;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDevicePresentTimingFeatures MarshalFrom(SharpVk.Interop.Multivendor.PhysicalDevicePresentTimingFeatures* pointer)
        {
            PhysicalDevicePresentTimingFeatures result = default(PhysicalDevicePresentTimingFeatures);
            result.PresentTiming = pointer->PresentTiming;
            result.PresentAtAbsoluteTime = pointer->PresentAtAbsoluteTime;
            result.PresentAtRelativeTime = pointer->PresentAtRelativeTime;
            return result;
        }
    }
}
