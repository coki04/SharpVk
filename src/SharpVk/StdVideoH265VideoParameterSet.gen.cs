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

namespace SharpVk
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct StdVideoH265VideoParameterSet
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265VpsFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte VpsVideoParameterSetId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte VpsMaxSubLayersMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte Reserved1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte Reserved2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint VpsNumUnitsInTick
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint VpsTimeScale
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint VpsNumTicksPocDiffOneMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public uint Reserved3
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265DecPicBufMgr? DecPicBufMgr
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265HrdParameters? HrdParameters
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265ProfileTierLevel? ProfileTierLevel
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoH265VideoParameterSet* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->VpsVideoParameterSetId = this.VpsVideoParameterSetId;
            pointer->VpsMaxSubLayersMinus1 = this.VpsMaxSubLayersMinus1;
            pointer->Reserved1 = this.Reserved1;
            pointer->Reserved2 = this.Reserved2;
            pointer->VpsNumUnitsInTick = this.VpsNumUnitsInTick;
            pointer->VpsTimeScale = this.VpsTimeScale;
            pointer->VpsNumTicksPocDiffOneMinus1 = this.VpsNumTicksPocDiffOneMinus1;
            pointer->Reserved3 = this.Reserved3;
            if (this.DecPicBufMgr != null)
            {
                pointer->DecPicBufMgr = (SharpVk.Interop.StdVideoH265DecPicBufMgr*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoH265DecPicBufMgr>());
                this.DecPicBufMgr.Value.MarshalTo(pointer->DecPicBufMgr);
            }
            else
            {
                pointer->DecPicBufMgr = default(SharpVk.Interop.StdVideoH265DecPicBufMgr*);
            }
            if (this.HrdParameters != null)
            {
                pointer->HrdParameters = (SharpVk.Interop.StdVideoH265HrdParameters*)(Interop.HeapUtil.Allocate<SharpVk.Interop.StdVideoH265HrdParameters>());
                this.HrdParameters.Value.MarshalTo(pointer->HrdParameters);
            }
            else
            {
                pointer->HrdParameters = default(SharpVk.Interop.StdVideoH265HrdParameters*);
            }
            if (this.ProfileTierLevel != null)
            {
                pointer->ProfileTierLevel = (SharpVk.StdVideoH265ProfileTierLevel*)(Interop.HeapUtil.Allocate<SharpVk.StdVideoH265ProfileTierLevel>());
                *pointer->ProfileTierLevel = this.ProfileTierLevel.Value;
            }
            else
            {
                pointer->ProfileTierLevel = default(SharpVk.StdVideoH265ProfileTierLevel*);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe StdVideoH265VideoParameterSet MarshalFrom(SharpVk.Interop.StdVideoH265VideoParameterSet* pointer)
        {
            StdVideoH265VideoParameterSet result = default(StdVideoH265VideoParameterSet);
            result.Flags = pointer->Flags;
            result.VpsVideoParameterSetId = pointer->VpsVideoParameterSetId;
            result.VpsMaxSubLayersMinus1 = pointer->VpsMaxSubLayersMinus1;
            result.Reserved1 = pointer->Reserved1;
            result.Reserved2 = pointer->Reserved2;
            result.VpsNumUnitsInTick = pointer->VpsNumUnitsInTick;
            result.VpsTimeScale = pointer->VpsTimeScale;
            result.VpsNumTicksPocDiffOneMinus1 = pointer->VpsNumTicksPocDiffOneMinus1;
            result.Reserved3 = pointer->Reserved3;
            if (pointer->DecPicBufMgr != null)
            {
                result.DecPicBufMgr = SharpVk.StdVideoH265DecPicBufMgr.MarshalFrom(pointer->DecPicBufMgr);
            }
            else
            {
                result.DecPicBufMgr = null;
            }
            if (pointer->HrdParameters != null)
            {
                result.HrdParameters = SharpVk.StdVideoH265HrdParameters.MarshalFrom(pointer->HrdParameters);
            }
            else
            {
                result.HrdParameters = null;
            }
            if (pointer->ProfileTierLevel != null)
            {
                result.ProfileTierLevel = *pointer->ProfileTierLevel;
            }
            else
            {
                result.ProfileTierLevel = null;
            }
            return result;
        }
    }
}
