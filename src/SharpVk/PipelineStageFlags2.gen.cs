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
    /// 
    /// </summary>
    [System.Flags]
    public enum PipelineStageFlags2 : long
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        TopOfPipe = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        DrawIndirect = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        VertexInput = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        VertexShader = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        TessellationControlShader = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        TessellationEvaluationShader = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        GeometryShader = 1 << 6, 
        
        /// <summary>
        /// 
        /// </summary>
        FragmentShader = 1 << 7, 
        
        /// <summary>
        /// 
        /// </summary>
        EarlyFragmentTests = 1 << 8, 
        
        /// <summary>
        /// 
        /// </summary>
        LateFragmentTests = 1 << 9, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorAttachmentOutput = 1 << 10, 
        
        /// <summary>
        /// 
        /// </summary>
        ComputeShader = 1 << 11, 
        
        /// <summary>
        /// 
        /// </summary>
        AllTransfer = 1 << 12, 
        
        /// <summary>
        /// 
        /// </summary>
        BottomOfPipe = 1 << 13, 
        
        /// <summary>
        /// 
        /// </summary>
        Host = 1 << 14, 
        
        /// <summary>
        /// 
        /// </summary>
        AllGraphics = 1 << 15, 
        
        /// <summary>
        /// 
        /// </summary>
        AllCommands = 1 << 16, 
        
        /// <summary>
        /// 
        /// </summary>
        Copy = 1 << 32, 
        
        /// <summary>
        /// 
        /// </summary>
        Resolve = 1 << 33, 
        
        /// <summary>
        /// 
        /// </summary>
        Blit = 1 << 34, 
        
        /// <summary>
        /// 
        /// </summary>
        Clear = 1 << 35, 
        
        /// <summary>
        /// 
        /// </summary>
        IndexInput = 1 << 36, 
        
        /// <summary>
        /// 
        /// </summary>
        VertexAttributeInput = 1 << 37, 
        
        /// <summary>
        /// 
        /// </summary>
        PreRasterizationShaders = 1 << 38, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoDecode = 1 << 26, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoEncode = 1 << 27, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved50 = 1 << 50, 
        
        /// <summary>
        /// 
        /// </summary>
        TransformFeedback = 1 << 24, 
        
        /// <summary>
        /// 
        /// </summary>
        ConditionalRendering = 1 << 18, 
        
        /// <summary>
        /// 
        /// </summary>
        CommandPreprocess = 1 << 17, 
        
        /// <summary>
        /// 
        /// </summary>
        FragmentShadingRateAttachment = 1 << 22, 
        
        /// <summary>
        /// 
        /// </summary>
        AccelerationStructureBuild = 1 << 25, 
        
        /// <summary>
        /// 
        /// </summary>
        RayTracingShader = 1 << 21, 
        
        /// <summary>
        /// 
        /// </summary>
        FragmentDensityProcess = 1 << 23, 
        
        /// <summary>
        /// 
        /// </summary>
        TaskShader = 1 << 19, 
        
        /// <summary>
        /// 
        /// </summary>
        MeshShader = 1 << 20, 
        
        /// <summary>
        /// 
        /// </summary>
        SubpassShader = 1 << 39, 
        
        /// <summary>
        /// 
        /// </summary>
        InvocationMask = 1 << 40, 
        
        /// <summary>
        /// 
        /// </summary>
        AccelerationStructureCopy = 1 << 28, 
        
        /// <summary>
        /// 
        /// </summary>
        MicromapBuild = 1 << 30, 
        
        /// <summary>
        /// 
        /// </summary>
        ClusterCullingShader = 1 << 41, 
        
        /// <summary>
        /// 
        /// </summary>
        OpticalFlow = 1 << 29, 
        
        /// <summary>
        /// 
        /// </summary>
        ConvertCooperativeVectorMatrix = 1 << 44, 
        
        /// <summary>
        /// 
        /// </summary>
        DataGraph = 1 << 42, 
        
        /// <summary>
        /// 
        /// </summary>
        CopyIndirect = 1 << 46, 
        
        /// <summary>
        /// 
        /// </summary>
        MemoryDecompression = 1 << 45, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved49 = 1 << 49, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved47 = 1 << 47, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved31 = 1 << 31, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved43 = 1 << 43, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved48 = 1 << 48, 
    }
}
