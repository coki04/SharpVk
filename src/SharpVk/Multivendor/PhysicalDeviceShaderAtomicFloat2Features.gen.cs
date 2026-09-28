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
    public partial struct PhysicalDeviceShaderAtomicFloat2Features
    {
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderBufferFloat16Atomics
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderBufferFloat16AtomicAdd
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderBufferFloat16AtomicMinMax
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderBufferFloat32AtomicMinMax
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderBufferFloat64AtomicMinMax
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderSharedFloat16Atomics
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderSharedFloat16AtomicAdd
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderSharedFloat16AtomicMinMax
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderSharedFloat32AtomicMinMax
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderSharedFloat64AtomicMinMax
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderImageFloat32AtomicMinMax
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool SparseImageFloat32AtomicMinMax
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.PhysicalDeviceShaderAtomicFloat2Features* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceShaderAtomicFloat2Features;
            pointer->Next = null;
            pointer->ShaderBufferFloat16Atomics = this.ShaderBufferFloat16Atomics;
            pointer->ShaderBufferFloat16AtomicAdd = this.ShaderBufferFloat16AtomicAdd;
            pointer->ShaderBufferFloat16AtomicMinMax = this.ShaderBufferFloat16AtomicMinMax;
            pointer->ShaderBufferFloat32AtomicMinMax = this.ShaderBufferFloat32AtomicMinMax;
            pointer->ShaderBufferFloat64AtomicMinMax = this.ShaderBufferFloat64AtomicMinMax;
            pointer->ShaderSharedFloat16Atomics = this.ShaderSharedFloat16Atomics;
            pointer->ShaderSharedFloat16AtomicAdd = this.ShaderSharedFloat16AtomicAdd;
            pointer->ShaderSharedFloat16AtomicMinMax = this.ShaderSharedFloat16AtomicMinMax;
            pointer->ShaderSharedFloat32AtomicMinMax = this.ShaderSharedFloat32AtomicMinMax;
            pointer->ShaderSharedFloat64AtomicMinMax = this.ShaderSharedFloat64AtomicMinMax;
            pointer->ShaderImageFloat32AtomicMinMax = this.ShaderImageFloat32AtomicMinMax;
            pointer->SparseImageFloat32AtomicMinMax = this.SparseImageFloat32AtomicMinMax;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceShaderAtomicFloat2Features MarshalFrom(SharpVk.Interop.Multivendor.PhysicalDeviceShaderAtomicFloat2Features* pointer)
        {
            PhysicalDeviceShaderAtomicFloat2Features result = default(PhysicalDeviceShaderAtomicFloat2Features);
            result.ShaderBufferFloat16Atomics = pointer->ShaderBufferFloat16Atomics;
            result.ShaderBufferFloat16AtomicAdd = pointer->ShaderBufferFloat16AtomicAdd;
            result.ShaderBufferFloat16AtomicMinMax = pointer->ShaderBufferFloat16AtomicMinMax;
            result.ShaderBufferFloat32AtomicMinMax = pointer->ShaderBufferFloat32AtomicMinMax;
            result.ShaderBufferFloat64AtomicMinMax = pointer->ShaderBufferFloat64AtomicMinMax;
            result.ShaderSharedFloat16Atomics = pointer->ShaderSharedFloat16Atomics;
            result.ShaderSharedFloat16AtomicAdd = pointer->ShaderSharedFloat16AtomicAdd;
            result.ShaderSharedFloat16AtomicMinMax = pointer->ShaderSharedFloat16AtomicMinMax;
            result.ShaderSharedFloat32AtomicMinMax = pointer->ShaderSharedFloat32AtomicMinMax;
            result.ShaderSharedFloat64AtomicMinMax = pointer->ShaderSharedFloat64AtomicMinMax;
            result.ShaderImageFloat32AtomicMinMax = pointer->ShaderImageFloat32AtomicMinMax;
            result.SparseImageFloat32AtomicMinMax = pointer->SparseImageFloat32AtomicMinMax;
            return result;
        }
    }
}
