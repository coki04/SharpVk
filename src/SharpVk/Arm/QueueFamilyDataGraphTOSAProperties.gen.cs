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

namespace SharpVk.Arm
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct QueueFamilyDataGraphTOSAProperties
    {
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Arm.DataGraphTOSANameQuality[] Profiles
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Arm.DataGraphTOSANameQuality[] Extensions
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Arm.DataGraphTOSALevel Level
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe QueueFamilyDataGraphTOSAProperties MarshalFrom(SharpVk.Interop.Arm.QueueFamilyDataGraphTOSAProperties* pointer)
        {
            QueueFamilyDataGraphTOSAProperties result = default(QueueFamilyDataGraphTOSAProperties);
            if (pointer->Profiles != null)
            {
                var fieldPointer = new SharpVk.Arm.DataGraphTOSANameQuality[(uint)(pointer->ProfileCount)];
                for(int index = 0; index < (uint)(pointer->ProfileCount); index++)
                {
                    fieldPointer[index] = SharpVk.Arm.DataGraphTOSANameQuality.MarshalFrom(&pointer->Profiles[index]);
                }
                result.Profiles = fieldPointer;
            }
            else
            {
                result.Profiles = null;
            }
            if (pointer->Extensions != null)
            {
                var fieldPointer = new SharpVk.Arm.DataGraphTOSANameQuality[(uint)(pointer->ExtensionCount)];
                for(int index = 0; index < (uint)(pointer->ExtensionCount); index++)
                {
                    fieldPointer[index] = SharpVk.Arm.DataGraphTOSANameQuality.MarshalFrom(&pointer->Extensions[index]);
                }
                result.Extensions = fieldPointer;
            }
            else
            {
                result.Extensions = null;
            }
            result.Level = pointer->Level;
            return result;
        }
    }
}
