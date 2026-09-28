using SharpVk.Generator.Specification.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpVk.Generator.Collation
{
    public class NameFormatter
    {
        private static readonly Dictionary<string, string> primitiveTypes = new Dictionary<string, string>()
        {
            {"void", "void"},
            {"char", "byte"},
            {"float", "float"},
            {"uint8_t", "byte"},
            {"uint16_t", "ushort"},
            {"uint32_t", "uint"},
            {"uint64_t", "ulong"},
            {"VkDeviceSize", "ulong"},
            {"VkDeviceAddress", "ulong"},
            {"int", "int"},
            {"DWORD", "uint"},
            {"int8_t", "sbyte"},
            {"int32_t", "int"},
            {"int64_t", "long"},
            {"size_t", "HostSize"},
            {"HINSTANCE", "IntPtr" },
            {"HMONITOR", "IntPtr" },
            {"HWND", "IntPtr" },
            {"HANDLE", "IntPtr" },
            {"SECURITY_ATTRIBUTES", "SecurityAttributes" },
            {"ANativeWindow", "IntPtr" },
            {"AHardwareBuffer", "IntPtr" },
            {"CAMetalLayer", "IntPtr" },
            {"Display", "IntPtr" },
            {"VisualID", "IntPtr" },
            {"Window", "IntPtr" },
            {"MirConnection", "IntPtr" },
            {"MirSurface", "IntPtr" },
            {"wl_display", "IntPtr" },
            {"wl_surface", "IntPtr" },
            {"xcb_connection_t", "IntPtr" },
            {"xcb_visualid_t", "IntPtr" },
            {"xcb_window_t", "IntPtr" },
            {"OHNativeWindow", "IntPtr" },
            {"RROutput", "IntPtr" },
            {"LPCWSTR", "IntPtr" },
            {"zx_handle_t", "uint" },
            {"GgpStreamDescriptor", "uint" },
            {"GgpFrameToken", "uint" },
            {"_screen_context", "IntPtr" },
            {"_screen_window", "IntPtr" },
            {"_screen_buffer", "IntPtr" },
            {"MTLBuffer_id", "IntPtr" },
            {"MTLCommandQueue_id", "IntPtr" },
            {"MTLDevice_id", "IntPtr" },
            {"MTLSharedEvent_id", "IntPtr" },
            {"MTLTexture_id", "IntPtr" },
            {"IOSurfaceRef", "IntPtr" },

            {"StdVideoDecodeH264PictureInfo", "IntPtr" },
            {"StdVideoDecodeH264ReferenceInfo", "IntPtr" },
            {"StdVideoH264SequenceParameterSet", "IntPtr" },
            {"StdVideoH264PictureParameterSet", "IntPtr" },
            {"StdVideoH264ProfileIdc", "int" },
            {"StdVideoH264LevelIdc", "int" },
            {"StdVideoEncodeH264SliceHeader", "IntPtr" },
            {"StdVideoEncodeH264RefMemMgmtCtrlOperations", "IntPtr" },
            {"StdVideoEncodeH264ReferenceInfo", "IntPtr" },
            {"StdVideoEncodeH264PictureInfo", "IntPtr" },

            {"StdVideoH265VideoParameterSet", "IntPtr" },
            {"StdVideoH265SequenceParameterSet", "IntPtr" },
            {"StdVideoEncodeH265SliceSegmentHeader", "IntPtr" },
            {"StdVideoEncodeH265ReferenceModifications", "IntPtr" },
            {"StdVideoEncodeH265ReferenceInfo", "IntPtr" },
            {"StdVideoEncodeH265PictureInfo", "IntPtr" },
            {"StdVideoDecodeH265ReferenceInfo", "IntPtr" },
            {"StdVideoDecodeH265PictureInfo", "IntPtr" },
            {"StdVideoH265ProfileIdc", "int" },
            {"StdVideoH265PictureParameterSet", "IntPtr" },
            {"StdVideoH265LevelIdc", "int" },

            {"StdVideoVP9Profile", "int" },
            {"StdVideoVP9Level", "int" },
            {"StdVideoDecodeVP9PictureInfo", "IntPtr" },

            {"StdVideoAV1Profile", "int" },
            {"StdVideoAV1Level", "int" },
            {"StdVideoDecodeAV1ReferenceInfo", "IntPtr" },
            {"StdVideoDecodeAV1PictureInfo", "IntPtr" },
            {"StdVideoEncodeAV1ReferenceInfo", "IntPtr" },
            {"StdVideoEncodeAV1PictureInfo", "IntPtr" },
            {"StdVideoEncodeAV1OperatingPointInfo", "IntPtr" },
            {"StdVideoEncodeAV1DecoderModelInfo", "IntPtr" },
            {"StdVideoAV1SequenceHeader", "IntPtr" },

            {"IDirectFB", "IntPtr" },
            {"IDirectFBSurface", "IntPtr" },
            {"VkDeviceOrHostAddressKHR", "IntPtr" },
            {"VkDeviceOrHostAddressConstKHR", "IntPtr" },
            {"VkDeviceOrHostAddressConstAMDX", "IntPtr" },
            {"VkRemoteAddressNV", "IntPtr" },

            {"NvSciSyncAttrList", "IntPtr" },
            {"NvSciSyncObj", "IntPtr" },
            {"NvSciSyncFence", "IntPtr" },
            {"NvSciBufAttrList", "IntPtr" },
            {"NvSciBufObj", "IntPtr" },

            {"ubm_device", "IntPtr" },
            {"ubm_surface", "IntPtr" },

            {"OH_NativeBuffer", "IntPtr" },
            {"OHBufferHandle", "IntPtr" },
        };

        private static readonly string[] digitsSuffix = new[] { "flags", "flag", "type", "bits", "bit" };

        public string FormatName(EnumElement enumeration)
        {
            return JoinNameParts(enumeration.NameParts);
        }

        public bool IsPrimitive(TypeElement type)
        {
            return primitiveTypes.ContainsKey(type.VkName);
        }

        public string FormatName(TypeElement type)
        {
            if (primitiveTypes.ContainsKey(type.VkName))
            {
                return primitiveTypes[type.VkName];
            }

            string result = JoinNameParts(type.NameParts);

            if (type.Category == TypeCategory.funcpointer)
            {
                result += "Delegate";
            }

            return result;
        }

        public string FormatName(EnumField field)
        {
            return JoinNameParts(field.NameParts);
        }

        public string FormatName(ChildElement member, string typeName, bool isCamelCase)
        {
            var nameParts = member.NameParts.AsEnumerable();

            if (nameParts.First() == "pfn")
            {
                nameParts = nameParts.Skip(1);
            }

            var result = JoinNameParts(nameParts);

            if (isCamelCase)
            {
                return Normalise(result.FirstToLower());
            }

            if (result == typeName)
            {
                return nameParts.Last().FirstToUpper() + "Value";
            }
            else
            {
                return result;
            }
        }

        public string FormatName(CommandElement command, TypeElement handleType)
        {
            var methodNameParts = command.NameParts;

            //Do not format TensorMemoryRequirementsARM since the extension provides GetTensorMemoryRequirements and DeviceGetTensorMemoryRequirements
            if (command.VkName.Contains("TensorMemoryRequirements"))
                return JoinNameParts(methodNameParts);

            int verbPrefixLength = 1;

            if (methodNameParts.First() != command.Verb)
            {
                verbPrefixLength = 0;
            }

            if (handleType.NameParts
                        .Zip(methodNameParts.Skip(verbPrefixLength), (x, y) => x == y)
                        .All(x => x))
            {
                methodNameParts = methodNameParts.Take(verbPrefixLength).Concat(methodNameParts.Skip(handleType.NameParts.Count() + verbPrefixLength)).ToArray();
            }
            else if (handleType.VkName == "VkDeviceMemory" && methodNameParts.Skip(verbPrefixLength).First() == "memory")
            {
                methodNameParts = methodNameParts.Take(verbPrefixLength).Concat(methodNameParts.Skip(verbPrefixLength + 1)).ToArray();
            }
            else if (handleType.VkName == "VkCommandBuffer" && methodNameParts.First() == "cmd")
            {
                methodNameParts = methodNameParts.Skip(1).ToArray();
            }

            return JoinNameParts(methodNameParts);
        }

        public string FormatName(EnumElement enumeration, EnumField value, bool isBitmask)
        {
            string digitsPrefix;
            int skipAtBeginning;
            int skipAtEnd;

            // Access2, Flags2, etc variants.
            if (enumeration.NameParts.Length >= 2 &&
                digitsSuffix.Contains(enumeration.NameParts[enumeration.NameParts.Length - 2]) &&
                int.TryParse(enumeration.NameParts.Last(), out _))
            {
                digitsPrefix = JoinNameParts(enumeration.NameParts.TakeWhile(x => !digitsSuffix.Contains(x)));

                skipAtEnd = isBitmask && digitsSuffix.Contains(value.NameParts.Last())
                                ? 2
                                : 0;
                skipAtBeginning = 1;
            }
            //Access, Flags, etc
            else
            {
                digitsPrefix = JoinNameParts(enumeration.NameParts.TakeWhile(x => !digitsSuffix.Contains(x)));

                skipAtEnd = isBitmask && digitsSuffix.Contains(value.NameParts.Last())
                                ? 1
                                : 0;
                skipAtBeginning = 0;
            }

            string result = JoinNameParts(value.NameParts.Skip(skipAtBeginning).Take(value.NameParts.Length - skipAtEnd));
            
            if (!char.IsLetter(result[0]))
            {
                result = digitsPrefix + result;
            }

            return result;
        }

        private static string JoinNameParts(IEnumerable<string> nameParts)
        {
            return nameParts
                        .Select(ExpandAbbreviations)
                        .Select(x => x.FirstToUpper())
                        .Aggregate(new StringBuilder(), (builder, value) => builder.Append(value))
                        .ToString();
        }

        private static string ExpandAbbreviations(string value)
        {
            switch (value)
            {
                case "src":
                    return "source";
                case "dst":
                    return "destination";
                case "cmd":
                    return "command";
                case "proc":
                    return "procedure";
                case "addr":
                    return "address";
                case "fd":
                    return "fileDescriptor";
                default:
                    return value;
            }
        }

        private static string Normalise(string name)
        {
            if (name == "event" || name == "object")
            {
                return $"@{name}";
            }
            else
            {
                return name;
            }
        }
    }
}
