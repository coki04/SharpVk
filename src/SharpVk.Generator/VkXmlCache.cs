using System;
using System.IO;
using System.Xml.Linq;
using System.Net.Http;

namespace SharpVk.Generator
{
    public class VkXmlCache
        : IVkXmlCache
    {
        private readonly string tempFilePath;
        private readonly Lazy<XDocument> vkXml;
        private readonly Lazy<XDocument> videoXml;

        public VkXmlCache(string tempFilePath)
        {
            this.tempFilePath = tempFilePath;

            if (!Directory.Exists(this.tempFilePath))
            {
                Directory.CreateDirectory(this.tempFilePath);
            }

            this.vkXml = new Lazy<XDocument>(LoadVkXml("vk.xml"));
            this.videoXml = new Lazy<XDocument>(LoadVkXml("video.xml"));
        }

        public XDocument GetVkXml() => this.vkXml.Value;
        public XDocument GetVideoXml() => this.videoXml.Value;

        private XDocument LoadVkXml(string xmlName)
        {
            string tempFile = Path.Combine(this.tempFilePath, xmlName);

            if (!File.Exists(tempFile) || File.GetLastWriteTimeUtc(tempFile) + TimeSpan.FromDays(1) < DateTime.UtcNow)
            {
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(tempFile));

                    using (var client = new HttpClient())
                    {
                        var vkXmlRequest = client.GetStreamAsync(string.Format("https://raw.githubusercontent.com/KhronosGroup/Vulkan-Docs/main/xml/{0}", xmlName));
                        var vkXmlResponse = vkXmlRequest.GetAwaiter().GetResult();

                        if (File.Exists(tempFile))
                        {
                            File.Delete(tempFile);
                        }

                        using (var fileStream = File.OpenWrite(tempFile))
                        {
                            vkXmlResponse.CopyTo(fileStream);
                        }
                    }
                }
                catch
                {
                }
            }

            return XDocument.Load(tempFile);
        }
    }
}