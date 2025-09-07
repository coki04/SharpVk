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

namespace SharpVk.Qcom
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PhysicalDeviceTileShadingFeatures
    {
        /// <summary>
        /// 
        /// </summary>
        public bool TileShading
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool TileShadingFragmentStage
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool TileShadingColorAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool TileShadingDepthAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool TileShadingStencilAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool TileShadingInputAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool TileShadingSampledAttachments
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool TileShadingPerTileDraw
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool TileShadingPerTileDispatch
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool TileShadingDispatchTile
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool TileShadingApron
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool TileShadingAnisotropicApron
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool TileShadingAtomicOps
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool TileShadingImageProcessing
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Qcom.PhysicalDeviceTileShadingFeatures* pointer)
        {
            pointer->SType = StructureType.PhysicalDeviceTileShadingFeatures;
            pointer->Next = null;
            pointer->TileShading = this.TileShading;
            pointer->TileShadingFragmentStage = this.TileShadingFragmentStage;
            pointer->TileShadingColorAttachments = this.TileShadingColorAttachments;
            pointer->TileShadingDepthAttachments = this.TileShadingDepthAttachments;
            pointer->TileShadingStencilAttachments = this.TileShadingStencilAttachments;
            pointer->TileShadingInputAttachments = this.TileShadingInputAttachments;
            pointer->TileShadingSampledAttachments = this.TileShadingSampledAttachments;
            pointer->TileShadingPerTileDraw = this.TileShadingPerTileDraw;
            pointer->TileShadingPerTileDispatch = this.TileShadingPerTileDispatch;
            pointer->TileShadingDispatchTile = this.TileShadingDispatchTile;
            pointer->TileShadingApron = this.TileShadingApron;
            pointer->TileShadingAnisotropicApron = this.TileShadingAnisotropicApron;
            pointer->TileShadingAtomicOps = this.TileShadingAtomicOps;
            pointer->TileShadingImageProcessing = this.TileShadingImageProcessing;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PhysicalDeviceTileShadingFeatures MarshalFrom(SharpVk.Interop.Qcom.PhysicalDeviceTileShadingFeatures* pointer)
        {
            PhysicalDeviceTileShadingFeatures result = default(PhysicalDeviceTileShadingFeatures);
            result.TileShading = pointer->TileShading;
            result.TileShadingFragmentStage = pointer->TileShadingFragmentStage;
            result.TileShadingColorAttachments = pointer->TileShadingColorAttachments;
            result.TileShadingDepthAttachments = pointer->TileShadingDepthAttachments;
            result.TileShadingStencilAttachments = pointer->TileShadingStencilAttachments;
            result.TileShadingInputAttachments = pointer->TileShadingInputAttachments;
            result.TileShadingSampledAttachments = pointer->TileShadingSampledAttachments;
            result.TileShadingPerTileDraw = pointer->TileShadingPerTileDraw;
            result.TileShadingPerTileDispatch = pointer->TileShadingPerTileDispatch;
            result.TileShadingDispatchTile = pointer->TileShadingDispatchTile;
            result.TileShadingApron = pointer->TileShadingApron;
            result.TileShadingAnisotropicApron = pointer->TileShadingAnisotropicApron;
            result.TileShadingAtomicOps = pointer->TileShadingAtomicOps;
            result.TileShadingImageProcessing = pointer->TileShadingImageProcessing;
            return result;
        }
    }
}
