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

namespace SharpVk.Interop.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct PhysicalDeviceExtendedDynamicState3Features
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
        public Bool32 ExtendedDynamicState3TessellationDomainOrigin; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3DepthClampEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3PolygonMode; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3RasterizationSamples; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3SampleMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3AlphaToCoverageEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3AlphaToOneEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3LogicOpEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3ColorBlendEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3ColorBlendEquation; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3ColorWriteMask; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3RasterizationStream; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3ConservativeRasterizationMode; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3ExtraPrimitiveOverestimationSize; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3DepthClipEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3SampleLocationsEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3ColorBlendAdvanced; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3ProvokingVertexMode; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3LineRasterizationMode; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3LineStippleEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3DepthClipNegativeOneToOne; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3ViewportWScalingEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3ViewportSwizzle; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3CoverageToColorEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3CoverageToColorLocation; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3CoverageModulationMode; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3CoverageModulationTableEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3CoverageModulationTable; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3CoverageReductionMode; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3RepresentativeFragmentTestEnable; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 ExtendedDynamicState3ShadingRateImageEnable; 
    }
}
