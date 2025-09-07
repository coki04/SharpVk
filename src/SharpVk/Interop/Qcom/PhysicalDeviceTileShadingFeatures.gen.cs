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

namespace SharpVk.Interop.Qcom
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct PhysicalDeviceTileShadingFeatures
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
        public Bool32 TileShading; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TileShadingFragmentStage; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TileShadingColorAttachments; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TileShadingDepthAttachments; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TileShadingStencilAttachments; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TileShadingInputAttachments; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TileShadingSampledAttachments; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TileShadingPerTileDraw; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TileShadingPerTileDispatch; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TileShadingDispatchTile; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TileShadingApron; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TileShadingAnisotropicApron; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TileShadingAtomicOps; 
        
        /// <summary>
        /// 
        /// </summary>
        public Bool32 TileShadingImageProcessing; 
    }
}
