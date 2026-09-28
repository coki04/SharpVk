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

using System;
using System.Runtime.InteropServices;

namespace SharpVk.Khronos
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct SurfacePresentScalingCapabilities
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.PresentScalingFlags? SupportedPresentScaling
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.PresentGravityFlags? SupportedPresentGravityX
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.PresentGravityFlags? SupportedPresentGravityY
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D? MinScaledImageExtent
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Extent2D? MaxScaledImageExtent
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.SurfacePresentScalingCapabilities* pointer)
        {
            pointer->SType = StructureType.SurfacePresentScalingCapabilitiesKhr;
            pointer->Next = null;
            if (this.SupportedPresentScaling != null)
            {
                pointer->SupportedPresentScaling = this.SupportedPresentScaling.Value;
            }
            else
            {
                pointer->SupportedPresentScaling = default(SharpVk.Khronos.PresentScalingFlags);
            }
            if (this.SupportedPresentGravityX != null)
            {
                pointer->SupportedPresentGravityX = this.SupportedPresentGravityX.Value;
            }
            else
            {
                pointer->SupportedPresentGravityX = default(SharpVk.Khronos.PresentGravityFlags);
            }
            if (this.SupportedPresentGravityY != null)
            {
                pointer->SupportedPresentGravityY = this.SupportedPresentGravityY.Value;
            }
            else
            {
                pointer->SupportedPresentGravityY = default(SharpVk.Khronos.PresentGravityFlags);
            }
            if (this.MinScaledImageExtent != null)
            {
                pointer->MinScaledImageExtent = this.MinScaledImageExtent.Value;
            }
            else
            {
                pointer->MinScaledImageExtent = default(SharpVk.Extent2D);
            }
            if (this.MaxScaledImageExtent != null)
            {
                pointer->MaxScaledImageExtent = this.MaxScaledImageExtent.Value;
            }
            else
            {
                pointer->MaxScaledImageExtent = default(SharpVk.Extent2D);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe SurfacePresentScalingCapabilities MarshalFrom(SharpVk.Interop.Khronos.SurfacePresentScalingCapabilities* pointer)
        {
            SurfacePresentScalingCapabilities result = default(SurfacePresentScalingCapabilities);
            result.SupportedPresentScaling = pointer->SupportedPresentScaling;
            result.SupportedPresentGravityX = pointer->SupportedPresentGravityX;
            result.SupportedPresentGravityY = pointer->SupportedPresentGravityY;
            result.MinScaledImageExtent = pointer->MinScaledImageExtent;
            result.MaxScaledImageExtent = pointer->MaxScaledImageExtent;
            return result;
        }
    }
}
