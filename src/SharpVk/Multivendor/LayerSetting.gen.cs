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
    public partial struct LayerSetting
    {
        /// <summary>
        /// 
        /// </summary>
        public string LayerName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string SettingName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public SharpVk.Multivendor.LayerSettingType Type
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] Values
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal unsafe void MarshalTo(SharpVk.Interop.Multivendor.LayerSetting* pointer)
        {
            pointer->LayerName = Interop.HeapUtil.MarshalTo(this.LayerName);
            pointer->SettingName = Interop.HeapUtil.MarshalTo(this.SettingName);
            pointer->Type = this.Type;
            pointer->ValueCount = (uint)(Interop.HeapUtil.GetLength(this.Values));
            if (this.Values != null)
            {
                var fieldPointer = (byte*)(Interop.HeapUtil.AllocateAndClear<byte>(this.Values.Length).ToPointer());
                for(int index = 0; index < (uint)(this.Values.Length); index++)
                {
                    fieldPointer[index] = this.Values[index];
                }
                pointer->Values = fieldPointer;
            }
            else
            {
                pointer->Values = null;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointer">
        /// </param>
        internal static unsafe LayerSetting MarshalFrom(SharpVk.Interop.Multivendor.LayerSetting* pointer)
        {
            LayerSetting result = default(LayerSetting);
            result.LayerName = Interop.HeapUtil.MarshalStringFrom(pointer->LayerName);
            result.SettingName = Interop.HeapUtil.MarshalStringFrom(pointer->SettingName);
            result.Type = pointer->Type;
            if (pointer->Values != null)
            {
                var fieldPointer = new byte[(uint)(pointer->ValueCount)];
                for(int index = 0; index < (uint)(pointer->ValueCount); index++)
                {
                    fieldPointer[index] = pointer->Values[index];
                }
                result.Values = fieldPointer;
            }
            else
            {
                result.Values = null;
            }
            return result;
        }
    }
}
