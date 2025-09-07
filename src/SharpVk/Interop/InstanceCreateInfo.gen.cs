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

namespace SharpVk.Interop
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct InstanceCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public InstanceCreateInfo(ArrayProxy<string>? enabledLayerNames, ArrayProxy<string>? enabledExtensionNames, SharpVk.InstanceCreateFlags? flags = default(SharpVk.InstanceCreateFlags?), SharpVk.ApplicationInfo? applicationInfo = default(SharpVk.ApplicationInfo?), SharpVk.Multivendor.DebugReportCallbackCreateInfo? debugReportCallbackCreateInfoExt = null, SharpVk.Multivendor.ValidationFlags? validationFlagsExt = null, SharpVk.Multivendor.ValidationFeatures? validationFeaturesExt = null, SharpVk.Multivendor.LayerSettingsCreateInfo? layerSettingsCreateInfoExt = null, SharpVk.Multivendor.DebugUtilsMessengerCreateInfo? debugUtilsMessengerCreateInfoExt = null, SharpVk.Multivendor.ExportMetalObjectCreateInfo? exportMetalObjectCreateInfoExt = null, SharpVk.Lunarg.DirectDriverLoadingList? directDriverLoadingListLunarg = null)
        {
            void* vkInstanceCreateInfoNextPointer = default(void*);
            if (debugReportCallbackCreateInfoExt != null)
            {
                SharpVk.Interop.Multivendor.DebugReportCallbackCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.DebugReportCallbackCreateInfo*);
                extensionPointer = (SharpVk.Interop.Multivendor.DebugReportCallbackCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugReportCallbackCreateInfo>());
                debugReportCallbackCreateInfoExt.Value.MarshalTo(extensionPointer);
                extensionPointer->Next = vkInstanceCreateInfoNextPointer;
                vkInstanceCreateInfoNextPointer = extensionPointer;
            }
            if (validationFlagsExt != null)
            {
                SharpVk.Interop.Multivendor.ValidationFlags* extensionPointer = default(SharpVk.Interop.Multivendor.ValidationFlags*);
                extensionPointer = (SharpVk.Interop.Multivendor.ValidationFlags*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ValidationFlags>());
                validationFlagsExt.Value.MarshalTo(extensionPointer);
                extensionPointer->Next = vkInstanceCreateInfoNextPointer;
                vkInstanceCreateInfoNextPointer = extensionPointer;
            }
            if (validationFeaturesExt != null)
            {
                SharpVk.Interop.Multivendor.ValidationFeatures* extensionPointer = default(SharpVk.Interop.Multivendor.ValidationFeatures*);
                extensionPointer = (SharpVk.Interop.Multivendor.ValidationFeatures*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ValidationFeatures>());
                validationFeaturesExt.Value.MarshalTo(extensionPointer);
                extensionPointer->Next = vkInstanceCreateInfoNextPointer;
                vkInstanceCreateInfoNextPointer = extensionPointer;
            }
            if (layerSettingsCreateInfoExt != null)
            {
                SharpVk.Interop.Multivendor.LayerSettingsCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.LayerSettingsCreateInfo*);
                extensionPointer = (SharpVk.Interop.Multivendor.LayerSettingsCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.LayerSettingsCreateInfo>());
                layerSettingsCreateInfoExt.Value.MarshalTo(extensionPointer);
                extensionPointer->Next = vkInstanceCreateInfoNextPointer;
                vkInstanceCreateInfoNextPointer = extensionPointer;
            }
            if (debugUtilsMessengerCreateInfoExt != null)
            {
                SharpVk.Interop.Multivendor.DebugUtilsMessengerCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.DebugUtilsMessengerCreateInfo*);
                extensionPointer = (SharpVk.Interop.Multivendor.DebugUtilsMessengerCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.DebugUtilsMessengerCreateInfo>());
                debugUtilsMessengerCreateInfoExt.Value.MarshalTo(extensionPointer);
                extensionPointer->Next = vkInstanceCreateInfoNextPointer;
                vkInstanceCreateInfoNextPointer = extensionPointer;
            }
            if (exportMetalObjectCreateInfoExt != null)
            {
                SharpVk.Interop.Multivendor.ExportMetalObjectCreateInfo* extensionPointer = default(SharpVk.Interop.Multivendor.ExportMetalObjectCreateInfo*);
                extensionPointer = (SharpVk.Interop.Multivendor.ExportMetalObjectCreateInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Multivendor.ExportMetalObjectCreateInfo>());
                exportMetalObjectCreateInfoExt.Value.MarshalTo(extensionPointer);
                extensionPointer->Next = vkInstanceCreateInfoNextPointer;
                vkInstanceCreateInfoNextPointer = extensionPointer;
            }
            if (directDriverLoadingListLunarg != null)
            {
                SharpVk.Interop.Lunarg.DirectDriverLoadingList* extensionPointer = default(SharpVk.Interop.Lunarg.DirectDriverLoadingList*);
                extensionPointer = (SharpVk.Interop.Lunarg.DirectDriverLoadingList*)(Interop.HeapUtil.Allocate<SharpVk.Interop.Lunarg.DirectDriverLoadingList>());
                directDriverLoadingListLunarg.Value.MarshalTo(extensionPointer);
                extensionPointer->Next = vkInstanceCreateInfoNextPointer;
                vkInstanceCreateInfoNextPointer = extensionPointer;
            }
            this = new SharpVk.Interop.InstanceCreateInfo();
            this.SType = StructureType.InstanceCreateInfo;
            this.Next = vkInstanceCreateInfoNextPointer;
            if (flags != null)
            {
                this.Flags = flags.Value;
            }
            else
            {
                this.Flags = default(SharpVk.InstanceCreateFlags);
            }
            if (applicationInfo != null)
            {
                this.ApplicationInfo = (SharpVk.Interop.ApplicationInfo*)(Interop.HeapUtil.Allocate<SharpVk.Interop.ApplicationInfo>());
                applicationInfo.Value.MarshalTo(this.ApplicationInfo);
            }
            else
            {
                this.ApplicationInfo = default(SharpVk.Interop.ApplicationInfo*);
            }
            this.EnabledLayerCount = (uint)(Interop.HeapUtil.GetLength(enabledLayerNames));
            this.EnabledLayerNames = Interop.HeapUtil.MarshalTo(enabledLayerNames);
            this.EnabledExtensionCount = (uint)(Interop.HeapUtil.GetLength(enabledExtensionNames));
            this.EnabledExtensionNames = Interop.HeapUtil.MarshalTo(enabledExtensionNames);
        }
        
        /// <summary>
        /// The type of this structure.
        /// </summary>
        public SharpVk.StructureType SType; 
        
        /// <summary>
        /// Null or an extension-specific structure.
        /// </summary>
        public void* Next; 
        
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        public SharpVk.InstanceCreateFlags Flags; 
        
        /// <summary>
        /// Null or an instance of ApplicationInfo. If not Null, this
        /// information helps implementations recognize behavior inherent to
        /// classes of applications. ApplicationInfo is defined in detail
        /// below.
        /// </summary>
        public SharpVk.Interop.ApplicationInfo* ApplicationInfo; 
        
        /// <summary>
        /// The number of global layers to enable.
        /// </summary>
        public uint EnabledLayerCount; 
        
        /// <summary>
        /// An array of enabledLayerCount strings containing the names of
        /// layers to enable for the created instance. See the Layers section
        /// for further details.
        /// </summary>
        public byte** EnabledLayerNames; 
        
        /// <summary>
        /// The number of global extensions to enable.
        /// </summary>
        public uint EnabledExtensionCount; 
        
        /// <summary>
        /// An array of enabledExtensionCount strings containing the names of
        /// extensions to enable.
        /// </summary>
        public byte** EnabledExtensionNames; 
    }
}
