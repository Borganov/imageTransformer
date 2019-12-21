using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImageTransformer;
using System.Drawing;
using System.IO;
using System.Collections;
using ImageTransformer.Business;
using NSubstitute;

namespace TestImageTransformer
{
    [TestClass]
    public class TestFilterBLL
    {
        Bitmap TestImage = new Bitmap(Path.Combine(Environment.CurrentDirectory, @"ImagesForTests\", "img.png"));
        

        [TestMethod]
        public void TestSwap()
        {
            var ImageManagerFile = Substitute.For<ImageTransformer.IOFiles.IInputOutput>();
            ImageConverter imageConverter = new ImageConverter();

            Bitmap ToTest = ImageManagerFile.getImage();
            ToTest = FilterBLL.Swap(TestImage);

            byte[] TestImageInBytes = (byte[]) imageConverter.ConvertTo(ToTest, typeof(byte[]));

            Assert.AreEqual(BitConverter.ToString(TestImageInBytes), "89-50-4E-47-0D-0A-1A-0A-00-00-00-0D-49-48-44-52-00-00-00-02-00-00-00-01-08-06-00-00-00-F4-22-7F-8A-00-00-00-01-73-52-47-42-00-AE-CE-1C-E9-00-00-00-04-67-41-4D-41-00-00-B1-8F-0B-FC-61-05-00-00-00-09-70-48-59-73-00-00-0E-C3-00-00-0E-C3-01-C7-6F-A8-64-00-00-00-12-49-44-41-54-18-57-63-78-F3-E9-CB-FF-37-5F-DE-FE-07-00-22-1F-07-9E-18-5E-4F-54-00-00-00-00-49-45-4E-44-AE-42-60-82");
             
        }

        [TestMethod]
        public void TestRainbowFilter()
        {
            ImageConverter imageConverter = new ImageConverter();

            Bitmap ToTest = FilterBLL.RainbowFilter(TestImage);

            byte[] TestImageInBytes = (byte[])imageConverter.ConvertTo(ToTest, typeof(byte[]));

            Assert.AreEqual(BitConverter.ToString(TestImageInBytes), "89-50-4E-47-0D-0A-1A-0A-00-00-00-0D-49-48-44-52-00-00-00-02-00-00-00-01-08-06-00-00-00-F4-22-7F-8A-00-00-00-01-73-52-47-42-00-AE-CE-1C-E9-00-00-00-04-67-41-4D-41-00-00-B1-8F-0B-FC-61-05-00-00-00-09-70-48-59-73-00-00-0E-C3-00-00-0E-C3-01-C7-6F-A8-64-00-00-00-11-49-44-41-54-18-57-63-30-D0-37-F8-AF-AF-6F-F0-1F-00-0B-95-03-1C-58-1F-CE-BC-00-00-00-00-49-45-4E-44-AE-42-60-82");
        }
    }
}
