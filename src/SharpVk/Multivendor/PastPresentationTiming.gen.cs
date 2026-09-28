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

namespace SharpVk.Multivendor
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PastPresentationTiming
    {
        /// <summary>
        /// 
        /// </summary>
        public ulong PresentId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong TargetTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.PresentStageTime[] PresentStages
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Khronos.TimeDomain TimeDomain
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public ulong TimeDomainId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool ReportComplete
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe PastPresentationTiming MarshalFrom(SharpVk.Interop.Multivendor.PastPresentationTiming* pointer)
        {
            PastPresentationTiming result = default(PastPresentationTiming);
            result.PresentId = pointer->PresentId;
            result.TargetTime = pointer->TargetTime;
            if (pointer->PresentStages != null)
            {
                var fieldPointer = new SharpVk.Multivendor.PresentStageTime[(uint)(pointer->PresentStageCount)];
                for(int index = 0; index < (uint)(pointer->PresentStageCount); index++)
                {
                    fieldPointer[index] = pointer->PresentStages[index];
                }
                result.PresentStages = fieldPointer;
            }
            else
            {
                result.PresentStages = null;
            }
            result.TimeDomain = pointer->TimeDomain;
            result.TimeDomainId = pointer->TimeDomainId;
            result.ReportComplete = pointer->ReportComplete;
            return result;
        }
    }
}
