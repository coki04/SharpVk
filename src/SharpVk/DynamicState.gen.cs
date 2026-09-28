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
    /// Indicate which dynamic state is taken from dynamic state commands.
    /// </summary>
    public enum DynamicState 
    {
        /// <summary>
        /// Indicates that the pViewports state in
        /// PipelineViewportStateCreateInfo will be ignored and must be set
        /// dynamically with flink:vkCmdSetViewport before any draw commands.
        /// The number of viewports used by a pipeline is still specified by
        /// the viewportCount member of PipelineViewportStateCreateInfo.
        /// </summary>
        Viewport = 0, 
        
        /// <summary>
        /// Indicates that the pScissors state in
        /// PipelineViewportStateCreateInfo will be ignored and must be set
        /// dynamically with flink:vkCmdSetScissor before any draw commands.
        /// The number of scissor rectangles used by a pipeline is still
        /// specified by the scissorCount member of
        /// PipelineViewportStateCreateInfo.
        /// </summary>
        Scissor = 1, 
        
        /// <summary>
        /// Indicates that the lineWidth state in
        /// PipelineRasterizationStateCreateInfo will be ignored and must be
        /// set dynamically with flink:vkCmdSetLineWidth before any draw
        /// commands that generate line primitives for the rasterizer.
        /// </summary>
        LineWidth = 2, 
        
        /// <summary>
        /// Indicates that the depthBiasConstantFactor, depthBiasClamp and
        /// depthBiasSlopeFactor states in PipelineRasterizationStateCreateInfo
        /// will be ignored and must be set dynamically with
        /// flink:vkCmdSetDepthBias before any draws are performed with
        /// depthBiasEnable in PipelineRasterizationStateCreateInfo set to
        /// VK_TRUE.
        /// </summary>
        DepthBias = 3, 
        
        /// <summary>
        /// Indicates that the blendConstants state in
        /// PipelineColorBlendStateCreateInfo will be ignored and must be set
        /// dynamically with flink:vkCmdSetBlendConstants before any draws are
        /// performed with a pipeline state with
        /// PipelineColorBlendAttachmentState member blendEnable set to VK_TRUE
        /// and any of the blend functions using a constant blend color.
        /// </summary>
        BlendConstants = 4, 
        
        /// <summary>
        /// Indicates that the minDepthBounds and maxDepthBounds states of
        /// PipelineDepthStencilStateCreateInfo will be ignored and must be set
        /// dynamically with flink:vkCmdSetDepthBounds before any draws are
        /// performed with a pipeline state with
        /// PipelineDepthStencilStateCreateInfo member depthBoundsTestEnable
        /// set to VK_TRUE.
        /// </summary>
        DepthBounds = 5, 
        
        /// <summary>
        /// Indicates that the compareMask state in
        /// PipelineDepthStencilStateCreateInfo for both front and back will be
        /// ignored and must be set dynamically with
        /// flink:vkCmdSetStencilCompareMask before any draws are performed
        /// with a pipeline state with PipelineDepthStencilStateCreateInfo
        /// member stencilTestEnable set to VK_TRUE
        /// </summary>
        StencilCompareMask = 6, 
        
        /// <summary>
        /// Indicates that the writeMask state in
        /// PipelineDepthStencilStateCreateInfo for both front and back will be
        /// ignored and must be set dynamically with
        /// flink:vkCmdSetStencilWriteMask before any draws are performed with
        /// a pipeline state with PipelineDepthStencilStateCreateInfo member
        /// stencilTestEnable set to VK_TRUE
        /// </summary>
        StencilWriteMask = 7, 
        
        /// <summary>
        /// Indicates that the reference state in
        /// PipelineDepthStencilStateCreateInfo for both front and back will be
        /// ignored and must be set dynamically with
        /// flink:vkCmdSetStencilReference before any draws are performed with
        /// a pipeline state with PipelineDepthStencilStateCreateInfo member
        /// stencilTestEnable set to VK_TRUE
        /// </summary>
        StencilReference = 8, 
        
        /// <summary>
        /// 
        /// </summary>
        CullModeGraphics = 1000267000, 
        
        /// <summary>
        /// 
        /// </summary>
        FrontFaceGraphics = 1000267001, 
        
        /// <summary>
        /// 
        /// </summary>
        PrimitiveTopologyGraphics = 1000267002, 
        
        /// <summary>
        /// 
        /// </summary>
        ViewportWithCountGraphics = 1000267003, 
        
        /// <summary>
        /// 
        /// </summary>
        ScissorWithCountGraphics = 1000267004, 
        
        /// <summary>
        /// 
        /// </summary>
        VertexInputBindingStrideGraphics = 1000267005, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthTestEnableGraphics = 1000267006, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthWriteEnableGraphics = 1000267007, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthCompareOpGraphics = 1000267008, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthBoundsTestEnableGraphics = 1000267009, 
        
        /// <summary>
        /// 
        /// </summary>
        StencilTestEnableGraphics = 1000267010, 
        
        /// <summary>
        /// 
        /// </summary>
        StencilOpGraphics = 1000267011, 
        
        /// <summary>
        /// 
        /// </summary>
        RasterizerDiscardEnableGraphics = 1000377001, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthBiasEnableGraphics = 1000377002, 
        
        /// <summary>
        /// 
        /// </summary>
        PrimitiveRestartEnableGraphics = 1000377004, 
        
        /// <summary>
        /// 
        /// </summary>
        LineStippleGraphics = 1000259000, 
        
        /// <summary>
        /// 
        /// </summary>
        ViewportWScaling = 1000087000, 
        
        /// <summary>
        /// 
        /// </summary>
        DiscardRectangle = 1000099000, 
        
        /// <summary>
        /// 
        /// </summary>
        DiscardRectangleEnable = 1000099001, 
        
        /// <summary>
        /// 
        /// </summary>
        DiscardRectangleMode = 1000099002, 
        
        /// <summary>
        /// 
        /// </summary>
        SampleLocations = 1000143000, 
        
        /// <summary>
        /// 
        /// </summary>
        RayTracingPipelineStackSize = 1000347000, 
        
        /// <summary>
        /// 
        /// </summary>
        ViewportShadingRatePalette = 1000164004, 
        
        /// <summary>
        /// 
        /// </summary>
        ViewportCoarseSampleOrder = 1000164006, 
        
        /// <summary>
        /// 
        /// </summary>
        ExclusiveScissorEnable = 1000205000, 
        
        /// <summary>
        /// 
        /// </summary>
        ExclusiveScissor = 1000205001, 
        
        /// <summary>
        /// 
        /// </summary>
        FragmentShadingRate = 1000226000, 
        
        /// <summary>
        /// 
        /// </summary>
        VertexInput = 1000352000, 
        
        /// <summary>
        /// 
        /// </summary>
        PatchControlPoints = 1000377000, 
        
        /// <summary>
        /// 
        /// </summary>
        LogicOp = 1000377003, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorWriteEnable = 1000381000, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthClampEnable = 1000455003, 
        
        /// <summary>
        /// 
        /// </summary>
        PolygonMode = 1000455004, 
        
        /// <summary>
        /// 
        /// </summary>
        RasterizationSamples = 1000455005, 
        
        /// <summary>
        /// 
        /// </summary>
        SampleMask = 1000455006, 
        
        /// <summary>
        /// 
        /// </summary>
        AlphaToCoverageEnable = 1000455007, 
        
        /// <summary>
        /// 
        /// </summary>
        AlphaToOneEnable = 1000455008, 
        
        /// <summary>
        /// 
        /// </summary>
        LogicOpEnable = 1000455009, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorBlendEnable = 1000455010, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorBlendEquation = 1000455011, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorWriteMask = 1000455012, 
        
        /// <summary>
        /// 
        /// </summary>
        TessellationDomainOrigin = 1000455002, 
        
        /// <summary>
        /// 
        /// </summary>
        RasterizationStream = 1000455013, 
        
        /// <summary>
        /// 
        /// </summary>
        ConservativeRasterizationMode = 1000455014, 
        
        /// <summary>
        /// 
        /// </summary>
        ExtraPrimitiveOverestimationSize = 1000455015, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthClipEnable = 1000455016, 
        
        /// <summary>
        /// 
        /// </summary>
        SampleLocationsEnable = 1000455017, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorBlendAdvanced = 1000455018, 
        
        /// <summary>
        /// 
        /// </summary>
        ProvokingVertexMode = 1000455019, 
        
        /// <summary>
        /// 
        /// </summary>
        LineRasterizationMode = 1000455020, 
        
        /// <summary>
        /// 
        /// </summary>
        LineStippleEnable = 1000455021, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthClipNegativeOneToOne = 1000455022, 
        
        /// <summary>
        /// 
        /// </summary>
        ViewportWScalingEnable = 1000455023, 
        
        /// <summary>
        /// 
        /// </summary>
        ViewportSwizzle = 1000455024, 
        
        /// <summary>
        /// 
        /// </summary>
        CoverageToColorEnable = 1000455025, 
        
        /// <summary>
        /// 
        /// </summary>
        CoverageToColorLocation = 1000455026, 
        
        /// <summary>
        /// 
        /// </summary>
        CoverageModulationMode = 1000455027, 
        
        /// <summary>
        /// 
        /// </summary>
        CoverageModulationTableEnable = 1000455028, 
        
        /// <summary>
        /// 
        /// </summary>
        CoverageModulationTable = 1000455029, 
        
        /// <summary>
        /// 
        /// </summary>
        ShadingRateImageEnable = 1000455030, 
        
        /// <summary>
        /// 
        /// </summary>
        RepresentativeFragmentTestEnable = 1000455031, 
        
        /// <summary>
        /// 
        /// </summary>
        CoverageReductionMode = 1000455032, 
        
        /// <summary>
        /// 
        /// </summary>
        AttachmentFeedbackLoopEnable = 1000524000, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthClampRange = 1000582000, 
    }
}
