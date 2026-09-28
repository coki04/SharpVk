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

namespace SharpVk
{
    /// <summary>
    /// Bitmask controlling how a pipeline is generated.
    /// </summary>
    [System.Flags]
    public enum PipelineCreateFlags 
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// Specifies that the created pipeline will not be optimized. Using
        /// this flag may reduce the time taken to create the pipeline.
        /// </summary>
        DisableOptimization = 1 << 0, 
        
        /// <summary>
        /// Specifies that the pipeline to be created is allowed to be the
        /// parent of a pipeline that will be created in a subsequent call to
        /// flink:vkCreateGraphicsPipelines.
        /// </summary>
        AllowDerivatives = 1 << 1, 
        
        /// <summary>
        /// Specifies that the pipeline to be created will be a child of a
        /// previously created parent pipeline.
        /// </summary>
        Derivative = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        DispatchBaseCompute = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        ViewIndexFromDeviceIndex = 1 << 3, 
        
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
        RayTracingSkipTriangles = 1 << 12, 
        
        /// <summary>
        /// 
        /// </summary>
        RayTracingSkipAabbs = 1 << 13, 
        
        /// <summary>
        /// 
        /// </summary>
        RayTracingShaderGroupHandleCaptureReplay = 1 << 19, 
        
        /// <summary>
        /// 
        /// </summary>
        DeferCompile = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        RenderingFragmentDensityMapAttachment = 1 << 22, 
        
        /// <summary>
        /// 
        /// </summary>
        RenderingFragmentShadingRateAttachment = 1 << 21, 
        
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
        IndirectBindable = 1 << 18, 
        
        /// <summary>
        /// 
        /// </summary>
        Library = 1 << 11, 
        
        /// <summary>
        /// 
        /// </summary>
        DescriptorBuffer = 1 << 29, 
        
        /// <summary>
        /// 
        /// </summary>
        RetainLinkTimeOptimizationInfo = 1 << 23, 
        
        /// <summary>
        /// 
        /// </summary>
        LinkTimeOptimization = 1 << 10, 
        
        /// <summary>
        /// 
        /// </summary>
        RayTracingAllowMotion = 1 << 20, 
        
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
        RayTracingOpacityMicromap = 1 << 24, 
    }
}
