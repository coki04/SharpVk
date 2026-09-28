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
    public partial struct PhysicalDeviceImage2DViewOf3DFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        public bool Image2DViewOf3D
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool Sampler2DViewOf3D
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.PhysicalDeviceImage2DViewOf3DFeatures* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceImage2dViewOf3dFeatures;
            pointer->Next = null;
            pointer->Image2DViewOf3D = this.Image2DViewOf3D;
            pointer->Sampler2DViewOf3D = this.Sampler2DViewOf3D;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceImage2DViewOf3DFeatures MarshalFrom(SharpVk.Interop.Multivendor.PhysicalDeviceImage2DViewOf3DFeatures* pointer)
        {
            PhysicalDeviceImage2DViewOf3DFeatures result = default(PhysicalDeviceImage2DViewOf3DFeatures);
            result.Image2DViewOf3D = pointer->Image2DViewOf3D;
            result.Sampler2DViewOf3D = pointer->Sampler2DViewOf3D;
            return result;
        }
    }
}
