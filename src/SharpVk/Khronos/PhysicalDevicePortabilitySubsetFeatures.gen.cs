// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2025
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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDevicePortabilitySubsetFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        public bool ConstantAlphaColorBlendFactors
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool Events
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ImageViewFormatReinterpretation
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ImageViewFormatSwizzle
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ImageView2DOn3DImage
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool MultisampleArrayImage
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool MutableComparisonSamplers
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool PointPolygons
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool SamplerMipLodBias
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool SeparateStencilMaskRef
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ShaderSampleRateInterpolationFunctions
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool TessellationIsolines
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool TessellationPointMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool TriangleFans
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool VertexAttributeAccessBeyondStride
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.PhysicalDevicePortabilitySubsetFeatures* pointer)
        {
            pointer->SType = StructureType.PhysicalDevicePortabilitySubsetFeatures;
            pointer->Next = null;
            pointer->ConstantAlphaColorBlendFactors = this.ConstantAlphaColorBlendFactors;
            pointer->Events = this.Events;
            pointer->ImageViewFormatReinterpretation = this.ImageViewFormatReinterpretation;
            pointer->ImageViewFormatSwizzle = this.ImageViewFormatSwizzle;
            pointer->ImageView2DOn3DImage = this.ImageView2DOn3DImage;
            pointer->MultisampleArrayImage = this.MultisampleArrayImage;
            pointer->MutableComparisonSamplers = this.MutableComparisonSamplers;
            pointer->PointPolygons = this.PointPolygons;
            pointer->SamplerMipLodBias = this.SamplerMipLodBias;
            pointer->SeparateStencilMaskRef = this.SeparateStencilMaskRef;
            pointer->ShaderSampleRateInterpolationFunctions = this.ShaderSampleRateInterpolationFunctions;
            pointer->TessellationIsolines = this.TessellationIsolines;
            pointer->TessellationPointMode = this.TessellationPointMode;
            pointer->TriangleFans = this.TriangleFans;
            pointer->VertexAttributeAccessBeyondStride = this.VertexAttributeAccessBeyondStride;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDevicePortabilitySubsetFeatures MarshalFrom(SharpVk.Interop.Khronos.PhysicalDevicePortabilitySubsetFeatures* pointer)
        {
            PhysicalDevicePortabilitySubsetFeatures result = default(PhysicalDevicePortabilitySubsetFeatures);
            result.ConstantAlphaColorBlendFactors = pointer->ConstantAlphaColorBlendFactors;
            result.Events = pointer->Events;
            result.ImageViewFormatReinterpretation = pointer->ImageViewFormatReinterpretation;
            result.ImageViewFormatSwizzle = pointer->ImageViewFormatSwizzle;
            result.ImageView2DOn3DImage = pointer->ImageView2DOn3DImage;
            result.MultisampleArrayImage = pointer->MultisampleArrayImage;
            result.MutableComparisonSamplers = pointer->MutableComparisonSamplers;
            result.PointPolygons = pointer->PointPolygons;
            result.SamplerMipLodBias = pointer->SamplerMipLodBias;
            result.SeparateStencilMaskRef = pointer->SeparateStencilMaskRef;
            result.ShaderSampleRateInterpolationFunctions = pointer->ShaderSampleRateInterpolationFunctions;
            result.TessellationIsolines = pointer->TessellationIsolines;
            result.TessellationPointMode = pointer->TessellationPointMode;
            result.TriangleFans = pointer->TriangleFans;
            result.VertexAttributeAccessBeyondStride = pointer->VertexAttributeAccessBeyondStride;
            return result;
        }
    }
}
