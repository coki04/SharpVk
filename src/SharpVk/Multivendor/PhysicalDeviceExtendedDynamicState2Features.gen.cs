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
    public partial struct PhysicalDeviceExtendedDynamicState2Features
    {
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState2LogicOp
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState2PatchControlPoints
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.PhysicalDeviceExtendedDynamicState2Features* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceExtendedDynamicState2Features;
            pointer->Next = null;
            pointer->ExtendedDynamicState2 = this.ExtendedDynamicState2;
            pointer->ExtendedDynamicState2LogicOp = this.ExtendedDynamicState2LogicOp;
            pointer->ExtendedDynamicState2PatchControlPoints = this.ExtendedDynamicState2PatchControlPoints;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceExtendedDynamicState2Features MarshalFrom(SharpVk.Interop.Multivendor.PhysicalDeviceExtendedDynamicState2Features* pointer)
        {
            PhysicalDeviceExtendedDynamicState2Features result = default(PhysicalDeviceExtendedDynamicState2Features);
            result.ExtendedDynamicState2 = pointer->ExtendedDynamicState2;
            result.ExtendedDynamicState2LogicOp = pointer->ExtendedDynamicState2LogicOp;
            result.ExtendedDynamicState2PatchControlPoints = pointer->ExtendedDynamicState2PatchControlPoints;
            return result;
        }
    }
}
