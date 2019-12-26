using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestImageTransformer
{
    // Class impossible à runner ????!!!!
    [TestClass]
    class TestGetAndSaveImage
    {
        Bitmap TestImage = new Bitmap(Path.Combine(Environment.CurrentDirectory, @"ImagesForTests\", "octocat.png"));

        [TestMethod]
        public void TestgetImage()
        {
            ImageConverter imageConverter = new ImageConverter();
            var ImageManagerFile = Substitute.For<ImageTransformer.IOFiles.IInputOutput>();
            var ToTest = ImageManagerFile.getImage().Returns<Bitmap>(TestImage);
            byte[] TestImageInBytes = (byte[])imageConverter.ConvertTo(ToTest, typeof(byte[]));

            Assert.AreEqual(BitConverter.ToString(TestImageInBytes), "aaa");

        }
        [TestMethod]
        public void TestsaveImage()
        {
            var ImageManagerFile = Substitute.For<ImageTransformer.IOFiles.IInputOutput>();
            ImageManagerFile.saveImage(TestImage);

            Assert.AreEqual(1, 1);
        }
    }
}