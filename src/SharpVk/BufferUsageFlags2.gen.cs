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
    public enum BufferUsageFlags2 : long
    {
        /// <summary>
        /// 
        /// </summary>
        None = 0, 
        
        /// <summary>
        /// 
        /// </summary>
        TransferSource = 1 << 0, 
        
        /// <summary>
        /// 
        /// </summary>
        TransferDestination = 1 << 1, 
        
        /// <summary>
        /// 
        /// </summary>
        UniformTexelBuffer = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageTexelBuffer = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        UniformBuffer = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        StorageBuffer = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        IndexBuffer = 1 << 6, 
        
        /// <summary>
        /// 
        /// </summary>
        VertexBuffer = 1 << 7, 
        
        /// <summary>
        /// 
        /// </summary>
        IndirectBuffer = 1 << 8, 
        
        /// <summary>
        /// 
        /// </summary>
        ShaderDeviceAddress = 1 << 17, 
        
        /// <summary>
        /// 
        /// </summary>
        ExecutionGraphScratch = 1 << 25, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved28 = 1 << 28, 
        
        /// <summary>
        /// 
        /// </summary>
        ConditionalRendering = 1 << 9, 
        
        /// <summary>
        /// 
        /// </summary>
        ShaderBindingTable = 1 << 10, 
        
        /// <summary>
        /// 
        /// </summary>
        TransformFeedbackBuffer = 1 << 11, 
        
        /// <summary>
        /// 
        /// </summary>
        TransformFeedbackCounterBuffer = 1 << 12, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoDecodeSource = 1 << 13, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoDecodeDestination = 1 << 14, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoEncodeDestination = 1 << 15, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoEncodeSource = 1 << 16, 
        
        /// <summary>
        /// 
        /// </summary>
        AccelerationStructureBuildInputReadOnly = 1 << 19, 
        
        /// <summary>
        /// 
        /// </summary>
        AccelerationStructureStorage = 1 << 20, 
        
        /// <summary>
        /// 
        /// </summary>
        SamplerDescriptorBuffer = 1 << 21, 
        
        /// <summary>
        /// 
        /// </summary>
        ResourceDescriptorBuffer = 1 << 22, 
        
        /// <summary>
        /// 
        /// </summary>
        PushDescriptorsDescriptorBuffer = 1 << 26, 
        
        /// <summary>
        /// 
        /// </summary>
        MicromapBuildInputReadOnly = 1 << 23, 
        
        /// <summary>
        /// 
        /// </summary>
        MicromapStorage = 1 << 24, 
        
        /// <summary>
        /// 
        /// </summary>
        CompressedDataDgf1 = 1 << 33, 
        
        /// <summary>
        /// 
        /// </summary>
        DataGraphForeignDescriptor = 1 << 29, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved34 = 1 << 34, 
        
        /// <summary>
        /// 
        /// </summary>
        TileMemory = 1 << 27, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved32 = 1 << 32, 
        
        /// <summary>
        /// 
        /// </summary>
        PreprocessBuffer = 1 << 31, 
    }
}
