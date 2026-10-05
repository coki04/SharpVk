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
    public partial struct VideoEncodeAV1PictureInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeAV1PredictionMode PredictionMode
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.VideoEncodeAV1RateControlGroup RateControlGroup
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint ConstantQIndex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoEncodeAV1PictureInfo StdPictureInfo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public int[] ReferenceNameSlotIndices
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool PrimaryReferenceCdfOnly
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool GenerateObuExtensionHeader
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Khronos.VideoEncodeAV1PictureInfo* pointer)
        {
            pointer->SType = StructureType.VideoEncodeAv1PictureInfo;
            pointer->Next = null;
            pointer->PredictionMode = this.PredictionMode;
            pointer->RateControlGroup = this.RateControlGroup;
            pointer->ConstantQIndex = this.ConstantQIndex;
            pointer->StdPictureInfo = (SharpVk.Interop.StdVideoEncodeAV1PictureInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoEncodeAV1PictureInfo>());
            this.StdPictureInfo.MarshalTo(pointer->StdPictureInfo);
            Interop.HeapUtil.MarshalTo(this.ReferenceNameSlotIndices, checked((int)Constants.MaxVideoAv1ReferencesPerFrame), pointer->ReferenceNameSlotIndices);
            pointer->PrimaryReferenceCdfOnly = this.PrimaryReferenceCdfOnly;
            pointer->GenerateObuExtensionHeader = this.GenerateObuExtensionHeader;
        }
    }
}
