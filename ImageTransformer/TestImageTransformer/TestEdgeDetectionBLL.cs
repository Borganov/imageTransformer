﻿using ImageTransformer.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestImageTransformer
{
    [TestClass]
    public class TestEdgeDetectionBLL
    {
        Bitmap TestImage = new Bitmap(Path.Combine(Environment.CurrentDirectory, @"ImagesForTests\", "octocat.png"));

        [TestMethod]
        public void TestPrewittFilter()
        {
            ImageConverter imageConverter = new ImageConverter();

            Bitmap ToTest = EdgeDetectionBLL.PrewittFilter(TestImage);

            byte[] TestImageInBytes = (byte[])imageConverter.ConvertTo(ToTest, typeof(byte[]));

        }

        [TestMethod]
        public void TestKirschFilter()
        {
            ImageConverter imageConverter = new ImageConverter();

            Bitmap ToTest = EdgeDetectionBLL.KirschFilter(TestImage);

            byte[] TestImageInBytes = (byte[])imageConverter.ConvertTo(ToTest, typeof(byte[]));


        }
    }
}