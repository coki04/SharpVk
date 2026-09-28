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
    public partial struct PhysicalDeviceExtendedDynamicState3Features
    {
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3TessellationDomainOrigin
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3DepthClampEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3PolygonMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3RasterizationSamples
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3SampleMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3AlphaToCoverageEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3AlphaToOneEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3LogicOpEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3ColorBlendEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3ColorBlendEquation
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3ColorWriteMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3RasterizationStream
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3ConservativeRasterizationMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3ExtraPrimitiveOverestimationSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3DepthClipEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3SampleLocationsEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3ColorBlendAdvanced
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3ProvokingVertexMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3LineRasterizationMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3LineStippleEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3DepthClipNegativeOneToOne
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3ViewportWScalingEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3ViewportSwizzle
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3CoverageToColorEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3CoverageToColorLocation
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3CoverageModulationMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3CoverageModulationTableEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3CoverageModulationTable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3CoverageReductionMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3RepresentativeFragmentTestEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ExtendedDynamicState3ShadingRateImageEnable
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.PhysicalDeviceExtendedDynamicState3Features* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceExtendedDynamicState3Features;
            pointer->Next = null;
            pointer->ExtendedDynamicState3TessellationDomainOrigin = this.ExtendedDynamicState3TessellationDomainOrigin;
            pointer->ExtendedDynamicState3DepthClampEnable = this.ExtendedDynamicState3DepthClampEnable;
            pointer->ExtendedDynamicState3PolygonMode = this.ExtendedDynamicState3PolygonMode;
            pointer->ExtendedDynamicState3RasterizationSamples = this.ExtendedDynamicState3RasterizationSamples;
            pointer->ExtendedDynamicState3SampleMask = this.ExtendedDynamicState3SampleMask;
            pointer->ExtendedDynamicState3AlphaToCoverageEnable = this.ExtendedDynamicState3AlphaToCoverageEnable;
            pointer->ExtendedDynamicState3AlphaToOneEnable = this.ExtendedDynamicState3AlphaToOneEnable;
            pointer->ExtendedDynamicState3LogicOpEnable = this.ExtendedDynamicState3LogicOpEnable;
            pointer->ExtendedDynamicState3ColorBlendEnable = this.ExtendedDynamicState3ColorBlendEnable;
            pointer->ExtendedDynamicState3ColorBlendEquation = this.ExtendedDynamicState3ColorBlendEquation;
            pointer->ExtendedDynamicState3ColorWriteMask = this.ExtendedDynamicState3ColorWriteMask;
            pointer->ExtendedDynamicState3RasterizationStream = this.ExtendedDynamicState3RasterizationStream;
            pointer->ExtendedDynamicState3ConservativeRasterizationMode = this.ExtendedDynamicState3ConservativeRasterizationMode;
            pointer->ExtendedDynamicState3ExtraPrimitiveOverestimationSize = this.ExtendedDynamicState3ExtraPrimitiveOverestimationSize;
            pointer->ExtendedDynamicState3DepthClipEnable = this.ExtendedDynamicState3DepthClipEnable;
            pointer->ExtendedDynamicState3SampleLocationsEnable = this.ExtendedDynamicState3SampleLocationsEnable;
            pointer->ExtendedDynamicState3ColorBlendAdvanced = this.ExtendedDynamicState3ColorBlendAdvanced;
            pointer->ExtendedDynamicState3ProvokingVertexMode = this.ExtendedDynamicState3ProvokingVertexMode;
            pointer->ExtendedDynamicState3LineRasterizationMode = this.ExtendedDynamicState3LineRasterizationMode;
            pointer->ExtendedDynamicState3LineStippleEnable = this.ExtendedDynamicState3LineStippleEnable;
            pointer->ExtendedDynamicState3DepthClipNegativeOneToOne = this.ExtendedDynamicState3DepthClipNegativeOneToOne;
            pointer->ExtendedDynamicState3ViewportWScalingEnable = this.ExtendedDynamicState3ViewportWScalingEnable;
            pointer->ExtendedDynamicState3ViewportSwizzle = this.ExtendedDynamicState3ViewportSwizzle;
            pointer->ExtendedDynamicState3CoverageToColorEnable = this.ExtendedDynamicState3CoverageToColorEnable;
            pointer->ExtendedDynamicState3CoverageToColorLocation = this.ExtendedDynamicState3CoverageToColorLocation;
            pointer->ExtendedDynamicState3CoverageModulationMode = this.ExtendedDynamicState3CoverageModulationMode;
            pointer->ExtendedDynamicState3CoverageModulationTableEnable = this.ExtendedDynamicState3CoverageModulationTableEnable;
            pointer->ExtendedDynamicState3CoverageModulationTable = this.ExtendedDynamicState3CoverageModulationTable;
            pointer->ExtendedDynamicState3CoverageReductionMode = this.ExtendedDynamicState3CoverageReductionMode;
            pointer->ExtendedDynamicState3RepresentativeFragmentTestEnable = this.ExtendedDynamicState3RepresentativeFragmentTestEnable;
            pointer->ExtendedDynamicState3ShadingRateImageEnable = this.ExtendedDynamicState3ShadingRateImageEnable;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceExtendedDynamicState3Features MarshalFrom(SharpVk.Interop.Multivendor.PhysicalDeviceExtendedDynamicState3Features* pointer)
        {
            PhysicalDeviceExtendedDynamicState3Features result = default(PhysicalDeviceExtendedDynamicState3Features);
            result.ExtendedDynamicState3TessellationDomainOrigin = pointer->ExtendedDynamicState3TessellationDomainOrigin;
            result.ExtendedDynamicState3DepthClampEnable = pointer->ExtendedDynamicState3DepthClampEnable;
            result.ExtendedDynamicState3PolygonMode = pointer->ExtendedDynamicState3PolygonMode;
            result.ExtendedDynamicState3RasterizationSamples = pointer->ExtendedDynamicState3RasterizationSamples;
            result.ExtendedDynamicState3SampleMask = pointer->ExtendedDynamicState3SampleMask;
            result.ExtendedDynamicState3AlphaToCoverageEnable = pointer->ExtendedDynamicState3AlphaToCoverageEnable;
            result.ExtendedDynamicState3AlphaToOneEnable = pointer->ExtendedDynamicState3AlphaToOneEnable;
            result.ExtendedDynamicState3LogicOpEnable = pointer->ExtendedDynamicState3LogicOpEnable;
            result.ExtendedDynamicState3ColorBlendEnable = pointer->ExtendedDynamicState3ColorBlendEnable;
            result.ExtendedDynamicState3ColorBlendEquation = pointer->ExtendedDynamicState3ColorBlendEquation;
            result.ExtendedDynamicState3ColorWriteMask = pointer->ExtendedDynamicState3ColorWriteMask;
            result.ExtendedDynamicState3RasterizationStream = pointer->ExtendedDynamicState3RasterizationStream;
            result.ExtendedDynamicState3ConservativeRasterizationMode = pointer->ExtendedDynamicState3ConservativeRasterizationMode;
            result.ExtendedDynamicState3ExtraPrimitiveOverestimationSize = pointer->ExtendedDynamicState3ExtraPrimitiveOverestimationSize;
            result.ExtendedDynamicState3DepthClipEnable = pointer->ExtendedDynamicState3DepthClipEnable;
            result.ExtendedDynamicState3SampleLocationsEnable = pointer->ExtendedDynamicState3SampleLocationsEnable;
            result.ExtendedDynamicState3ColorBlendAdvanced = pointer->ExtendedDynamicState3ColorBlendAdvanced;
            result.ExtendedDynamicState3ProvokingVertexMode = pointer->ExtendedDynamicState3ProvokingVertexMode;
            result.ExtendedDynamicState3LineRasterizationMode = pointer->ExtendedDynamicState3LineRasterizationMode;
            result.ExtendedDynamicState3LineStippleEnable = pointer->ExtendedDynamicState3LineStippleEnable;
            result.ExtendedDynamicState3DepthClipNegativeOneToOne = pointer->ExtendedDynamicState3DepthClipNegativeOneToOne;
            result.ExtendedDynamicState3ViewportWScalingEnable = pointer->ExtendedDynamicState3ViewportWScalingEnable;
            result.ExtendedDynamicState3ViewportSwizzle = pointer->ExtendedDynamicState3ViewportSwizzle;
            result.ExtendedDynamicState3CoverageToColorEnable = pointer->ExtendedDynamicState3CoverageToColorEnable;
            result.ExtendedDynamicState3CoverageToColorLocation = pointer->ExtendedDynamicState3CoverageToColorLocation;
            result.ExtendedDynamicState3CoverageModulationMode = pointer->ExtendedDynamicState3CoverageModulationMode;
            result.ExtendedDynamicState3CoverageModulationTableEnable = pointer->ExtendedDynamicState3CoverageModulationTableEnable;
            result.ExtendedDynamicState3CoverageModulationTable = pointer->ExtendedDynamicState3CoverageModulationTable;
            result.ExtendedDynamicState3CoverageReductionMode = pointer->ExtendedDynamicState3CoverageReductionMode;
            result.ExtendedDynamicState3RepresentativeFragmentTestEnable = pointer->ExtendedDynamicState3RepresentativeFragmentTestEnable;
            result.ExtendedDynamicState3ShadingRateImageEnable = pointer->ExtendedDynamicState3ShadingRateImageEnable;
            return result;
        }
    }
}
