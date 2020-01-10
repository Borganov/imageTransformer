﻿using ImageTransformer.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.IO;


namespace TestImageTransformer
{
    [TestClass]
    public class TestEdgeDetection
    {
        //Image for test
        Bitmap testImage = new Bitmap(Path.Combine(Environment.CurrentDirectory, @"ImagesForTests\", "octocat.png"));
        ImageConverter imageConverter = new ImageConverter();

        [TestMethod]
        public void TestPrewittFilter()
        {
            //Apply filter to the image to test
            Bitmap toTest = EdgeDetection.PrewittFilter(testImage);
            //Converte image to test in bytes
            byte[] testImageInBytes = (byte[])imageConverter.ConvertTo(toTest, typeof(byte[]));
            //True result to compare
            //Compare bytes in string
            Assert.AreEqual(BitConverter.ToString(testImageInBytes), theoricalResult);
         }

        [TestMethod]
        public void TestKirschFilter()
        {
            //Apply filter to the image to test
            Bitmap toTest = EdgeDetection.KirschFilter(testImage);
            //Converte image to test in bytes
            byte[] testImageInBytes = (byte[])imageConverter.ConvertTo(toTest, typeof(byte[]));
            //True result to compare
            //Compare bytes in string
            Assert.AreEqual(BitConverter.ToString(testImageInBytes), theoricalResult);
        }
    }
}