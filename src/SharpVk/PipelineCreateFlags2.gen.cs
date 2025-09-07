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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    [System.Flags]
    public enum PipelineCreateFlags2 : long
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        DisableOptimization = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        AllowDerivatives = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        Derivative = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        ViewIndexFromDeviceIndex = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        DispatchBase = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        FailOnPipelineCompileRequired = 1 << 8, 
        
        /// <summary>
        /// 
        /// </summary>
        EarlyReturnOnFailure = 1 << 9, 
        
        /// <summary>
        /// 
        /// </summary>
        NoProtectedAccess = 1 << 27, 
        
        /// <summary>
        /// 
        /// </summary>
        ProtectedAccessOnly = 1 << 30, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved46 = 1 << 46, 
        
        /// <summary>
        /// 
        /// </summary>
        ExecutionGraph = 1 << 32, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineCreate36 = 1 << 36, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineCreate39 = 1 << 39, 
        
        /// <summary>
        /// 
        /// </summary>
        PipelineCreate44 = 1 << 44, 
        
        /// <summary>
        /// 
        /// </summary>
        RayTracingAllowSpheresAndLinearSweptSpheres = 1 << 33, 
        
        /// <summary>
        /// 
        /// </summary>
        EnableLegacyDithering = 1 << 34, 
        
        /// <summary>
        /// 
        /// </summary>
        DeferCompile = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        CaptureStatistics = 1 << 6, 
        
        /// <summary>
        /// 
        /// </summary>
        CaptureInternalRepresentations = 1 << 7, 
        
        /// <summary>
        /// 
        /// </summary>
        LinkTimeOptimization = 1 << 10, 
        
        /// <summary>
        /// 
        /// </summary>
        RetainLinkTimeOptimizationInfo = 1 << 23, 
        
        /// <summary>
        /// 
        /// </summary>
        Library = 1 << 11, 
        
        /// <summary>
        /// 
        /// </summary>
        RayTracingSkipTriangles = 1 << 12, 
        
        /// <summary>
        /// 
        /// </summary>
        RayTracingSkipAabbs = 1 << 13, 
        
        /// <summary>
        /// 
        /// </summary>
        RayTracingNoNullAnyHitShaders = 1 << 14, 
        
        /// <summary>
        /// 
        /// </summary>
        RayTracingNoNullClosestHitShaders = 1 << 15, 
        
        /// <summary>
        /// 
        /// </summary>
        RayTracingNoNullMissShaders = 1 << 16, 
        
        /// <summary>
        /// 
        /// </summary>
        RayTracingNoNullIntersectionShaders = 1 << 17, 
        
        /// <summary>
        /// 
        /// </summary>
        RayTracingShaderGroupHandleCaptureReplay = 1 << 19, 
        
        /// <summary>
        /// 
        /// </summary>
        IndirectBindableKhr = 1 << 18, 
        
        /// <summary>
        /// 
        /// </summary>
        RayTracingAllowMotion = 1 << 20, 
        
        /// <summary>
        /// 
        /// </summary>
        RenderingFragmentShadingRateAttachment = 1 << 21, 
        
        /// <summary>
        /// 
        /// </summary>
        RenderingFragmentDensityMapAttachment = 1 << 22, 
        
        /// <summary>
        /// 
        /// </summary>
        RayTracingOpacityMicromap = 1 << 24, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorAttachmentFeedbackLoop = 1 << 25, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthStencilAttachmentFeedbackLoop = 1 << 26, 
        
        /// <summary>
        /// 
        /// </summary>
        RayTracingDisplacementMicromap = 1 << 28, 
        
        /// <summary>
        /// 
        /// </summary>
        DescriptorBuffer = 1 << 29, 
        
        /// <summary>
        /// 
        /// </summary>
        DisallowOpacityMicromap = 1 << 37, 
        
        /// <summary>
        /// 
        /// </summary>
        CaptureData = 1 << 31, 
        
        /// <summary>
        /// 
        /// </summary>
        IndirectBindableExt = 1 << 38, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved35 = 1 << 35, 
        
        /// <summary>
        /// 
        /// </summary>
        PerLayerFragmentDensity = 1 << 40, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved41 = 1 << 41, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved42 = 1 << 42, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved43 = 1 << 43, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved45 = 1 << 45, 
    }
}
