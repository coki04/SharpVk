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

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [System.Flags]
    public enum ImageUsageFlags2 : long
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
        Sampled = 1 << 2, 
        
        /// <summary>
        /// 
        /// </summary>
        Storage = 1 << 3, 
        
        /// <summary>
        /// 
        /// </summary>
        ColorAttachment = 1 << 4, 
        
        /// <summary>
        /// 
        /// </summary>
        DepthStencilAttachment = 1 << 5, 
        
        /// <summary>
        /// 
        /// </summary>
        TransientAttachment = 1 << 6, 
        
        /// <summary>
        /// 
        /// </summary>
        InputAttachment = 1 << 7, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved31 = 1 << 31, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved24 = 1 << 24, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved28 = 1 << 28, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved29 = 1 << 29, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved30 = 1 << 30, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved16 = 1 << 16, 
        
        /// <summary>
        /// 
        /// </summary>
        Reserved27 = 1 << 17, 
        
        /// <summary>
        /// 
        /// </summary>
        FragmentShadingRateAttachment = 1 << 8, 
        
        /// <summary>
        /// 
        /// </summary>
        FragmentDensityMap = 1 << 9, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoDecodeDestination = 1 << 10, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoDecodeSource = 1 << 11, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoDecodeDpb = 1 << 12, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoEncodeDestination = 1 << 13, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoEncodeSource = 1 << 14, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoEncodeDpb = 1 << 15, 
        
        /// <summary>
        /// 
        /// </summary>
        InvocationMask = 1 << 18, 
        
        /// <summary>
        /// 
        /// </summary>
        AttachmentFeedbackLoop = 1 << 19, 
        
        /// <summary>
        /// 
        /// </summary>
        SampleWeight = 1 << 20, 
        
        /// <summary>
        /// 
        /// </summary>
        SampleBlockMatch = 1 << 21, 
        
        /// <summary>
        /// 
        /// </summary>
        HostTransfer = 1 << 22, 
        
        /// <summary>
        /// 
        /// </summary>
        TensorAliasing = 1 << 23, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoEncodeQuantizationDeltaMap = 1 << 25, 
        
        /// <summary>
        /// 
        /// </summary>
        VideoEncodeEmphasisMap = 1 << 26, 
        
        /// <summary>
        /// 
        /// </summary>
        TileMemory = 1 << 27, 
    }
}
