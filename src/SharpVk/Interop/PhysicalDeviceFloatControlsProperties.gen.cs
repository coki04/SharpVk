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

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct PhysicalDeviceFloatControlsProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StructureType SType; 
        
        /// <summary>
        /// 
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ShaderFloatControlsIndependence DenormBehaviorIndependence; 
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.ShaderFloatControlsIndependence RoundingModeIndependence; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderSignedZeroInfNanPreserveFloat16; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderSignedZeroInfNanPreserveFloat32; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderSignedZeroInfNanPreserveFloat64; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderDenormPreserveFloat16; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderDenormPreserveFloat32; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderDenormPreserveFloat64; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderDenormFlushToZeroFloat16; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderDenormFlushToZeroFloat32; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderDenormFlushToZeroFloat64; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderRoundingModeRTEFloat16; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderRoundingModeRTEFloat32; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderRoundingModeRTEFloat64; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderRoundingModeRTZFloat16; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderRoundingModeRTZFloat32; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ShaderRoundingModeRTZFloat64; 
    }
}
