// The MIT License (MIT)
// 
// Copyright (c) Andrew Armstrong/FacticiusVir 2022
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
    public partial struct PhysicalDeviceFragmentShadingRateProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D MinFragmentShadingRateAttachmentTexelSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D MaxFragmentShadingRateAttachmentTexelSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxFragmentShadingRateAttachmentTexelSizeAspectRatio
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool PrimitiveFragmentShadingRateWithMultipleViewports
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool LayeredShadingRateAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool FragmentShadingRateNonTrivialCombinerOps
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D MaxFragmentSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxFragmentSizeAspectRatio
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint MaxFragmentShadingRateCoverageSamples
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.SampleCountFlags MaxFragmentShadingRateRasterizationSamples
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool FragmentShadingRateWithShaderDepthStencilWrites
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool FragmentShadingRateWithSampleMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool FragmentShadingRateWithShaderSampleMask
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool FragmentShadingRateWithConservativeRasterization
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool FragmentShadingRateWithFragmentShaderInterlock
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool FragmentShadingRateWithCustomSampleLocations
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool FragmentShadingRateStrictMultiplyCombiner
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceFragmentShadingRateProperties MarshalFrom(SharpVk.Interop.Khronos.PhysicalDeviceFragmentShadingRateProperties* pointer)
        {
            PhysicalDeviceFragmentShadingRateProperties result = default(PhysicalDeviceFragmentShadingRateProperties);
            result.MinFragmentShadingRateAttachmentTexelSize = pointer->MinFragmentShadingRateAttachmentTexelSize;
            result.MaxFragmentShadingRateAttachmentTexelSize = pointer->MaxFragmentShadingRateAttachmentTexelSize;
            result.MaxFragmentShadingRateAttachmentTexelSizeAspectRatio = pointer->MaxFragmentShadingRateAttachmentTexelSizeAspectRatio;
            result.PrimitiveFragmentShadingRateWithMultipleViewports = pointer->PrimitiveFragmentShadingRateWithMultipleViewports;
            result.LayeredShadingRateAttachments = pointer->LayeredShadingRateAttachments;
            result.FragmentShadingRateNonTrivialCombinerOps = pointer->FragmentShadingRateNonTrivialCombinerOps;
            result.MaxFragmentSize = pointer->MaxFragmentSize;
            result.MaxFragmentSizeAspectRatio = pointer->MaxFragmentSizeAspectRatio;
            result.MaxFragmentShadingRateCoverageSamples = pointer->MaxFragmentShadingRateCoverageSamples;
            result.MaxFragmentShadingRateRasterizationSamples = pointer->MaxFragmentShadingRateRasterizationSamples;
            result.FragmentShadingRateWithShaderDepthStencilWrites = pointer->FragmentShadingRateWithShaderDepthStencilWrites;
            result.FragmentShadingRateWithSampleMask = pointer->FragmentShadingRateWithSampleMask;
            result.FragmentShadingRateWithShaderSampleMask = pointer->FragmentShadingRateWithShaderSampleMask;
            result.FragmentShadingRateWithConservativeRasterization = pointer->FragmentShadingRateWithConservativeRasterization;
            result.FragmentShadingRateWithFragmentShaderInterlock = pointer->FragmentShadingRateWithFragmentShaderInterlock;
            result.FragmentShadingRateWithCustomSampleLocations = pointer->FragmentShadingRateWithCustomSampleLocations;
            result.FragmentShadingRateStrictMultiplyCombiner = pointer->FragmentShadingRateStrictMultiplyCombiner;
            return result;
        }
    }
}
