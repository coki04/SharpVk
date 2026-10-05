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
    public partial struct StdVideoH265HrdParameters
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265HrdFlags Flags
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte TickDivisorMinus2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte DuCpbRemovalDelayIncrementLengthMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte DpbOutputDelayDuLengthMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte BitRateScale
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte CpbSizeScale
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte CpbSizeDuScale
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte InitialCpbRemovalDelayLengthMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte AuCpbRemovalDelayLengthMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte DpbOutputDelayLengthMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] CpbCntMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ushort[] ElementalDurationInTcMinus1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public (ushort, ushort, ushort) Reserved
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265SubLayerHrdParameters[] SubLayerHrdParametersNal
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.StdVideoH265SubLayerHrdParameters[] SubLayerHrdParametersVcl
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.StdVideoH265HrdParameters* pointer)
        {
            pointer->Flags = this.Flags;
            pointer->TickDivisorMinus2 = this.TickDivisorMinus2;
            pointer->DuCpbRemovalDelayIncrementLengthMinus1 = this.DuCpbRemovalDelayIncrementLengthMinus1;
            pointer->DpbOutputDelayDuLengthMinus1 = this.DpbOutputDelayDuLengthMinus1;
            pointer->BitRateScale = this.BitRateScale;
            pointer->CpbSizeScale = this.CpbSizeScale;
            pointer->CpbSizeDuScale = this.CpbSizeDuScale;
            pointer->InitialCpbRemovalDelayLengthMinus1 = this.InitialCpbRemovalDelayLengthMinus1;
            pointer->AuCpbRemovalDelayLengthMinus1 = this.AuCpbRemovalDelayLengthMinus1;
            pointer->DpbOutputDelayLengthMinus1 = this.DpbOutputDelayLengthMinus1;
            Interop.HeapUtil.MarshalTo(this.CpbCntMinus1, checked((int)Constants.StdVideoH265SublayersListSize), pointer->CpbCntMinus1);
            Interop.HeapUtil.MarshalTo(this.ElementalDurationInTcMinus1, checked((int)Constants.StdVideoH265SublayersListSize), pointer->ElementalDurationInTcMinus1);
            pointer->Reserved[0] = this.Reserved.Item1;
            pointer->Reserved[1] = this.Reserved.Item2;
            pointer->Reserved[2] = this.Reserved.Item3;
            if (this.SubLayerHrdParametersNal != null)
            {
                var fieldPointer = (SharpVk.Interop.StdVideoH265SubLayerHrdParameters*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.StdVideoH265SubLayerHrdParameters>(this.SubLayerHrdParametersNal.Length).ToPointer());
                for(int index = 0; index < (uint)(this.SubLayerHrdParametersNal.Length); index++)
                {
                    this.SubLayerHrdParametersNal[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->SubLayerHrdParametersNal = fieldPointer;
            }
            else
            {
                pointer->SubLayerHrdParametersNal = null;
            }
            if (this.SubLayerHrdParametersVcl != null)
            {
                var fieldPointer = (SharpVk.Interop.StdVideoH265SubLayerHrdParameters*)(Interop.HeapUtil.AllocateAndClear<SharpVk.Interop.StdVideoH265SubLayerHrdParameters>(this.SubLayerHrdParametersVcl.Length).ToPointer());
                for(int index = 0; index < (uint)(this.SubLayerHrdParametersVcl.Length); index++)
                {
                    this.SubLayerHrdParametersVcl[index].MarshalTo(&fieldPointer[index]);
                }
                pointer->SubLayerHrdParametersVcl = fieldPointer;
            }
            else
            {
                pointer->SubLayerHrdParametersVcl = null;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe StdVideoH265HrdParameters MarshalFrom(SharpVk.Interop.StdVideoH265HrdParameters* pointer)
        {
            StdVideoH265HrdParameters result = default(StdVideoH265HrdParameters);
            result.Flags = pointer->Flags;
            result.TickDivisorMinus2 = pointer->TickDivisorMinus2;
            result.DuCpbRemovalDelayIncrementLengthMinus1 = pointer->DuCpbRemovalDelayIncrementLengthMinus1;
            result.DpbOutputDelayDuLengthMinus1 = pointer->DpbOutputDelayDuLengthMinus1;
            result.BitRateScale = pointer->BitRateScale;
            result.CpbSizeScale = pointer->CpbSizeScale;
            result.CpbSizeDuScale = pointer->CpbSizeDuScale;
            result.InitialCpbRemovalDelayLengthMinus1 = pointer->InitialCpbRemovalDelayLengthMinus1;
            result.AuCpbRemovalDelayLengthMinus1 = pointer->AuCpbRemovalDelayLengthMinus1;
            result.DpbOutputDelayLengthMinus1 = pointer->DpbOutputDelayLengthMinus1;
            result.CpbCntMinus1 = Interop.HeapUtil.MarshalFrom(pointer->CpbCntMinus1, checked((int)Constants.StdVideoH265SublayersListSize));
            result.ElementalDurationInTcMinus1 = Interop.HeapUtil.MarshalFrom(pointer->ElementalDurationInTcMinus1, checked((int)Constants.StdVideoH265SublayersListSize));
            result.Reserved = (pointer->Reserved[0], pointer->Reserved[1], pointer->Reserved[2]);
            if (pointer->SubLayerHrdParametersNal != null)
            {
                var fieldPointer = new SharpVk.StdVideoH265SubLayerHrdParameters[(uint)(7)];
                for(int index = 0; index < (uint)(7); index++)
                {
                    fieldPointer[index] = SharpVk.StdVideoH265SubLayerHrdParameters.MarshalFrom(&pointer->SubLayerHrdParametersNal[index]);
                }
                result.SubLayerHrdParametersNal = fieldPointer;
            }
            else
            {
                result.SubLayerHrdParametersNal = null;
            }
            if (pointer->SubLayerHrdParametersVcl != null)
            {
                var fieldPointer = new SharpVk.StdVideoH265SubLayerHrdParameters[(uint)(7)];
                for(int index = 0; index < (uint)(7); index++)
                {
                    fieldPointer[index] = SharpVk.StdVideoH265SubLayerHrdParameters.MarshalFrom(&pointer->SubLayerHrdParametersVcl[index]);
                }
                result.SubLayerHrdParametersVcl = fieldPointer;
            }
            else
            {
                result.SubLayerHrdParametersVcl = null;
            }
            return result;
        }
    }
}
