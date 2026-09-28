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
    public partial struct PhysicalDeviceCooperativeMatrixMaintenance1Features
    {
        /// <summary>
        /// 
        /// </summary>
        public bool CooperativeMatrixProperties2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool CooperativeMatrixReductions
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool CooperativeMatrixConversions
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool CooperativeMatrixPerElementOperations
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool CooperativeMatrixGetCoordinate
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.PhysicalDeviceCooperativeMatrixMaintenance1Features* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceCooperativeMatrixMaintenance1Features;
            pointer->Next = null;
            pointer->CooperativeMatrixProperties2 = this.CooperativeMatrixProperties2;
            pointer->CooperativeMatrixReductions = this.CooperativeMatrixReductions;
            pointer->CooperativeMatrixConversions = this.CooperativeMatrixConversions;
            pointer->CooperativeMatrixPerElementOperations = this.CooperativeMatrixPerElementOperations;
            pointer->CooperativeMatrixGetCoordinate = this.CooperativeMatrixGetCoordinate;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceCooperativeMatrixMaintenance1Features MarshalFrom(SharpVk.Interop.Multivendor.PhysicalDeviceCooperativeMatrixMaintenance1Features* pointer)
        {
            PhysicalDeviceCooperativeMatrixMaintenance1Features result = default(PhysicalDeviceCooperativeMatrixMaintenance1Features);
            result.CooperativeMatrixProperties2 = pointer->CooperativeMatrixProperties2;
            result.CooperativeMatrixReductions = pointer->CooperativeMatrixReductions;
            result.CooperativeMatrixConversions = pointer->CooperativeMatrixConversions;
            result.CooperativeMatrixPerElementOperations = pointer->CooperativeMatrixPerElementOperations;
            result.CooperativeMatrixGetCoordinate = pointer->CooperativeMatrixGetCoordinate;
            return result;
        }
    }
}
